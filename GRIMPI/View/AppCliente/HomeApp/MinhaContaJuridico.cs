using Sistema.View.AppCliente.HomeApp.Produtos;
using Sistema.View.Home;
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

namespace Sistema.View.AppCliente.HomeApp
{
    public partial class MinhaContaJuridico : Form
    {
        private readonly SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public MinhaContaJuridico()
        {
            InitializeComponent();
        }

        private void btncloseaccontjuri_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quemsomos_accontjuri_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }



        private void conta_accontjuri_Click(object sender, EventArgs e)
        {
            MinhaContaJuridico minhaContaJuridico = new MinhaContaJuridico();
            minhaContaJuridico.ShowDialog();
            this.Hide();
        }

        private void logout_accontjuri_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Hide();
        }

        private void MinhaContaJuridico_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo do CNPJ está preenchido
            if (string.IsNullOrWhiteSpace(textVerificaCNPJ.Text))
            {
                MessageBox.Show("Por favor, insira um CNPJ válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query para buscar os dados do cliente jurídico
            string juridicoQuery = "SELECT Id, NomeFantasia, EmailJuri, CNPJ, TelefoneComercial FROM Cad_Juridico WHERE CNPJ = @CNPJ";
            string enderecoJuridicoQuery = "SELECT CEPJuri, EstadoJuri, LogradouroJuri, NumeroJuri, ComplementoJuri, BairroJuri, LogradouroJuri, CidadeJuri FROM CadJuri_Enderecos WHERE JuridicoId = @JuridicoId";

            try
            {
                cn.Open();
                cm.Connection = cn;

                // Primeiro: Busca os dados do cliente jurídico
                cm.CommandText = juridicoQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@CNPJ", textVerificaCNPJ.Text.Trim());
                dr = cm.ExecuteReader();

                int idJuridico = -1;

                if (dr.Read())
                {
                    // Preenche os campos do cliente jurídico
                    idJuridico = Convert.ToInt32(dr["Id"]);
                    txtrazso_accontjuri.Text = dr["NomeFantasia"].ToString();
                    txtemail_accontjuri.Text = dr["EmailJuri"].ToString();
                    mascnpj_accontjuri.Text = dr["CNPJ"].ToString();
                    masktelcomer_accontjuri.Text = dr["TelefoneComercial"].ToString();
                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado no banco de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dr.Close();

                // Segundo: Busca os dados do endereço com base no ID do cliente jurídico
                cm.CommandText = enderecoJuridicoQuery;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@JuridicoId", idJuridico); // Usando JuridicoId
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    // Preenche os campos de endereço
                    maskcep_accontjuri.Text = dr["CEPJuri"].ToString();
                    cmbestado_accontjuri.Text = dr["EstadoJuri"].ToString();
                    cmblogra_accontjuri.Text = dr["LogradouroJuri"].ToString();
                    txtnum_accontjuri.Text = dr["NumeroJuri"].ToString();
                    txtcomp_accontjuri.Text = dr["ComplementoJuri"].ToString();
                    txtbairr_accontjuri.Text = dr["BairroJuri"].ToString();
                    txtlogr_accontjuri.Text = dr["LogradouroJuri"].ToString();
                    txtcidad_accontjuri.Text = dr["CidadeJuri"].ToString();

                    txtrazso_accontjuri.Enabled = false;
                    txtemail_accontjuri.Enabled = false;
                    mascnpj_accontjuri.Enabled = false;
                    masktelcomer_accontjuri.Enabled = false;
                    maskcep_accontjuri.Enabled = false;
                    cmbestado_accontjuri.Enabled = false;
                    cmblogra_accontjuri.Enabled = false;
                    txtnum_accontjuri.Enabled = false;
                    txtcomp_accontjuri.Enabled = false;
                    txtbairr_accontjuri.Enabled = false;
                    txtlogr_accontjuri.Enabled = false;
                    txtcidad_accontjuri.Enabled = false;

                    panelVerifica.Visible = false;
                }
                else
                {
                    MessageBox.Show("Endereço não encontrado para o cliente jurídico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void editaccontjuri_Click(object sender, EventArgs e)
        {
            txtrazso_accontjuri.Enabled = true;
            txtemail_accontjuri.Enabled = true;
            masktelcomer_accontjuri.Enabled = true;
            maskcep_accontjuri.Enabled = true;
            cmbestado_accontjuri.Enabled = true;
            cmblogra_accontjuri.Enabled = true;
            txtnum_accontjuri.Enabled = true;
            txtcomp_accontjuri.Enabled = true;
            txtcidad_accontjuri.Enabled = true;
            txtlogr_accontjuri.Enabled = true;
            txtbairr_accontjuri.Enabled = true;


        }

        private void txtSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtrazso_accontjuri.Text) ||
                string.IsNullOrWhiteSpace(txtemail_accontjuri.Text) ||
                string.IsNullOrWhiteSpace(mascnpj_accontjuri.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query para atualizar os dados do cliente jurídico
            string updateJuridicoQuery = @"
UPDATE Cad_Juridico
SET NomeFantasia = @NomeFantasia, 
    EmailJuri = @EmailJuri, 
    TelefoneComercial = @TelefoneComercial
WHERE CNPJ = @CNPJ";

            // Query para atualizar os dados do endereço do cliente jurídico
            string updateEnderecoJuridicoQuery = @"
UPDATE CadJuri_Enderecos
SET CEPJuri = @CEPJuri, 
    EstadoJuri = @EstadoJuri, 
    TipoLogradouroJuri = @TipoLogradouroJuri, 
    NumeroJuri = @NumeroJuri, 
    ComplementoJuri = @ComplementoJuri, 
    BairroJuri = @BairroJuri, 
    LogradouroJuri = @LogradouroJuri, 
    CidadeJuri = @CidadeJuri
WHERE JuridicoId = (SELECT Id FROM Cad_Juridico WHERE CNPJ = @CNPJ)";

            try
            {
                cn.Open();
                cm.Connection = cn;

                // Atualiza os dados do cliente jurídico
                cm.Parameters.Clear(); // Limpa parâmetros antigos
                cm.CommandText = updateJuridicoQuery;
                cm.Parameters.AddWithValue("@NomeFantasia", txtrazso_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@EmailJuri", txtemail_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@TelefoneComercial", masktelcomer_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@CNPJ", mascnpj_accontjuri.Text.Trim());

                int juridicoRows = cm.ExecuteNonQuery();
                if (juridicoRows == 0)
                {
                    MessageBox.Show("Nenhum registro de cliente jurídico encontrado para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Atualiza os dados do endereço do cliente jurídico
                cm.Parameters.Clear(); // Limpa os parâmetros antigos antes de reusar o comando
                cm.CommandText = updateEnderecoJuridicoQuery;
                cm.Parameters.AddWithValue("@CEPJuri", maskcep_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@EstadoJuri", cmbestado_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@TipoLogradouroJuri", cmblogra_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@NumeroJuri", txtnum_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@ComplementoJuri", txtcomp_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@BairroJuri", txtbairr_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@LogradouroJuri", txtlogr_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@CidadeJuri", txtcidad_accontjuri.Text.Trim());
                cm.Parameters.AddWithValue("@CNPJ", mascnpj_accontjuri.Text.Trim());

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
                // Exibe mensagem de erro
                MessageBox.Show($"Erro ao salvar as alterações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
