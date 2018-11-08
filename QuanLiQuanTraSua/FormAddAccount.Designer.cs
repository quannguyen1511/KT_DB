namespace QuanLiQuanTraSua
{
    partial class FormAddAccount
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
            this.panelFormAddAccount = new System.Windows.Forms.Panel();
            this.btCloseAddAccount = new System.Windows.Forms.Button();
            this.btUpDateAddAccount = new System.Windows.Forms.Button();
            this.txtAddDisplayName = new System.Windows.Forms.TextBox();
            this.txtAddPassWord = new System.Windows.Forms.TextBox();
            this.txtAddAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormAddAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormAddAccount
            // 
            this.panelFormAddAccount.BackgroundImage = global::QuanLiQuanTraSua.Properties.Resources.KìLân;
            this.panelFormAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFormAddAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormAddAccount.Controls.Add(this.btCloseAddAccount);
            this.panelFormAddAccount.Controls.Add(this.btUpDateAddAccount);
            this.panelFormAddAccount.Controls.Add(this.txtAddDisplayName);
            this.panelFormAddAccount.Controls.Add(this.txtAddPassWord);
            this.panelFormAddAccount.Controls.Add(this.txtAddAccount);
            this.panelFormAddAccount.Controls.Add(this.label3);
            this.panelFormAddAccount.Controls.Add(this.label2);
            this.panelFormAddAccount.Controls.Add(this.label1);
            this.panelFormAddAccount.Location = new System.Drawing.Point(13, 13);
            this.panelFormAddAccount.Name = "panelFormAddAccount";
            this.panelFormAddAccount.Size = new System.Drawing.Size(702, 374);
            this.panelFormAddAccount.TabIndex = 0;
            
            // 
            // btCloseAddAccount
            // 
            this.btCloseAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseAddAccount.Location = new System.Drawing.Point(483, 265);
            this.btCloseAddAccount.Name = "btCloseAddAccount";
            this.btCloseAddAccount.Size = new System.Drawing.Size(99, 37);
            this.btCloseAddAccount.TabIndex = 7;
            this.btCloseAddAccount.Text = "Thoát";
            this.btCloseAddAccount.UseVisualStyleBackColor = true;
            // 
            // btUpDateAddAccount
            // 
            this.btUpDateAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpDateAddAccount.Location = new System.Drawing.Point(374, 264);
            this.btUpDateAddAccount.Name = "btUpDateAddAccount";
            this.btUpDateAddAccount.Size = new System.Drawing.Size(99, 38);
            this.btUpDateAddAccount.TabIndex = 6;
            this.btUpDateAddAccount.Text = "Cập nhật";
            this.btUpDateAddAccount.UseVisualStyleBackColor = true;
            // 
            // txtAddDisplayName
            // 
            this.txtAddDisplayName.Location = new System.Drawing.Point(298, 196);
            this.txtAddDisplayName.Name = "txtAddDisplayName";
            this.txtAddDisplayName.Size = new System.Drawing.Size(284, 22);
            this.txtAddDisplayName.TabIndex = 5;
            // 
            // txtAddPassWord
            // 
            this.txtAddPassWord.Location = new System.Drawing.Point(298, 139);
            this.txtAddPassWord.Name = "txtAddPassWord";
            this.txtAddPassWord.Size = new System.Drawing.Size(284, 22);
            this.txtAddPassWord.TabIndex = 4;
            // 
            // txtAddAccount
            // 
            this.txtAddAccount.Location = new System.Drawing.Point(298, 81);
            this.txtAddAccount.Name = "txtAddAccount";
            this.txtAddAccount.Size = new System.Drawing.Size(284, 22);
            this.txtAddAccount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(727, 399);
            this.Controls.Add(this.panelFormAddAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Tài Khoản";
            this.panelFormAddAccount.ResumeLayout(false);
            this.panelFormAddAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormAddAccount;
        private System.Windows.Forms.Button btCloseAddAccount;
        private System.Windows.Forms.Button btUpDateAddAccount;
        private System.Windows.Forms.TextBox txtAddDisplayName;
        private System.Windows.Forms.TextBox txtAddPassWord;
        private System.Windows.Forms.TextBox txtAddAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}