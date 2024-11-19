using Sistema.View.AppCliente.HomeApp.Produtos.Cebolinha;
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

namespace Sistema.View.AppCliente.HomeApp.Produtos
{
    public partial class CebolinhaForm : Form
    {
        public CebolinhaForm()
        {
            InitializeComponent();
        }

        private void btnclose_cebolinha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_Cebolinha_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void logout_Cebolinha_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void produtos_Cebolinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = produtos_Cebolinha.SelectedItem.ToString();

            if (selectedItem == "Alecrim")
            {
                AlecrimForm alecrim = new AlecrimForm();
                alecrim.ShowDialog();
                this.Hide();
            }
            else if (selectedItem == "Cebolinha")
            {
                CebolinhaForm cebolinha = new CebolinhaForm();
                cebolinha.ShowDialog();
                this.Hide();
            }
            else if (selectedItem == "Coentro")
            {
                CoentroForm coentro = new CoentroForm();
                coentro.ShowDialog();
                this.Hide();
            }
            else if (selectedItem == "Hortelã")
            {
                HortelaForm hortela = new HortelaForm();
                hortela.ShowDialog();
                this.Hide();
            }
            else if (selectedItem == "Lavanda")
            {
                LavandaForm lavandaForm = new LavandaForm();
                lavandaForm.ShowDialog();
                this.Hide();
            }
            else if (selectedItem == "Orégano")
            {
                OreganoForm oréganoform = new OreganoForm();
                oréganoform.ShowDialog();
                this.Hide();
            }
        }

        private void buy_cebolinha150_Click(object sender, EventArgs e)
        {
            Descricao_Cebolinha_150 descricao_Cebolinha_150 = new Descricao_Cebolinha_150();
            descricao_Cebolinha_150.ShowDialog();
            this.Hide();
        }

        private void buy_cebolinha300_Click(object sender, EventArgs e)
        {
            Descricao_Cebolinha_300 descricao_Cebolinha_300 = new Descricao_Cebolinha_300();
            descricao_Cebolinha_300.ShowDialog();
            this.Hide();
        }

        private void buy_cebolinha600_Click(object sender, EventArgs e)
        {
            Descricao_Cebolinha_600 descricao_Cebolinha_600 = new Descricao_Cebolinha_600();
            descricao_Cebolinha_600.ShowDialog();
            this.Hide();
        }

        private void conta_Cebolinha_Click(object sender, EventArgs e)
        {
            var resultadoCPF = MessageBox.Show(
    "Deseja acessar os dados da sua conta física?",
    "Escolha de Conta",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (resultadoCPF == DialogResult.Yes)
            {
                // Redireciona para a tela de conta física
                MinhaContaCliente minhaContaCliente = new MinhaContaCliente();
                minhaContaCliente.Show();
                this.Hide();
            }
            else
            {
                var resultadoCNPJ = MessageBox.Show(
                "Deseja acessar os dados da sua conta juridica?",
                "Escolha de Conta",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

                if (resultadoCNPJ == DialogResult.Yes)
                {
                    MinhaContaJuridico minhaContaJuridico = new MinhaContaJuridico();
                    minhaContaJuridico.Show();
                    this.Hide();
                }

            }
        }

        private void carrinho_Cebolinha_Click(object sender, EventArgs e)
        {
            Sacolavazia.Instance.Show();
            Sacolavazia.Instance.BringToFront();// Traz o formulário para frente
            this.Hide();
        }
    }
}
