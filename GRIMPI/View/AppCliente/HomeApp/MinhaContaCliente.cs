using Sistema.View.AppCliente.HomeApp.Produtos;
using Sistema.View.Home;
using Sistema.View.Gerencia;
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

namespace Sistema.View.AppCliente.HomeApp
{
    public partial class MinhaContaCliente : Form
    {


        private readonly SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public MinhaContaCliente()
        {
            InitializeComponent();

        }

        private void btncloseaccontcli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_accontcli_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void logout_accontcli_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void MinhaContaCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtEditar_Click(object sender, EventArgs e)
        {
            txtname_accontcli.Enabled = true;
            txtcep.Enabled = true;
            masktel_accontcli.Enabled = true;
            txtemail_accontcli.Enabled = true;
            cmbestado_accontcli.Enabled = true;
            cmblogra_accontcli.Enabled = true;
            txtnum_accontcli.Enabled = true;
            txtcomp_accontcli.Enabled = true;
            txtbairr_accontcli.Enabled = true;
            txtlogr_accontcli.Enabled = true;
            txtcidad_accontcli.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo do CPF está preenchido
            if (string.IsNullOrWhiteSpace(textVerificaCPF.Text))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query para buscar os dados do cliente
            string clienteQuery = "SELECT Id, NomeCompleto, Email, CPF, Telefone FROM Cad_Clientes WHERE CPF = @CPF";
            string enderecoQuery = "SELECT CEP, Estado, TipoLogradouro, Numero, Complemento, Bairro, Logradouro, Cidade FROM CadCli_Enderecos WHERE ClienteId = @ClienteId";

            try
            {
                cn.Open();
                cm.Connection = cn;

                // Primeiro: Busca os dados do cliente
                cm.CommandText = clienteQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@CPF", textVerificaCPF.Text.Trim());
                dr = cm.ExecuteReader();

                int idCliente = -1;

                if (dr.Read())
                {
                    // Preenche os campos do cliente
                    idCliente = Convert.ToInt32(dr["Id"]);
                    txtname_accontcli.Text = dr["NomeCompleto"].ToString();
                    txtemail_accontcli.Text = dr["Email"].ToString();
                    maskedcpf_accontcli.Text = dr["CPF"].ToString();
                    masktel_accontcli.Text = dr["Telefone"].ToString();
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dr.Close();

                // Segundo: Busca os dados do endereço com base no ID do cliente
                cm.CommandText = enderecoQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ClienteId", idCliente); // Usando ClienteId
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    // Preenche os campos de endereço
                    txtcep.Text = dr["CEP"].ToString();
                    cmbestado_accontcli.Text = dr["Estado"].ToString();
                    cmblogra_accontcli.Text = dr["TipoLogradouro"].ToString();
                    txtnum_accontcli.Text = dr["Numero"].ToString();
                    txtcomp_accontcli.Text = dr["Complemento"].ToString();
                    txtbairr_accontcli.Text = dr["Bairro"].ToString();
                    txtlogr_accontcli.Text = dr["Logradouro"].ToString();
                    txtcidad_accontcli.Text = dr["Cidade"].ToString();

                    txtname_accontcli.Enabled = false;
                    txtcep.Enabled = false;
                    masktel_accontcli.Enabled = false;
                    txtemail_accontcli.Enabled = false;
                    cmbestado_accontcli.Enabled = false;
                    cmblogra_accontcli.Enabled = false;
                    txtnum_accontcli.Enabled = false;
                    txtcomp_accontcli.Enabled = false;
                    txtbairr_accontcli.Enabled = false;
                    txtlogr_accontcli.Enabled = false;
                    txtcidad_accontcli.Enabled = false;

                    panelVerifica.Visible = false;
                }
                else
                {
                    MessageBox.Show("Endereço não encontrado para o cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Trata erros de execução
                MessageBox.Show($"Ocorreu um erro ao buscar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr?.Close();
                cn.Close();
            }
        }


        private void txtSalvarAlteracoes_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname_accontcli.Text) ||
                string.IsNullOrWhiteSpace(txtemail_accontcli.Text) ||
                string.IsNullOrWhiteSpace(maskedcpf_accontcli.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateClienteQuery = @"
        UPDATE Cad_Clientes 
        SET NomeCompleto = @NomeCompleto, 
            Email = @Email, 
            Telefone = @Telefone
        WHERE CPF = @CPF";

            string updateEnderecoQuery = @"
        UPDATE CadCli_Enderecos 
        SET CEP = @CEP, 
            Estado = @Estado, 
            TipoLogradouro = @TipoLogradouro, 
            Numero = @Numero, 
            Complemento = @Complemento, 
            Bairro = @Bairro, 
            Logradouro = @Logradouro, 
            Cidade = @Cidade
        WHERE ClienteId = (SELECT Id FROM Cad_Clientes WHERE CPF = @CPF)";

            try
            {
                cn.Open();
                cm.Connection = cn;

                // Atualiza os dados do cliente
                cm.CommandText = updateClienteQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@NomeCompleto", txtname_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Email", txtemail_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Telefone", masktel_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@CPF", maskedcpf_accontcli.Text.Trim());

                int clienteRows = cm.ExecuteNonQuery();
                if (clienteRows == 0)
                {
                    MessageBox.Show("Nenhum registro de cliente encontrado para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Atualiza os dados do endereço
                cm.CommandText = updateEnderecoQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@CEP", txtcep.Text.Trim());
                cm.Parameters.AddWithValue("@Estado", cmbestado_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@TipoLogradouro", cmblogra_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Numero", txtnum_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Complemento", txtcomp_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Bairro", txtbairr_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Logradouro", txtlogr_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@Cidade", txtcidad_accontcli.Text.Trim());
                cm.Parameters.AddWithValue("@CPF", maskedcpf_accontcli.Text.Trim());

                int enderecoRows = cm.ExecuteNonQuery();
                if (enderecoRows == 0)
                {
                    MessageBox.Show("Nenhum registro de endereço encontrado para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar as alterações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void conta_accontcli_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Show();
        }
    }
}
