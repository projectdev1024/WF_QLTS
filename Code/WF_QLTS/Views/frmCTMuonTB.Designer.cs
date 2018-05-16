namespace WF_QLTS.Views
{
    partial class frmCTMuonTB
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
            this.ucManager1 = new WF_QLTS.Usercontrols.ucManager();
            this.SuspendLayout();
            // 
            // ucManager1
            // 
            this.ucManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManager1.LinkColumnClick = null;
            this.ucManager1.Location = new System.Drawing.Point(0, 0);
            this.ucManager1.Manager = null;
            this.ucManager1.Margin = new System.Windows.Forms.Padding(2);
            this.ucManager1.Name = "ucManager1";
            this.ucManager1.Size = new System.Drawing.Size(752, 424);
            this.ucManager1.TabIndex = 0;
            this.ucManager1.Load += new System.EventHandler(this.ucManager1_Load);
            // 
            // frmCTMuonTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 424);
            this.Controls.Add(this.ucManager1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCTMuonTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private Usercontrols.ucManager ucManager1;
    }
}