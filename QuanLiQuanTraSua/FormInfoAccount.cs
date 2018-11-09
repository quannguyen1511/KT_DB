using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLiQuanTraSua
{
    public partial class FormInfoAccount : Form
    {
        public FormInfoAccount()
        {
            InitializeComponent();
            
        }
        private void FormInfoAccount_Load(object sender, EventArgs e)
        {
            List<Account> list = new AccountBUS().GetAccount();
            dtgvInfoAccount.DataSource = list; 
        }
    }
}
