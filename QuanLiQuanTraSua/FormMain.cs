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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = false;
            FormLogin lg = new FormLogin();
            DialogResult result = lg.ShowDialog();
            if(result==DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            FormLogin fg = new FormLogin();
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất ?", "Thông Báo !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                this.ShowDialog();
                fg.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbShopName.Text = LbShopName.Text.Substring(1) + LbShopName.Text.Substring(0, 1);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoAccount fia = new FormInfoAccount();
            fia.ShowDialog();
        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frp = new FormReport();
            frp.ShowDialog();

        }
    }
}
