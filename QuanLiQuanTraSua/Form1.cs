using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logOutMenustrip_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            FormLogin fg = new FormLogin();
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất ?", "Thông Báo !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                this.ShowDialog();
                fg.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = false;
            FormLogin lg = new FormLogin();
            DialogResult result = lg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void infoAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoAccount fia = new FormInfoAccount();
            fia.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frp = new FormReport();
            frp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // lbShopName.Text = lbShopName.Text.Substring(1) + lbShopName.Text.Substring(0, 1);
            lbShopName.Text = lbShopName.Text.Substring(1) + lbShopName.Text.Substring(0, 1);
        }
    }
}
