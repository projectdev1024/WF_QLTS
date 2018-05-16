using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using WF_QLTS.Usercontrols.Core;

namespace WF_QLTS.Usercontrols
{
    public partial class ucManager : UserControl
    {
        private bool _CancelRowEdit;
        private bool _CellBeginEdit;
        private bool _DoSave;
        public IManager Manager { get; set; }
        public EventHandler LinkColumnClick { get; set; }

        public ucManager()
        {
            InitializeComponent();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var row = (sender as DataGridViewX).Rows[e.RowIndex];
                if (row.Cells[e.ColumnIndex] is DataGridViewButtonXCell
                    && row.DataBoundItem != null
                    && MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Manager.Delete(row.DataBoundItem) == false)
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        (sender as DataGridViewX).Rows.RemoveAt(e.RowIndex);
                    }
                }
                else if (LinkColumnClick != null && row.Cells[e.ColumnIndex] is DataGridViewLinkCell && row.DataBoundItem != null)
                {
                    LinkColumnClick(row.DataBoundItem, new EventArgs());
                }
            }
        }

        private void dataGridViewX1_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            _CancelRowEdit = true;
        }

        private void dataGridViewX1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (_CancelRowEdit)
            {
                _CancelRowEdit = false;
            }
            else if (_CellBeginEdit)
            {
                _CellBeginEdit = false;
                _DoSave = true;
            }
        }

        public void Init()
        {
            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewX1.Columns.AddRange(Manager.createColumns());
            groupPanel1.Text = Manager.Title();
            _bindata();
            foreach (DataGridViewColumn item in dataGridViewX1.Columns)
            {
                if (item.ReadOnly) item.DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Lavender
                };
            }
        }

        private void _bindata()
        {
            dataGridViewX1.DataSource = Manager.GetDataSource();
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Manager.Delete(e.Row.DataBoundItem) == false)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else e.Cancel = true;
            }
        }

        private void dataGridViewX1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _CellBeginEdit = true;
            var row = (sender as DataGridViewX).Rows[e.RowIndex];
            if (row.HasDefaultCellStyle == false)
            {
                row.DefaultCellStyle.BackColor = row.DataBoundItem == null ? Color.NavajoWhite : Color.Beige;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _bindata();
        }

        private void dataGridViewX1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_DoSave)
            {
                _DoSave = false;
                var row = (sender as DataGridViewX).Rows[e.RowIndex];
                try
                {
                    if (Manager.Validate(row.DataBoundItem, row.Cells))
                    {
                        row.ErrorText = Manager.Save(row.DataBoundItem) ? "" : "Lưu thất bại.";
                        dataGridViewX1.Refresh();
                    }
                    else row.ErrorText = "Giá trị không hợp lệ.";
                }
                catch (Exception ex)
                {
                    row.ErrorText = ex.Message;
                }
            }
        }

        private void dataGridViewX1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridViewX).Rows[e.RowIndex];
            if (row.Cells[e.ColumnIndex] is DataGridViewCheckBoxXCell cb
                && row.DataBoundItem != null)
            {
                _DoSave = true;
                dataGridViewX1_CellEndEdit(sender, e);
            }
        }

        public void LoadData(IManager manager)
        {
            this.Manager = manager;
            Init();
        }

        void _search()
        {
            dataGridViewX1.DataSource = string.IsNullOrEmpty(txtSearch.Text) ? Manager.GetDataSource() : Manager.Search(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _search();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            _search();
        }
    }
}
