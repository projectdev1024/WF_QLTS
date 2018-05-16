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
    public partial class frmThietBi : Form, Usercontrols.Core.IManager
    {
        public frmThietBi()
        {
            InitializeComponent();
            this.Text = Title();
        }

        public DataGridViewColumn[] createColumns()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewMaskedTextBoxAdvColumn(){DataPropertyName = "Code" , HeaderText = "Mã thiết bị", Mask="AAAAAA"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Name" , HeaderText = "Tên thiết bị"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Price" , HeaderText = "Giá"},
                new DataGridViewIntegerInputColumn(){DataPropertyName = "Total", HeaderText = "Tổng thiết bị"},
                new DataGridViewIntegerInputColumn(){DataPropertyName = "CanUse" , HeaderText = "Có thể sử dụng", ReadOnly= true},
                new DataGridViewIntegerInputColumn(){DataPropertyName = "Bad" , HeaderText = "Bị hỏng", ReadOnly= true},
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
            if (dataBoundItem is ThietBi acc)
            {
                var db = new dbQLTSEntities();
                acc.Status = true;
                if (db.ThietBis.ToList().FirstOrDefault(q => q.IDThietBi == acc.IDThietBi) is ThietBi x)
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
            return new BindingList<ThietBi>(new dbQLTSEntities().ThietBis.ToList().Where(q => q.Status != true).ToList());
        }

        public bool Save(object dataBoundItem)
        {
            if (dataBoundItem is ThietBi acc)
            {
                var db = new dbQLTSEntities();
                if (acc.IDThietBi == 0)
                {
                    acc.Status = false;
                    acc.Bad = 0;
                    acc.CanUse = acc.Total ?? 0;
                    db.ThietBis.Add(acc);
                }
                else
                {
                    if (db.ThietBis.ToList().FirstOrDefault(q => q.IDThietBi == acc.IDThietBi) is ThietBi x)
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
            return "DANH SÁCH THIẾT BỊ";
        }

        public bool Validate(object dataBoundItem, DataGridViewCellCollection cells)
        {
            if (dataBoundItem is ThietBi acc)
            {
                var r = cells[0].Validate(s =>
                {
                    var lst = new dbQLTSEntities().Database.SqlQuery<int>(" select IDThietBi from ThietBi where Status <> 1 and IDThietBi <> @IDThietBi and Code = @Code ", new SqlParameter("@IDThietBi", acc.IDThietBi), new SqlParameter("@Code", acc.Code));
                    return new KeyValuePair<bool, string>(lst.Count() == 0, "Mã thiết bị đã được sử dụng.");
                });
                r = r & cells[1].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
                r = r & cells[2].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
                return r & cells[3].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng giá trị");
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
            return new BindingList<ThietBi>(new dbQLTSEntities().ThietBis.ToList()
                .Where(q => (q.Bad + "").Contains(sKey)
                || (q.Total + "").Contains(sKey)
                || (q.Price + "").ToString().Contains(sKey)
                || (q.Name + "").Contains(sKey)
                || q.IDThietBi.ToString().Contains(sKey)
                || (q.Code + "").Contains(sKey)
                || (q.CanUse + "").Contains(sKey)
                ).ToList());
        }
    }
}
