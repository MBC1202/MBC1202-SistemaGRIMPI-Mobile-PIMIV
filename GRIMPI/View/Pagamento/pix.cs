using QRCoder;
using Sistema.View.AppCliente;
using Sistema.View.AppCliente.HomeApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema.View.View.Pagamento
{
    public partial class pix : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        public pix()
        {
            InitializeComponent();
        }

        private void pix_Load(object sender, EventArgs e)
        {
            // Texto para gerar o QR Code
            string texto = "Fazenda GRIMPI - Excelência em qualidade.";  // Substitua com o texto desejado
            GerarQRCode(texto);  // Chama a função que gera o QR Code
        }

        private void GerarQRCode(string texto)
        {
            try
            {
                if (string.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("O texto para gerar o QR Code não pode ser nulo ou vazio.");
                    return;
                }

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);

                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(20);  // Gera a imagem do QR Code

                        // Redimensiona a imagem do QR Code para o tamanho do pictureBox
                        Bitmap resizedQrCodeImage = new Bitmap(qrCodeImage, new Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height));

                        // Atribui a imagem gerada ao PictureBox
                        pictureBoxQRCode.Image = resizedQrCodeImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar QR Code: " + ex.Message);
            }
        }

        private void btnConfimar_Click(object sender, EventArgs e)
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

            // Confirmar se o usuário deseja continuar ou sair do aplicativo
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

        // Método para salvar os itens do carrinho no banco
        public void SalvarItensCarrinhoNoBanco()
        {
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

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
