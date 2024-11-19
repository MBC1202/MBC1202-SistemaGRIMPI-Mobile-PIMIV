using Sistema.View.Gerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema.View.View.Gerencia
{
    public partial class TelaGerencia : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        public TelaGerencia()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btnenterlog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Insira os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Abrir a conexão
                    cn.Open();

                    // Configurar o comando SQL
                    cm.Connection = cn;
                    cm.CommandText = "INSERT INTO Adm (UsuarioAdm, SenhaAdm) VALUES (@Usuario, @Senha)";

                    // Adicionar parâmetros para evitar SQL Injection
                    cm.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cm.Parameters.AddWithValue("@Senha", txtSenha.Text);

                    // Executar o comando
                    cm.ExecuteNonQuery();

                    // Mensagem de sucesso
                    MessageBox.Show("Informações inseridas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após a inserção
                    txtUsuario.Clear();
                    txtSenha.Clear();

                    TelaGerencia telaGerencia = new TelaGerencia();
                    telaGerencia.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir os dados no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Garantir que a conexão será fechada e os parâmetros limpos
                    cm.Parameters.Clear();
                    cn.Close();
                }
            }
        }

        private void btncloselogerent_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaGerencia_Load(object sender, EventArgs e)
        {

        }

        private void back_logerent_Click(object sender, EventArgs e)
        {
            GerenteLog gerenteLog = new GerenteLog();
            gerenteLog.Show();
            this.Hide();
        }

        private void CarregarDados()
        {
            try
            {
                // Limpar os itens existentes na ListView
                listAutorizadas.Items.Clear();

                // Abrir a conexão
                cn.Open();

                // Configurar o comando SQL para selecionar dados
                cm.Connection = cn;
                cm.CommandText = "SELECT UsuarioAdm, SenhaAdm FROM Adm";

                // Executar o comando e obter os dados
                SqlDataReader reader = cm.ExecuteReader();

                // Loop para percorrer os dados retornados
                while (reader.Read())
                {
                    // Criar um novo item para a ListView
                    ListViewItem item = new ListViewItem(reader["UsuarioAdm"].ToString());

                    // Adicionar a senha como subitem
                    item.SubItems.Add(reader["SenhaAdm"].ToString());

                    // Adicionar o item à ListView
                    listAutorizadas.Items.Add(item);
                }

                // Fechar o leitor de dados
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fechar a conexão
                cn.Close();
            }
        }

        private void listAutorizadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verificar se há um item selecionado na ListView
            if (listAutorizadas.SelectedItems.Count > 0)
            {
                try
                {
                    // Pegar o nome do usuário selecionado
                    string usuarioSelecionado = listAutorizadas.SelectedItems[0].Text;

                    // Confirmar a exclusão
                    DialogResult confirmacao = MessageBox.Show(
                        $"Tem certeza que deseja excluir o usuário '{usuarioSelecionado}'?",
                        "Confirmação de Exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacao == DialogResult.Yes)
                    {
                        // Abrir a conexão com o banco
                        cn.Open();

                        // Configurar o comando SQL para deletar o usuário
                        cm.Connection = cn;
                        cm.CommandText = "DELETE FROM Adm WHERE UsuarioAdm = @Usuario";
                        cm.Parameters.AddWithValue("@Usuario", usuarioSelecionado);

                        // Executar o comando
                        cm.ExecuteNonQuery();

                        // Remover o item da ListView
                        listAutorizadas.Items.Remove(listAutorizadas.SelectedItems[0]);

                        // Exibir mensagem de sucesso
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Limpar os parâmetros e fechar a conexão
                    cm.Parameters.Clear();
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSair_Click(object sender, EventArgs e)
        {
            GerenteLog gerenteLog = new GerenteLog();
            gerenteLog.Show();
            this.Hide();
        }

        private void txtDados_Click(object sender, EventArgs e)
        {
            TelaDeDados telaDeDados = new TelaDeDados();
            telaDeDados.Show();
            this.Hide();
        }
    }
}
