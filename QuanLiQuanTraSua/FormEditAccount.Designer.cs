namespace QuanLiQuanTraSua
{
    partial class FormEditAccount
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
            this.panelFormEditAccount = new System.Windows.Forms.Panel();
            this.btCloseEditAccount = new System.Windows.Forms.Button();
            this.btUpDateEditAccount = new System.Windows.Forms.Button();
            this.txtEditDisplayName = new System.Windows.Forms.TextBox();
            this.txtEditPassWord = new System.Windows.Forms.TextBox();
            this.txtEditAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormEditAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormEditAccount
            // 
            this.panelFormEditAccount.BackgroundImage = global::QuanLiQuanTraSua.Properties.Resources.KìLân;
            this.panelFormEditAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFormEditAccount.Controls.Add(this.btCloseEditAccount);
            this.panelFormEditAccount.Controls.Add(this.btUpDateEditAccount);
            this.panelFormEditAccount.Controls.Add(this.txtEditDisplayName);
            this.panelFormEditAccount.Controls.Add(this.txtEditPassWord);
            this.panelFormEditAccount.Controls.Add(this.txtEditAccount);
            this.panelFormEditAccount.Controls.Add(this.label3);
            this.panelFormEditAccount.Controls.Add(this.label2);
            this.panelFormEditAccount.Controls.Add(this.label1);
            this.panelFormEditAccount.Location = new System.Drawing.Point(12, 12);
            this.panelFormEditAccount.Name = "panelFormEditAccount";
            this.panelFormEditAccount.Size = new System.Drawing.Size(703, 395);
            this.panelFormEditAccount.TabIndex = 0;
            // 
            // btCloseEditAccount
            // 
            this.btCloseEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseEditAccount.Location = new System.Drawing.Point(472, 271);
            this.btCloseEditAccount.Name = "btCloseEditAccount";
            this.btCloseEditAccount.Size = new System.Drawing.Size(99, 37);
            this.btCloseEditAccount.TabIndex = 15;
            this.btCloseEditAccount.Text = "Thoát";
            this.btCloseEditAccount.UseVisualStyleBackColor = true;
            // 
            // btUpDateEditAccount
            // 
            this.btUpDateEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpDateEditAccount.Location = new System.Drawing.Point(363, 270);
            this.btUpDateEditAccount.Name = "btUpDateEditAccount";
            this.btUpDateEditAccount.Size = new System.Drawing.Size(99, 38);
            this.btUpDateEditAccount.TabIndex = 14;
            this.btUpDateEditAccount.Text = "Cập nhật";
            this.btUpDateEditAccount.UseVisualStyleBackColor = true;
            // 
            // txtEditDisplayName
            // 
            this.txtEditDisplayName.Location = new System.Drawing.Point(287, 202);
            this.txtEditDisplayName.Name = "txtEditDisplayName";
            this.txtEditDisplayName.Size = new System.Drawing.Size(284, 22);
            this.txtEditDisplayName.TabIndex = 13;
            // 
            // txtEditPassWord
            // 
            this.txtEditPassWord.Location = new System.Drawing.Point(287, 145);
            this.txtEditPassWord.Name = "txtEditPassWord";
            this.txtEditPassWord.Size = new System.Drawing.Size(284, 22);
            this.txtEditPassWord.TabIndex = 12;
            // 
            // txtEditAccount
            // 
            this.txtEditAccount.Location = new System.Drawing.Point(287, 87);
            this.txtEditAccount.Name = "txtEditAccount";
            this.txtEditAccount.Size = new System.Drawing.Size(284, 22);
            this.txtEditAccount.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài khoản:";
            // 
            // FormEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(727, 419);
            this.Controls.Add(this.panelFormEditAccount);
            this.Name = "FormEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh Sửa Tài Khoản";
            this.panelFormEditAccount.ResumeLayout(false);
            this.panelFormEditAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormEditAccount;
        private System.Windows.Forms.Button btCloseEditAccount;
        private System.Windows.Forms.Button btUpDateEditAccount;
        private System.Windows.Forms.TextBox txtEditDisplayName;
        private System.Windows.Forms.TextBox txtEditPassWord;
        private System.Windows.Forms.TextBox txtEditAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}