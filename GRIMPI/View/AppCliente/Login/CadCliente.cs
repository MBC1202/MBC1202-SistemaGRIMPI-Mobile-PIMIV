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
using System.Data.SqlClient;

namespace Sistema.View.AppCliente
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        // Estabelecendo conexão com Banco de Dados SQL Server
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnclose_cadcli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_cadcli_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void fim_cadcli_Click(object sender, EventArgs e)
        {
            // Validações para campos obrigatórios
            if (string.IsNullOrEmpty(txtname_cadcli.Text) ||
        string.IsNullOrEmpty(txtemail_cadcli.Text) ||
        string.IsNullOrEmpty(maskedcpf_cadcli.Text) ||
        string.IsNullOrEmpty(Criarpass_cadcli.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtenção dos dados do formulário com validações e normalizações
                string nome = txtname_cadcli.Text.Trim();
                string email = txtemail_cadcli.Text.Trim();

                // Retirar pontos e traços do CPF
                string cpf = maskedcpf_cadcli.Text.Trim().Replace(",", "").Replace("-", "");
                if (cpf.Length != 11 || !long.TryParse(cpf, out _)) // Validação de CPF (11 dígitos numéricos)
                {
                    MessageBox.Show("CPF inválido! Insira um CPF válido no formato XXX,XXX,XXX-XX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string telefone = masktel_cadcli.Text.Trim();
                string senha = Criarpass_cadcli.Text.Trim();

                string cep = maskcep_cadcli.Text.Trim().Replace("-", ""); // Remove o hífen do CEP
                if (cep.Length != 8 || !long.TryParse(cep, out _)) // Validação do CEP (8 dígitos numéricos)
                {
                    MessageBox.Show("CEP inválido! Insira um CEP válido no formato XXXXX-XXX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string estado = cmbestado_cadcli.Text.Trim();
                if (string.IsNullOrEmpty(estado) || estado.Length > 50) // Validação do estado
                {
                    MessageBox.Show("O campo 'Estado' deve ser preenchido e conter no máximo 50 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cidade = txtcidad_cadcli.Text.Trim();
                string bairro = txtbairr_cadcli.Text.Trim();
                string logradouro = txtlogr_cadcli.Text.Trim();
                string numero = txtnum_cadcli.Text.Trim();
                string tipoLogradouro = cmblogra_cadcli.Text.Trim();
                string complemento = txtcomp_cadcli.Text.Trim();

                // Abrindo a conexão com o banco de dados
                cn.Open();

                // Inserindo dados na tabela Cad_Clientes
                string sqlCliente = @"INSERT INTO Cad_Clientes 
                              (NomeCompleto, Email, CPF, Telefone, Senha) 
                              OUTPUT INSERTED.Id
                              VALUES 
                              (@nome, @email, @cpf, @telefone, @senha)";
                cm = new SqlCommand(sqlCliente, cn);
                cm.Parameters.AddWithValue("@nome", nome);
                cm.Parameters.AddWithValue("@email", email);
                cm.Parameters.AddWithValue("@cpf", cpf);
                cm.Parameters.AddWithValue("@telefone", telefone);
                cm.Parameters.AddWithValue("@senha", senha);

                int clienteId = (int)cm.ExecuteScalar(); // Retorna o ID do cliente inserido

                // Inserindo dados na tabela CadCli_Enderecos
                string sqlEndereco = @"INSERT INTO CadCli_Enderecos 
                               (ClienteId, CEP, Estado, Cidade, Bairro, Logradouro, Numero, TipoLogradouro, Complemento) 
                               VALUES 
                               (@clienteId, @cep, @estado, @cidade, @bairro, @logradouro, @numero, @tipoLogradouro, @complemento)";
                cm = new SqlCommand(sqlEndereco, cn);
                cm.Parameters.AddWithValue("@clienteId", clienteId);
                cm.Parameters.AddWithValue("@cep", cep);
                cm.Parameters.AddWithValue("@estado", estado);
                cm.Parameters.AddWithValue("@cidade", cidade);
                cm.Parameters.AddWithValue("@bairro", bairro);
                cm.Parameters.AddWithValue("@logradouro", logradouro);
                cm.Parameters.AddWithValue("@numero", numero);
                cm.Parameters.AddWithValue("@tipoLogradouro", tipoLogradouro);
                cm.Parameters.AddWithValue("@complemento", complemento);

                cm.ExecuteNonQuery(); // Executa o comando de inserção do endereço

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login login = new login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar o cadastro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Garantindo o fechamento da conexão
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }




        private void Quemsomoslog_Click(object sender, EventArgs e)
        {
            QuemSomos quemSomos = new QuemSomos();
            quemSomos.ShowDialog();
            this.Hide();
        }
    }
}
