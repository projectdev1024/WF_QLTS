namespace WF_QLTS.Views
{
    partial class frmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRepass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtOldPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(49, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(142, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mật khẩu mới";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(49, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(142, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Xác nhận mật khẩu";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.Border.Class = "TextBoxBorder";
            this.txtNewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPass.Location = new System.Drawing.Point(197, 69);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(237, 22);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtRepass
            // 
            // 
            // 
            // 
            this.txtRepass.Border.Class = "TextBoxBorder";
            this.txtRepass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRepass.Location = new System.Drawing.Point(197, 109);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Size = new System.Drawing.Size(237, 22);
            this.txtRepass.TabIndex = 3;
            this.txtRepass.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(136, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 48);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Hoàn thành";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(282, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 48);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(49, 28);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(142, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Mật khẩu cũ";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtOldPass
            // 
            // 
            // 
            // 
            this.txtOldPass.Border.Class = "TextBoxBorder";
            this.txtOldPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldPass.Location = new System.Drawing.Point(197, 29);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(237, 22);
            this.txtOldPass.TabIndex = 2;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRepass;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOldPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}