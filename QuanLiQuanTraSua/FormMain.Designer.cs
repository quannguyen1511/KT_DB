namespace QuanLiQuanTraSua
{
    partial class FormMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainDown = new System.Windows.Forms.Panel();
            this.panelMainDownRight = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btEnter = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInfoBill = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainDownLeft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dtgvMenu = new System.Windows.Forms.DataGridView();
            this.panelShopName = new System.Windows.Forms.Panel();
            this.LbShopName = new System.Windows.Forms.Label();
            this.panelMenuStrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelMainDown.SuspendLayout();
            this.panelMainDownRight.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelInfoBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMainDownLeft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).BeginInit();
            this.panelShopName.SuspendLayout();
            this.panelMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelMainDown);
            this.panelMain.Controls.Add(this.panelMenuStrip);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1357, 745);
            this.panelMain.TabIndex = 0;
            // 
            // panelMainDown
            // 
            this.panelMainDown.Controls.Add(this.panelMainDownRight);
            this.panelMainDown.Controls.Add(this.panelMainDownLeft);
            this.panelMainDown.Location = new System.Drawing.Point(3, 64);
            this.panelMainDown.Name = "panelMainDown";
            this.panelMainDown.Size = new System.Drawing.Size(1351, 678);
            this.panelMainDown.TabIndex = 1;
            // 
            // panelMainDownRight
            // 
            this.panelMainDownRight.Controls.Add(this.panel5);
            this.panelMainDownRight.Controls.Add(this.panelInfoBill);
            this.panelMainDownRight.Controls.Add(this.panel1);
            this.panelMainDownRight.Location = new System.Drawing.Point(779, 3);
            this.panelMainDownRight.Name = "panelMainDownRight";
            this.panelMainDownRight.Size = new System.Drawing.Size(569, 670);
            this.panelMainDownRight.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btEnter);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(4, 602);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(561, 65);
            this.panel5.TabIndex = 2;
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(402, 20);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(124, 32);
            this.btEnter.TabIndex = 2;
            this.btEnter.Text = "Tính Tiền";
            this.btEnter.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(175, 20);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(189, 32);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Tiền:";
            // 
            // panelInfoBill
            // 
            this.panelInfoBill.Controls.Add(this.lvBill);
            this.panelInfoBill.Location = new System.Drawing.Point(4, 91);
            this.panelInfoBill.Name = "panelInfoBill";
            this.panelInfoBill.Size = new System.Drawing.Size(561, 505);
            this.panelInfoBill.TabIndex = 1;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Location = new System.Drawing.Point(4, 4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(554, 498);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thức uống";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng";
            this.columnHeader4.Width = 134;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMainDownLeft
            // 
            this.panelMainDownLeft.Controls.Add(this.panelMenu);
            this.panelMainDownLeft.Controls.Add(this.panelShopName);
            this.panelMainDownLeft.Location = new System.Drawing.Point(3, 3);
            this.panelMainDownLeft.Name = "panelMainDownLeft";
            this.panelMainDownLeft.Size = new System.Drawing.Size(770, 670);
            this.panelMainDownLeft.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.dtgvMenu);
            this.panelMenu.Location = new System.Drawing.Point(5, 90);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(762, 577);
            this.panelMenu.TabIndex = 1;
            // 
            // dtgvMenu
            // 
            this.dtgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMenu.Location = new System.Drawing.Point(3, 3);
            this.dtgvMenu.Name = "dtgvMenu";
            this.dtgvMenu.RowTemplate.Height = 24;
            this.dtgvMenu.Size = new System.Drawing.Size(756, 574);
            this.dtgvMenu.TabIndex = 0;
            // 
            // panelShopName
            // 
            this.panelShopName.Controls.Add(this.LbShopName);
            this.panelShopName.Location = new System.Drawing.Point(5, 3);
            this.panelShopName.Name = "panelShopName";
            this.panelShopName.Size = new System.Drawing.Size(762, 81);
            this.panelShopName.TabIndex = 0;
            // 
            // LbShopName
            // 
            this.LbShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbShopName.ForeColor = System.Drawing.Color.Fuchsia;
            this.LbShopName.Location = new System.Drawing.Point(4, 4);
            this.LbShopName.Name = "LbShopName";
            this.LbShopName.Size = new System.Drawing.Size(755, 68);
            this.LbShopName.TabIndex = 0;
            this.LbShopName.Text = "Trà Sữa 3 Thành Viên ";
            this.LbShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuStrip
            // 
            this.panelMenuStrip.Controls.Add(this.menuStrip1);
            this.panelMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.panelMenuStrip.Name = "panelMenuStrip";
            this.panelMenuStrip.Size = new System.Drawing.Size(1351, 55);
            this.panelMenuStrip.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.lậpBáoCáoToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // lậpBáoCáoToolStripMenuItem
            // 
            this.lậpBáoCáoToolStripMenuItem.Name = "lậpBáoCáoToolStripMenuItem";
            this.lậpBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.lậpBáoCáoToolStripMenuItem.Text = "Lập Báo cáo";
            this.lậpBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.lậpBáoCáoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trà sữa 3 Thành Viên";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMainDown.ResumeLayout(false);
            this.panelMainDownRight.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelInfoBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMainDownLeft.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).EndInit();
            this.panelShopName.ResumeLayout(false);
            this.panelMenuStrip.ResumeLayout(false);
            this.panelMenuStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainDown;
        private System.Windows.Forms.Panel panelMainDownRight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelInfoBill;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMainDownLeft;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelShopName;
        private System.Windows.Forms.Label LbShopName;
        private System.Windows.Forms.Panel panelMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dtgvMenu;
        private System.Windows.Forms.Timer timer1;
    }
}