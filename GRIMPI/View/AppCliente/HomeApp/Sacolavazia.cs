using Sistema.View.AppCliente.HomeApp.Produtos;
using Sistema.View.Home;
using Sistema.View.View.Pagamento;
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
    public partial class Sacolavazia : Form
    {
        // Propriedade estática para armazenar a instância do carrinho
        private static Sacolavazia instance;

        public static Sacolavazia Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Sacolavazia();
                }
                return instance;
            }
        }

        private Sacolavazia()
        {
            InitializeComponent();
        }

        private void btnclosesacolavaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_sacolavaz_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void produtos_sacolavaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = produtos_sacolavaz.SelectedItem.ToString();

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

        private void logout_sacolavaz_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void carrinho_sacolavaz_Click(object sender, EventArgs e)
        {
            Sacolavazia sacolavazia = new Sacolavazia();
            sacolavazia.ShowDialog();
            this.Hide();
        }

        private void keepshopsacolavaz_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.ShowDialog();
            this.Hide();
        }

        private void Sacolavazia_Load(object sender, EventArgs e)
        {



        }

        // Método para adicionar itens ao carrinho
        public void AdicionarAoCarrinho(string nome, string quantidade, string valor)
        {
            ListViewItem item = new ListViewItem(nome);
            item.SubItems.Add(quantidade);
            item.SubItems.Add(valor);
            listCarinho.Items.Add(item);
            AtualizarValorCarrinho();
        }

        private void AtualizarValorCarrinho()
        {
            decimal total = 0; // Variável para armazenar o valor total

            // Itera pelos itens do ListView
            foreach (ListViewItem item in listCarinho.Items)
            {
                // Converte o valor da coluna "Valor" para decimal
                if (decimal.TryParse(item.SubItems[2].Text, out decimal valor)) // A coluna "Valor" é a terceira (index 2)
                {
                    total += valor; // Adiciona o valor ao total
                }
            }

            // Exibe o total no campo txtValorCarrinho com o formato "Total R$"
            txtValorCarrinho.Text = $"Total R$ {total:F2}"; // F2 formata o valor para 2 casas decimais

        }



        private void listCarinho_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorCarrinho();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Remove o item selecionado
            if (listCarinho.SelectedItems.Count > 0)
            {
                listCarinho.Items.Remove(listCarinho.SelectedItems[0]);
                AtualizarValorCarrinho(); // Atualiza o valor total após a exclusão
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtValorCarrinho_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Show();
            this.Hide();
        }

        private void conta_sacolavaz_Click(object sender, EventArgs e)
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

        public ListView ListCarinho
        {
            get { return listCarinho; }
        }

    }
}
