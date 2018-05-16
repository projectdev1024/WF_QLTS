using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTS.Views
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var r = true;
            if(txtNewPass.Text != txtRepass.Text)
            {
                errorProvider1.SetError(txtNewPass, "Mật khẩu không trùng khớp");
                errorProvider1.SetError(txtRepass, "Mật khẩu không trùng khớp");
                r = false;
            }
            else if(txtNewPass.Text.Length < 8)
            {
                errorProvider1.SetError(txtNewPass, "Mật khẩu phải có ít nhất 8 kí tự");
                r = false;
            }
            if(txtOldPass.Text != COMMON.User.Password)
            {
                errorProvider1.SetError(txtOldPass, "Mật khẩu cũ không đúng");
                r = false;
            }
            if (r)
            {
                var db = new dbQLTSEntities();
                if(db.Accounts.ToList().FirstOrDefault(q=>q.IDAccount == COMMON.User.IDAccount) is Account acc)
                {
                    acc.Password = txtNewPass.Text;
                    if (db.SaveChanges() > 0 == false)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        Close();
                    }
                }
                else Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
