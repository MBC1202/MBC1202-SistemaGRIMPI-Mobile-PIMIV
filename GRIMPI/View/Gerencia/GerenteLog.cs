using Sistema.View.Home;
using Sistema.View.View.Gerencia;
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

namespace Sistema.View.Gerencia
{
    public partial class GerenteLog : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        public GerenteLog()
        {
            InitializeComponent();
        }

        private void btncloselogerent_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_logerent_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void GerenteLog_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Insira os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Verificar se o usuário é o administrador
                    if (txtUsuario.Text == "admin" && txtSenha.Text == "0000")
                    {
                        MessageBox.Show("Bem-vindo, Administrador!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir a tela de gerenciamento para o administrador
                        TelaGerencia telaGerencia = new TelaGerencia();
                        telaGerencia.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Abrindo conexão
                        cn.Open();

                        // Comando SQL para verificar credenciais
                        cm.Connection = cn;
                        cm.CommandText = "SELECT COUNT(*) FROM Adm WHERE UsuarioAdm = @Usuario AND SenhaAdm = @Senha";

                        // Adicionando parâmetros para evitar SQL Injection
                        cm.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cm.Parameters.AddWithValue("@Senha", txtSenha.Text);

                        // Executando comando
                        int resultado = (int)cm.ExecuteScalar();

                        if (resultado > 0) // Login bem-sucedido
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir próxima tela para usuários comuns
                            TelaDeDados telaDeDados = new TelaDeDados();    
                            telaDeDados.Show();
                            this.Hide();
                        }
                        else // Credenciais inválidas
                        {
                            MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSenha.Clear();
                            txtUsuario.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Garantir que a conexão será fechada
                    cm.Parameters.Clear(); // Limpar parâmetros para evitar interferência em futuras consultas
                    cn.Close();
                }
            }
        }


    }
}
