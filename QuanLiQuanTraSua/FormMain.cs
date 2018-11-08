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
    }
}
