using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTS
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm, Usercontrols.Core.IManager
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            _login();
            _reload();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _login();
        }

        private void _login()
        {
            if (new frmLogin().ShowDialog() == DialogResult.Yes)
            {
                _reload();
            }
            else
            {
                Close();
            }
        }

        private void _reload()
        {
            lblSystemUser.Text = COMMON.User == null ? "| Vui lòng đăng nhập." : "| Xin chào, " + COMMON.User.FullName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new Views.frmAccount().ShowDialog();
            _reload();
        }

        public bool Save(object dataBoundItem)
        {
            if (dataBoundItem is MuonTB ob)
            {
                var db = new dbQLTSEntities();
                if (ob.IDMuonTB <= 0)
                {
                    ob.CreateBy = COMMON.User.IDAccount;
                    ob.CreateTime = DateTime.Now;
                    ob.Status = false;
                    db.MuonTBs.Add(ob);
                }
                else
                {
                    var obj = db.MuonTBs.ToList().FirstOrDefault(q => q.IDMuonTB == ob.IDMuonTB);
                    if (obj is MuonTB)
                    {
                        db.Entry(obj).CurrentValues.SetValues(ob);
                    }
                    else return false;
                }
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public string Title()
        {
            return "DANH SÁCH PHIẾU MƯỢN THIẾT BỊ";
        }

        public DataGridViewColumn[] createColumns()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "IDMuonTB" ,
                    HeaderText = "Mã phiếu mượn",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.Lavender
                    }
                },
                new DataGridViewComboBoxExColumn()
                {
                    DataPropertyName ="IDAccount",
                    HeaderText ="Người mượn",
                    DataSource = new BindingList<Account>(new dbQLTSEntities().Accounts.ToList()),DisplayMember="FullName",ValueMember = "IDAccount",
                    DropDownStyle = ComboBoxStyle.DropDownList
                },
                new DataGridViewDateTimeInputColumn(){DataPropertyName = "TimeStart" , HeaderText = "T.Gian Đ.Kí mượn"},
                new DataGridViewDateTimeInputColumn(){DataPropertyName = "TimeEnd" , HeaderText = "T.Gian Đ.Kí trả"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Note" , HeaderText = "Ghi chú"},
                new DataGridViewCheckBoxXColumn
                {
                    DataPropertyName = "Status" ,
                    HeaderText = "Trạng thái",
                    Text = "Đã trả"
                },
                new DataGridViewDateTimeInputColumn
                {
                    DataPropertyName = "CreateTime" ,
                    HeaderText = "Ngày tạo phiếu",
                    ReadOnly = true,
                    DefaultCellStyle= new DataGridViewCellStyle
                    {
                        BackColor = Color.Lavender
                    }
                },
                new DataGridViewComboBoxExColumn()
                {
                    DataPropertyName ="CreateBy",
                    HeaderText = "Người tạo phiếu",
                    DataSource = new BindingList<Account>(new dbQLTSEntities().Accounts.ToList()),DisplayMember="FullName",ValueMember = "IDAccount",
                    ReadOnly = true,
                    DropDownStyle = ComboBoxStyle.DropDownList
                },
                new DataGridViewLinkColumn()
                {
                    HeaderText = "",
                    Text="Chi tiết",
                    UseColumnTextForLinkValue = true,
                },
                 new DataGridViewButtonXColumn
                {
                    Text = "XÓA",
                    HeaderText = "XÓA",
                    UseColumnTextForButtonValue = true,
                }
            };
        }

        public object GetDataSource()
        {
            return new BindingList<MuonTB>(new dbQLTSEntities().MuonTBs.ToList());
        }

        public bool Validate(object dataBoundItem, DataGridViewCellCollection cells)
        {
            if (dataBoundItem is MuonTB acc)
            {
                var r = cells[1].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
                r = r & cells[2].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
                return r & cells[3].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
            }
            return false;
        }

        public bool Delete(object dataBoundItem)
        {
            if (dataBoundItem is MuonTB muontb)
            {
                var db = new dbQLTSEntities();
                if (db.MuonTBs.ToList().FirstOrDefault(q => q.IDMuonTB == muontb.IDMuonTB) is MuonTB value)
                {
                    var ct = value.CTMuonTBs.ToArray();
                    foreach (var item in ct)
                    {
                        db.CTMuonTBs.Remove(item);
                    }
                    db.MuonTBs.Remove(value);
                    return db.SaveChanges() > 0;
                }
                else throw new Exception("Vui lòng reload");
            }
            return false;
        }

        private void ucManager1_Load(object sender, EventArgs e)
        {
            ucManager1.LoadData(this);
            ucManager1.LinkColumnClick = new EventHandler((ob, v) =>
             {
                 if (ob is MuonTB x)
                 {
                     new Views.frmCTMuonTB() { muonTB = x }.ShowDialog();
                 }
             });
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            new Views.frmPosition().ShowDialog();
            _reload();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            new Views.frmThietBi().ShowDialog();
            _reload();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            new Views.frmChangePassword().ShowDialog();
        }

        public object Search(string sKey)
        {
            var acc = new dbQLTSEntities().Accounts.ToList().Where(q => q.FullName.Contains(sKey)).Select(q => q.IDAccount).ToList();

            return new BindingList<MuonTB>(new dbQLTSEntities().MuonTBs.ToList()
                .Where(q => q.Account.FullName.Contains(sKey)
                || acc.Any(a => a == q.IDAccount || a == q.CreateBy)
                || q.Account.FullName.Contains(sKey)
                || q.Account.FullName.Contains(sKey)
                || q.CreateTime.ToString().Contains(sKey)
                || q.TimeEnd.ToString().Contains(sKey)
                || q.TimeStart.ToString().Contains(sKey)
                || q.IDMuonTB.ToString().Contains(sKey)
                || q.Note.Contains(sKey)
                ).ToList());
        }
    }
}
