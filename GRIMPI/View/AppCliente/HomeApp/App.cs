using Sistema.View.AppCliente.HomeApp;
using Sistema.View.AppCliente.HomeApp.Produtos;
using Sistema.View.Home;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.View.AppCliente
{
    public partial class App : Form
    {
        private List<string> imagens; // Lista de caminhos das imagens do carrossel
        private int indiceImagemAtual; // Índice da imagem atual no carrossel
        private Sacolavazia formCarrinho; // Referência ao formulário do carrinho

        public App()
        {
            InitializeComponent();
            InicializarCarrossel();
           
        }

        private void InicializarCarrossel()
        {
            // Adicionando os caminhos das imagens
            imagens = new List<string>
            {
                @"C:\Users\maria\Documents\CARROSSEL DE IMAGENS\grimpiverde.png",
                @"C:\Users\maria\Documents\CARROSSEL DE IMAGENS\lavandagrimpi.png",
                @"C:\Users\maria\Documents\CARROSSEL DE IMAGENS\ervagrimpi.png",
            };

            indiceImagemAtual = 0;

            // Configurar o Timer para trocar a imagem a cada 3 segundos
            timeCarrossel.Interval = 3000; // Intervalo de 3 segundos
            timeCarrossel.Tick += timeCarrossel_Tick; // Evento de troca de imagem
            timeCarrossel.Start();
        }

        private void timeCarrossel_Tick(object sender, EventArgs e)
        {
            // Atualizar o índice da imagem
            indiceImagemAtual++;
            if (indiceImagemAtual >= imagens.Count)
            {
                indiceImagemAtual = 0; // Recomeça do início
            }

            // Atualizar o PictureBox com a nova imagem
            picbCarrossel.ImageLocation = imagens[indiceImagemAtual];
        }

        private void btnclosehome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_home_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void Quemsomos_home_Click(object sender, EventArgs e)
        {
            WhoHome whoHome = new WhoHome();
            whoHome.ShowDialog();
            this.Hide();
        }

        private void produtos_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = produtos_home.SelectedItem?.ToString();

            if (selectedItem == "Alecrim")
            {
                AlecrimForm alecrim = new AlecrimForm();
                alecrim.ShowDialog();
            }
            else if (selectedItem == "Cebolinha")
            {
                CebolinhaForm cebolinha = new CebolinhaForm();
                cebolinha.ShowDialog();
            }
            else if (selectedItem == "Coentro")
            {
                CoentroForm coentro = new CoentroForm();
                coentro.ShowDialog();
            }
            else if (selectedItem == "Hortelã")
            {
                HortelaForm hortela = new HortelaForm();
                hortela.ShowDialog();
            }
            else if (selectedItem == "Lavanda")
            {
                LavandaForm lavandaForm = new LavandaForm();
                lavandaForm.ShowDialog();
            }
            else if (selectedItem == "Orégano")
            {
                OreganoForm oréganoform = new OreganoForm();
                oréganoform.ShowDialog();
            }
        }

        private void conta_home_Click(object sender, EventArgs e)
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

        private void carrinho_home_Click(object sender, EventArgs e)
        {
            // Mostra o carrinho usando a instância estática
            Sacolavazia.Instance.Show();
            Sacolavazia.Instance.BringToFront();// Traz o formulário para frente
            this.Hide();
        }

        private void App_Load(object sender, EventArgs e)
        {
        }
    }
}
