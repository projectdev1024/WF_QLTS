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
    public partial class frmCTMuonTB : Form, Usercontrols.Core.IManager
    {
        public MuonTB muonTB { get; set; }
        public frmCTMuonTB()
        {
            InitializeComponent();
        }

        public DataGridViewColumn[] createColumns()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewComboBoxExColumn()
                {
                    DataPropertyName ="IDThietBi",
                    HeaderText ="Mã thiết bị",
                    DataSource = new BindingList<ThietBi>(new dbQLTSEntities().ThietBis.ToList()),
                    DisplayMember ="Code",
                    ValueMember = "IDThietBi",
                    DropDownStyle = ComboBoxStyle.DropDownList
                },
                new DataGridViewIntegerInputColumn(){DataPropertyName = "Total", HeaderText = "Tổng thiết bị mượn"},
                new DataGridViewTextBoxColumn(){DataPropertyName = "Note" , HeaderText = "Ghi chú"},
                new DataGridViewIntegerInputColumn(){DataPropertyName = "Bad" , HeaderText = "Số thiết bị hỏng", ReadOnly = muonTB.Status != true},
                new DataGridViewButtonXColumn
                {
                    Text = "XÓA",
                    HeaderText = "XÓA",
                    UseColumnTextForButtonValue = true,
                }
            };
        }
        public bool Validate(object dataBoundItem, DataGridViewCellCollection cells)
        {
            if (dataBoundItem is CTMuonTB ct)
            {
                var r = true;
                if (muonTB.Status != true)
                {
                    r = cells[3].Validate(s =>
                    {
                        return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                    });
                }
                r = r & cells[1].Validate(s =>
                {
                    int t = 0;
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false
                        && int.TryParse(s + "", out t) && t > 0, "Vui lòng nhập giá trị lớn hơn 0");
                });
                return r & cells[0].Validate(s =>
                {
                    return new KeyValuePair<bool, string>(string.IsNullOrWhiteSpace(s.ToString()) == false, "Vui lòng nhập giá trị");
                });
            }
            return false;
        }

        public bool Delete(object dataBoundItem)
        {
            if (dataBoundItem is CTMuonTB ct)
            {
                var db = new dbQLTSEntities();
                if (db.CTMuonTBs.ToList().FirstOrDefault(q => q.IDMuonTB == ct.IDMuonTB && q.IDThietBi == ct.IDThietBi) is CTMuonTB x)
                {
                    db.CTMuonTBs.Remove(x);
                }
                else return false;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public object GetDataSource()
        {
            return new BindingList<CTMuonTB>(new dbQLTSEntities().CTMuonTBs.ToList());
        }

        public bool Save(object dataBoundItem)
        {
            if (dataBoundItem is CTMuonTB ct)
            {
                var db = new dbQLTSEntities();
                if (ct.IDCTMuon == 0)
                {
                    if (muonTB.Status == false)
                    {
                        ct.Bad = 0;
                        ct.IDMuonTB = muonTB.IDMuonTB;
                        db.CTMuonTBs.Add(ct);
                    }
                    else throw new Exception("Không thể thêm thiết bị cho phiếu mượn đẵ trả.");
                }
                else
                {
                    if (db.CTMuonTBs.ToList().FirstOrDefault(q => q.IDCTMuon == ct.IDCTMuon) is CTMuonTB obj)
                    {
                        if (db.ThietBis.ToList().FirstOrDefault(q => q.IDThietBi == ct.IDThietBi) is ThietBi tb)
                        {
                            var bad = ct.Bad - obj.Bad;
                            tb.Bad += bad;
                            tb.CanUse -= bad;
                        }
                        else throw new Exception("Phiếu mượn không tồn tại, vui lòng reload");
                        db.Entry(obj).CurrentValues.SetValues(ct);
                    }
                    else throw new Exception("Chi tiết không tồn tại, vui lòng reload");
                }

                return db.SaveChanges() > 0;
            }
            return false;
        }

        public string Title()
        {
            return "";
        }

        private void ucManager1_Load(object sender, EventArgs e)
        {
            ucManager1.LoadData(this);
            var acc = new dbQLTSEntities().Accounts.ToList().FirstOrDefault(q => q.IDAccount == muonTB.IDAccount);
            this.Text = $"DANH SÁCH THIẾT BỊ MƯỢN  #PHIẾU:[{muonTB.IDMuonTB}] - #NGƯỜI MƯỢN:[{acc.FullName}]";
        }

        public object Search(string sKey)
        {
            return new BindingList<CTMuonTB>(new dbQLTSEntities().CTMuonTBs.ToList()
                .Where(q => (q.Bad + "").Contains(sKey)
                || (q.Total + "").Contains(sKey)
                || (q.ThietBi.Name + "").Contains(sKey)
                || (q.Note + "").Contains(sKey)
                ).ToList());
        }
    }
}
