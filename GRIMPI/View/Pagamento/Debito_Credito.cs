using Sistema.View.AppCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema.View.AppCliente.HomeApp;

namespace Sistema.View.View.Pagamento
{
    public partial class Debito_Credito : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        public Debito_Credito()
        {
            InitializeComponent();
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textCVV.Text == "" || textNumero.Text == "" || TextData.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textCVV.Text.Length != 3)
            {
                MessageBox.Show("Preencha o campo CVV corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textNumero.Text.Length != 19)
            {
                MessageBox.Show("Preencha o campo número do cartão corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextData.Text.Length != 5)
            {
                MessageBox.Show("Preencha o campo data de validade corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Salvar os itens do carrinho no banco de dados
                try
                {
                    SalvarItensCarrinhoNoBanco();
                    MessageBox.Show("Compra realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar itens no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Deseja continuar no aplicativo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    App app = new App();
                    app.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }


        public void SalvarItensCarrinhoNoBanco()
        {
            // Usando a variável de conexão existente
            using (SqlConnection connection = new SqlConnection(cn.ConnectionString))
            {
                connection.Open();
                foreach (ListViewItem item in Sacolavazia.Instance.ListCarinho.Items)
                {
                    string nome = item.SubItems[0].Text;
                    string quantidade = item.SubItems[1].Text;
                    string valor = item.SubItems[2].Text;

                    string query = "INSERT INTO Vendas (Produto, Quantidade, Valor) VALUES (@Nome, @Quantidade, @Valor)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@Valor", valor);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Mostra a MessageBox com os botões Sim e Não
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a compra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verifica o resultado da MessageBox
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("COMPRA CANCELADA", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                App app = new App();
                app.Show();
                this.Hide();
            }
        }

        private void btnclose_coentro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
