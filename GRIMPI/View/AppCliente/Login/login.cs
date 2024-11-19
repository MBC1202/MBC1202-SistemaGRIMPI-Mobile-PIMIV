using Sistema.View.AppCliente;
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


namespace Sistema.View.Home
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        // Estabelecendo conexão com Banco de Dados SQL Server
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btncloselog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnenterlog_Click(object sender, EventArgs e)
        {
            if (txtuserlog.Text == "" || txtsenhalog.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos para continuar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    // Limpar parâmetros antes de executar a consulta
                    cm.Parameters.Clear();

                    // Remover espaços extras e possíveis formatações do CPF ou CNPJ
                    string usuario = txtuserlog.Text.Trim().Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", ""); // Remove caracteres não numéricos
                    string senha = txtsenhalog.Text.Trim();

                    // Verificar se é CPF ou CNPJ (se o tamanho do usuário for 11, assumimos que é CPF, caso contrário, é CNPJ)
                    string sqlQuery = "";
                    if (usuario.Length == 11) // CPF
                    {
                        sqlQuery = "SELECT * FROM Cad_Clientes WHERE CPF = @usuario AND Senha = @senha";
                    }
                    else if (usuario.Length == 14) // CNPJ
                    {
                        sqlQuery = "SELECT * FROM Cad_Juridico WHERE CNPJ = @usuario AND SenhaJuri = @senha";
                    }
                    else
                    {
                        MessageBox.Show("Usuário (CPF ou CNPJ) inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Definindo o comando SQL
                    cm.CommandText = sqlQuery;

                    // Adicionando os parâmetros ao comando
                    cm.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, usuario.Length)).Value = usuario;
                    cm.Parameters.Add(new SqlParameter("@senha", SqlDbType.NVarChar, 25)).Value = senha;

                    // Associando a conexão ao comando SQL
                    cm.Connection = cn;

                    // Abrir a conexão
                    cn.Open();

                    // Executar a consulta e obter os resultados
                    dt = cm.ExecuteReader();

                    // Verificar se a consulta retornou algum resultado
                    if (dt.HasRows)
                    {
                        MessageBox.Show("Login realizado com sucesso! Aproveite sua experiência.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        App home = new App();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos. Por favor, verifique as informações e tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Captura de erros específicos de SQL
                    MessageBox.Show("Erro de SQL: " + sqlEx.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    // Captura de erros gerais
                    MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fechar o SqlDataReader e a conexão no final
                    if (dt != null && !dt.IsClosed)
                        dt.Close();

                    if (cn.State == ConnectionState.Open)
                        cn.Close();
                }
            }
        }



        private void Quemsomoslog_Click(object sender, EventArgs e)
        {
            QuemSomos quemSomos = new QuemSomos();
            quemSomos.Show();
            this.Hide();
        }

        private void cadpess_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadCliente cadCliente = new CadCliente();
            cadCliente.Show();
            this.Hide();
        }

        private void cademp_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadEmpresa empresa = new CadEmpresa();
            empresa.Show();
            this.Hide();
        }

        private void admlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GerenteLog log = new GerenteLog();
            log.Show();
            this.Hide();
        }

        private void lookpassword_Click(object sender, EventArgs e)
        {
            if (txtsenhalog.UseSystemPasswordChar)  // Se a senha estiver oculta
            {
                txtsenhalog.UseSystemPasswordChar = false; // Torna a senha visível
            }
            else
            {
                txtsenhalog.UseSystemPasswordChar = true; // Torna a senha invisível
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}