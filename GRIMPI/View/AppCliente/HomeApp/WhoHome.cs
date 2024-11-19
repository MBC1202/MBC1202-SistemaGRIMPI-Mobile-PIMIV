using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.AppCliente.HomeApp
{
    public partial class WhoHome : Form
    {
        public WhoHome()
        {
            InitializeComponent();
        }

        private void btnclose_cadcli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backhome_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.ShowDialog();
            this.Hide();
        }
    }
}
