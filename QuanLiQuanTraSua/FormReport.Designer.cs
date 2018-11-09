namespace QuanLiQuanTraSua
{
    partial class FormReport
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
            this.panelFormReport = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfoFormReport = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtTotalRevenu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtWeek = new System.Windows.Forms.RadioButton();
            this.rbtMonth = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFormReport.SuspendLayout();
            this.panelInfoFormReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormReport
            // 
            this.panelFormReport.Controls.Add(this.label4);
            this.panelFormReport.Controls.Add(this.panelInfoFormReport);
            this.panelFormReport.Controls.Add(this.label1);
            this.panelFormReport.Location = new System.Drawing.Point(13, 13);
            this.panelFormReport.Name = "panelFormReport";
            this.panelFormReport.Size = new System.Drawing.Size(522, 580);
            this.panelFormReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản Thống Kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfoFormReport
            // 
            this.panelInfoFormReport.Controls.Add(this.button1);
            this.panelInfoFormReport.Controls.Add(this.rbtMonth);
            this.panelInfoFormReport.Controls.Add(this.rbtWeek);
            this.panelInfoFormReport.Controls.Add(this.label5);
            this.panelInfoFormReport.Controls.Add(this.txtTotalRevenu);
            this.panelInfoFormReport.Controls.Add(this.txtTotalBill);
            this.panelInfoFormReport.Controls.Add(this.label3);
            this.panelInfoFormReport.Controls.Add(this.label2);
            this.panelInfoFormReport.Location = new System.Drawing.Point(0, 123);
            this.panelInfoFormReport.Name = "panelInfoFormReport";
            this.panelInfoFormReport.Size = new System.Drawing.Size(519, 454);
            this.panelInfoFormReport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(236, 56);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(208, 22);
            this.txtTotalBill.TabIndex = 2;
            // 
            // txtTotalRevenu
            // 
            this.txtTotalRevenu.Location = new System.Drawing.Point(236, 125);
            this.txtTotalRevenu.Name = "txtTotalRevenu";
            this.txtTotalRevenu.ReadOnly = true;
            this.txtTotalRevenu.Size = new System.Drawing.Size(208, 22);
            this.txtTotalRevenu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "--  00  --";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thống kê theo:";
            // 
            // rbtWeek
            // 
            this.rbtWeek.AutoSize = true;
            this.rbtWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtWeek.Location = new System.Drawing.Point(236, 205);
            this.rbtWeek.Name = "rbtWeek";
            this.rbtWeek.Size = new System.Drawing.Size(67, 24);
            this.rbtWeek.TabIndex = 5;
            this.rbtWeek.TabStop = true;
            this.rbtWeek.Text = "Tuần";
            this.rbtWeek.UseVisualStyleBackColor = true;
            // 
            // rbtMonth
            // 
            this.rbtMonth.AutoSize = true;
            this.rbtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMonth.Location = new System.Drawing.Point(372, 207);
            this.rbtMonth.Name = "rbtMonth";
            this.rbtMonth.Size = new System.Drawing.Size(76, 24);
            this.rbtMonth.TabIndex = 6;
            this.rbtMonth.TabStop = true;
            this.rbtMonth.Text = "Tháng";
            this.rbtMonth.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "In Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 605);
            this.Controls.Add(this.panelFormReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bản Thống Kê";
            this.panelFormReport.ResumeLayout(false);
            this.panelInfoFormReport.ResumeLayout(false);
            this.panelInfoFormReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelInfoFormReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtMonth;
        private System.Windows.Forms.RadioButton rbtWeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalRevenu;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}