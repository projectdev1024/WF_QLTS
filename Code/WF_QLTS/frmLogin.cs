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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            COMMON.User = new dbQLTSEntities().Accounts.ToList()
                .FirstOrDefault(q => q.Username.Equals(txtUsername.Text) && q.Password.Equals(txtPassword.Text));
            if(COMMON.User == null)
            {
                MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //btnLogin_Click(sender, e);
        }
    }
}
