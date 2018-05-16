using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTS.Views
{
    public partial class frmAccount : Form, Usercontrols.Core.IManager
    {
        public frmAccount()
        {
            InitializeComponent();
            this.Text = Title();
        }

        public DataGridViewColumn[] createColumns()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn(){DataPropertyName = "FullName" , HeaderText = "Họ tên"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Username" , HeaderText = "Tên đăng nhập"},
                new DataGridViewMaskedTextBoxAdvColumn(){DataPropertyName = "Phone" , HeaderText = "SDT", Mask="99999999999"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Email" , HeaderText = "Email"},
                new DataGridViewDateTimeInputColumn(){DataPropertyName = "Birthday" , HeaderText = "Ngày sinh"},
                new DataGridViewCheckBoxXColumn(){DataPropertyName = "Male",Text="Nam" , HeaderText = "Nam/Nữ"},
                new DataGridViewComboBoxColumn()
                {
                    DataPropertyName ="IDPosition",
                    HeaderText ="Chức vụ",
                    DataSource = new BindingList<Position>(new dbQLTSEntities().Positions.ToList()),
                    DisplayMember ="Name",
                    ValueMember = "IDPosition",
                },
                new DataGridViewButtonXColumn
                {
                    Text = "XÓA",
                    HeaderText = "XÓA",
                    UseColumnTextForButtonValue = true,
                }
            };
        }

        public bool Delete(object dataBoundItem)
        {
            if (dataBoundItem is Account acc)
            {
                var db = new dbQLTSEntities();
                acc.Status = true;
                if (db.Accounts.ToList().FirstOrDefault(q => q.IDAccount == acc.IDAccount) is Account x)
                {
                    db.Entry(x).CurrentValues.SetValues(acc);
                }
                else return false;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public object GetDataSource()
        {
            return new BindingList<Account>(new dbQLTSEntities().Accounts.ToList().Where(q => q.Status != true).ToList());
        }

        public bool Save(object dataBoundItem)
        {
            if (dataBoundItem is Account acc)
            {
                var db = new dbQLTSEntities();
                if (acc.IDAccount == 0)
                {
                    acc.Status = false;
                    acc.Password = "12345678";
                    db.Accounts.Add(acc);
                }
                else
                {
                    if (db.Accounts.ToList().FirstOrDefault(q => q.IDAccount == acc.IDAccount) is Account x)
                    {
                        db.Entry(x).CurrentValues.SetValues(acc);
                    }
                    else return false;
                }
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public string Title()
        {
            return "DANH SÁCH NGƯỜI DÙNG";
        }

        public bool Validate(object dataBoundItem, DataGridViewCellCollection cells)
        {
            if (dataBoundItem is Account acc)
            {
                var r = cells[1].Validate(s =>
                {
                    var lst = new dbQLTSEntities().Database.SqlQuery<int>(" select IDAccount from Account where Status <> 1 and IDAccount <> @IDAccount and Username = @Username ", new SqlParameter("@IDAccount", acc.IDAccount), new SqlParameter("@Username", acc.Username));
                    return new KeyValuePair<bool, string>(lst.Count() == 0, "Tên đăng nhập đã được sử dụng.");
                });
                r = r & cells[0].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập họ tên");
                });
                return r & cells[6].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng chọn chức vụ");
                });
            }
            return false;
        }

        private void ucManager1_Load(object sender, EventArgs e)
        {
            ucManager1.LoadData(this);
        }

        public object Search(string sKey)
        {
            return new BindingList<Account>(new dbQLTSEntities().Accounts.ToList()
                .Where(q => (q.FullName + "").Contains(sKey)
                || (q.Email + "").Contains(sKey)
                || (q.Birthday + "").Contains(sKey)
                || (q.Phone + "").Contains(sKey)
                || (q.Username + "").Contains(sKey)
                || (q.Position.Name + "").Contains(sKey)
                ).ToList());
        }
    }
}
