using Sistema.View.AppCliente.HomeApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.View.Pagamento
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtOpcaoPag.SelectedIndex >= 0)
            {
                String FormaDePagamentoEscolhida = txtOpcaoPag.SelectedItem.ToString();

                switch (FormaDePagamentoEscolhida)
                {
                    case "Débito":
                        Debito_Credito debito_Credito = new Debito_Credito();
                        debito_Credito.Show();
                        this.Hide();
                        break;
                    case "Credito":
                        Debito_Credito debito_Credito1 = new Debito_Credito();
                        debito_Credito1.Show();
                        this.Hide();
                        break;
                    case "PIX":
                        pix pix = new pix();
                        pix.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Opção de pagamento inválida.");
                        break;
                }
            }
        }

        private void btnclose_coentro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtVoltar_Click(object sender, EventArgs e)
        {
            Sacolavazia.Instance.Show();
            Sacolavazia.Instance.BringToFront();// Traz o formulário para frente
            this.Hide();
        }
    }
}
