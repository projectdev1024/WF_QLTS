namespace WF_QLTS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnLogin = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAccount = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.microChartItem1 = new DevComponents.DotNetBar.MicroChartItem();
            this.microChartItem2 = new DevComponents.DotNetBar.MicroChartItem();
            this.microChartItem3 = new DevComponents.DotNetBar.MicroChartItem();
            this.microChartItem4 = new DevComponents.DotNetBar.MicroChartItem();
            this.microChartItem5 = new DevComponents.DotNetBar.MicroChartItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSystemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSystemUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ucManager1 = new WF_QLTS.Usercontrols.ucManager();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(966, 173);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 62);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(966, 108);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.btnLogin});
            this.ribbonBar2.Location = new System.Drawing.Point(292, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(194, 105);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 5;
            this.ribbonBar2.Text = "HỆ THỐNG";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "<div width=\"80\" align=\"center\">Đổi mật khẩu</div>";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnLogin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.SubItemsExpandWidth = 14;
            this.btnLogin.Text = "<div width=\"80\" align=\"center\">Đăng xuất</div>";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.btnAccount,
            this.buttonItem3});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(289, 105);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 4;
            this.ribbonBar3.Text = "DANH MỤC";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "<div width=\"80\" align=\"center\">Chức vụ</div>";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.SubItemsExpandWidth = 14;
            this.btnAccount.Text = "<div width=\"80\" align=\"center\">Tài khoản</div>";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            this.buttonItem3.Text = "<div width=\"80\" align=\"center\">Thiết bị</div>";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTabItem1.Image")));
            this.ribbonTabItem1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "TRANG CHỦ";
            // 
            // microChartItem1
            // 
            this.microChartItem1.Name = "microChartItem1";
            // 
            // microChartItem2
            // 
            this.microChartItem2.Name = "microChartItem2";
            // 
            // microChartItem3
            // 
            this.microChartItem3.Name = "microChartItem3";
            // 
            // microChartItem4
            // 
            this.microChartItem4.Name = "microChartItem4";
            // 
            // microChartItem5
            // 
            this.microChartItem5.Name = "microChartItem5";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSystemTime,
            this.lblSystemUser});
            this.statusStrip1.Location = new System.Drawing.Point(5, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(143, 20);
            this.lblSystemTime.Text = "00:00:00 00/00/0000";
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(150, 20);
            this.lblSystemUser.Text = "| Vui lòng đăng nhập.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ucManager1
            // 
            this.ucManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManager1.LinkColumnClick = null;
            this.ucManager1.Location = new System.Drawing.Point(5, 174);
            this.ucManager1.Manager = null;
            this.ucManager1.Name = "ucManager1";
            this.ucManager1.Size = new System.Drawing.Size(966, 352);
            this.ucManager1.TabIndex = 2;
            this.ucManager1.Load += new System.EventHandler(this.ucManager1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.ucManager1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ TÀI SẢN TRƯỜNG ĐẠI HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.MicroChartItem microChartItem1;
        private DevComponents.DotNetBar.MicroChartItem microChartItem2;
        private DevComponents.DotNetBar.MicroChartItem microChartItem3;
        private DevComponents.DotNetBar.MicroChartItem microChartItem4;
        private DevComponents.DotNetBar.MicroChartItem microChartItem5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSystemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblSystemUser;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private Usercontrols.ucManager ucManager1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnAccount;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem btnLogin;
    }
}

