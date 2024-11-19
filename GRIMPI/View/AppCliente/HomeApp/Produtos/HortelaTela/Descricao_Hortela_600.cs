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

namespace Sistema.View.AppCliente.HomeApp.Produtos.HortelãTela
{
    public partial class Descricao_Hortela_600 : Form
    {
        public Descricao_Hortela_600()
        {
            InitializeComponent();
        }

        private void btnclose_descHortela600_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_descHortela600_Click(object sender, EventArgs e)
        {
            WhoHome whoHome = new WhoHome();
            whoHome.ShowDialog();
            this.Hide();
        }

        private void logout_descHortela600_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void produtos_descHortela600_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = produtos_descHortela600.SelectedItem.ToString();

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

        // Campo para armazenar a referência ao formulário do carrinho
        private Sacolavazia formCarrinho;

        public Descricao_Hortela_600(Sacolavazia carrinho)
        {
            InitializeComponent();
            formCarrinho = carrinho; // Referência ao formulário do carrinho
        }

        private void buy_descHortela600_Click(object sender, EventArgs e)
        {
            string nome = "Hortelã";
            string quantidade = "600g";
            string valor = "28,00";

            // Adiciona o item ao carrinho usando a instância estática
            Sacolavazia.Instance.AdicionarAoCarrinho(nome, quantidade, valor);

            MessageBox.Show("Item adicionado ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void carrinho_descHortela600_Click(object sender, EventArgs e)
        {
            Sacolavazia.Instance.Show();
            Sacolavazia.Instance.BringToFront();// Traz o formulário para frente
            this.Hide();
        }

        private void Descricao_Hortela_600_Load(object sender, EventArgs e)
        {

        }

        private void conta_descHortela600_Click(object sender, EventArgs e)
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
    }
}
