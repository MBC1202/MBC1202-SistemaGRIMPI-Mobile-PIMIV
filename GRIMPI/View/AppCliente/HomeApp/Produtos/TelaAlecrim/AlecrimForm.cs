using Sistema.View.AppCliente.HomeApp.Produtos.Alecrim;
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
    public partial class AlecrimForm : Form
    {
        public AlecrimForm()
        {
            InitializeComponent();
        }

        private void btnclosehome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_home_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void logout_Alecrim_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void produtos_Alecrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = produtos_Alecrim.SelectedItem.ToString();

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

        private void buy_alecrim150_Click(object sender, EventArgs e)
        {
            Descricao_Alecrim_150 descricao_Alecrim_150 = new Descricao_Alecrim_150();
            descricao_Alecrim_150.ShowDialog();
            this.Hide();

        }

        private void buy_alecrim300_Click(object sender, EventArgs e)
        {
            Descricao_Alecrim_300 descricao_Alecrim_300 = new Descricao_Alecrim_300();
            descricao_Alecrim_300.ShowDialog();
            this.Hide();
        }

        private void buy_alecrim600_Click(object sender, EventArgs e)
        {
            Descricao_Alecrim_600 descricao_Alecrim_600 = new Descricao_Alecrim_600();
            descricao_Alecrim_600.ShowDialog();
            this.Hide();
        }

        private void conta_Alecrim_Click(object sender, EventArgs e)
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

        private void carrinho_Alecrim_Click(object sender, EventArgs e)
        {
            Sacolavazia.Instance.Show();
            Sacolavazia.Instance.BringToFront();// Traz o formulário para frente
            this.Hide();
        }
    }
}
