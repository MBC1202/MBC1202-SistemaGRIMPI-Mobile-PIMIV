using Sistema.View.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema.View.AppCliente
{
    public partial class CadEmpresa : Form
    {
        public CadEmpresa()
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

        private void Quemsomoslog_Click(object sender, EventArgs e)
        {
            QuemSomos quemSomos = new QuemSomos();
            quemSomos.ShowDialog();
            this.Hide();
        }

        private void fim_cademp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtrazso_cademp.Text) ||
        string.IsNullOrEmpty(txtemail_cademp.Text) ||
        string.IsNullOrEmpty(mascnpj_cademp.Text) ||
        string.IsNullOrEmpty(Criarpass_cademp.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtenção dos dados do formulário com validações e normalizações
                string nomeFantasia = txtrazso_cademp.Text.Trim();
                string email = txtemail_cademp.Text.Trim();

                // Retirar pontos, barras e traços do CNPJ
                string cnpj = mascnpj_cademp.Text.Trim().Replace(",", "").Replace("/", "").Replace("-", "");
                if (cnpj.Length != 14 || !long.TryParse(cnpj, out _)) // Validação de CNPJ (14 dígitos numéricos)
                {
                    MessageBox.Show("CNPJ inválido! Insira um CNPJ válido no formato XX,XXX,XXX/XXXX-XX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string telefoneComercial = masktelcomer_cademp.Text.Trim();
                string senha = Criarpass_cademp.Text.Trim();

                string cep = maskcep_cademp.Text.Trim().Replace("-", ""); // Remove o hífen do CEP
                if (cep.Length != 8 || !long.TryParse(cep, out _)) // Validação do CEP (8 dígitos numéricos)
                {
                    MessageBox.Show("CEP inválido! Insira um CEP válido no formato XXXXX-XXX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string estado = cmbestado_cademp.Text.Trim();
                if (string.IsNullOrEmpty(estado) || estado.Length > 50) // Validação do estado
                {
                    MessageBox.Show("O campo 'Estado' deve ser preenchido e conter no máximo 50 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cidade = txtcidad_cademp.Text.Trim();
                string bairro = txtbairr_cademp.Text.Trim();
                string logradouro = txtlogr_cademp.Text.Trim();
                string numero = txtnum_cademp.Text.Trim();
                string tipoLogradouro = cmblogra_cademp.Text.Trim();
                string complemento = txtcomp_cademp.Text.Trim();

                // Abrindo a conexão com o banco de dados
                cn.Open();

                // Inserindo dados na tabela Cad_Juridico
                string sqlJuridico = @"INSERT INTO Cad_Juridico 
                               (NomeFantasia, EmailJuri, CNPJ, TelefoneComercial, SenhaJuri) 
                               OUTPUT INSERTED.Id
                               VALUES 
                               (@nomeFantasia, @email, @cnpj, @telefoneComercial, @senha)";
                cm = new SqlCommand(sqlJuridico, cn);
                cm.Parameters.AddWithValue("@nomeFantasia", nomeFantasia);
                cm.Parameters.AddWithValue("@email", email);
                cm.Parameters.AddWithValue("@cnpj", cnpj);
                cm.Parameters.AddWithValue("@telefoneComercial", telefoneComercial);
                cm.Parameters.AddWithValue("@senha", senha);

                int juridicoId = (int)cm.ExecuteScalar(); // Retorna o ID do cliente jurídico inserido

                // Inserindo dados na tabela CadJuri_Enderecos
                string sqlEndereco = @"INSERT INTO CadJuri_Enderecos 
                               (JuridicoId, CEPJuri, EstadoJuri, CidadeJuri, BairroJuri, LogradouroJuri, NumeroJuri, TipoLogradouroJuri, ComplementoJuri) 
                               VALUES 
                               (@juridicoId, @cep, @estado, @cidade, @bairro, @logradouro, @numero, @tipoLogradouro, @complemento)";
                cm = new SqlCommand(sqlEndereco, cn);
                cm.Parameters.AddWithValue("@juridicoId", juridicoId);
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

    }
}








