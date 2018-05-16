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
    public partial class frmPosition : Form, Usercontrols.Core.IManager
    {
        public frmPosition()
        {
            InitializeComponent();
            this.Text = Title();
        }

        public DataGridViewColumn[] createColumns()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn(){DataPropertyName = "Name" , HeaderText = "Tên chức vụ"},
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
            if (dataBoundItem is Position acc)
            {
                var db = new dbQLTSEntities();
                acc.IsDelete = true;
                if (db.Positions.ToList().FirstOrDefault(q => q.IDPosition == acc.IDPosition) is Position x)
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
            return new BindingList<Position>(new dbQLTSEntities().Positions.ToList().Where(q => q.IsDelete != true).ToList());
        }

        public bool Save(object dataBoundItem)
        {
            if (dataBoundItem is Position acc)
            {
                var db = new dbQLTSEntities();
                if (acc.IDPosition == 0)
                {
                    acc.IsDelete = false;
                    db.Positions.Add(acc);
                }
                else
                {
                    if (db.Positions.ToList().FirstOrDefault(q => q.IDPosition == acc.IDPosition) is Position x)
                    {
                        db.Entry(x).CurrentValues.SetValues(acc);
                    }
                    else throw new Exception("Đối tượng không tồn tại");
                }
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public string Title()
        {
            return "DANH SÁCH CHỨC VỤ";
        }

        public bool Validate(object dataBoundItem, DataGridViewCellCollection cells)
        {
            if (dataBoundItem is Position acc)
            {
                return cells[0].Validate(s =>
                {
                    if (string.IsNullOrWhiteSpace(s + ""))
                    {
                        return new KeyValuePair<bool, string>(false, "Vui lòng nhập tên chức vụ");
                    }
                    var lst = new dbQLTSEntities().Database.SqlQuery<int>(" select IDPosition from Position where IsDelete <> 1 and IDPosition <> @IDPosition and Name = @Name ", new SqlParameter("@IDPosition", acc.IDPosition), new SqlParameter("@Name", acc.Name));
                    return new KeyValuePair<bool, string>(lst.Count() == 0, "Tên chức vụ đã được sử dụng.");
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
            return new BindingList<Position>(new dbQLTSEntities().Positions.ToList()
                .Where(q => (q.Name + "").Contains(sKey)).ToList());
        }
    }
}
