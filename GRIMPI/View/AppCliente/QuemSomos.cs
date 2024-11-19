using Sistema.View.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.AppCliente
{
    public partial class QuemSomos : Form
    {
        public QuemSomos()
        {
            InitializeComponent();
        }

        private void btnclose_cadcli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void piclog_who_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

    }
}
