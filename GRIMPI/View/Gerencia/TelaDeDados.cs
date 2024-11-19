using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Diagnostics;  // Necessário para Process.Start
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Sistema.View.Gerencia;

namespace Sistema.View.View.Gerencia
{
    public partial class TelaDeDados : Form
    {
        // Conexão com o banco de dados
        SqlConnection cn = new SqlConnection(@"Data Source=MARIA;Integrated Security=SSPI;Initial Catalog=db_GRIMPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        public TelaDeDados()
        {
            InitializeComponent();
        }

        private void TelaDeDados_Load(object sender, EventArgs e)
        {
            // Chama o método para preencher a ListView ao carregar a tela
            PreencherListView();
        }

        // Método para preencher a ListView com dados da tabela
        private void PreencherListView()
        {
            // Limpar a ListView para garantir que ela comece vazia
            listView.Items.Clear();

            try
            {
                // Abrir a conexão com o banco de dados
                cn.Open();

                // Consulta SQL para pegar os dados da tabela Carrinho (ou qualquer tabela que você esteja usando)
                string query = "SELECT Produto, Quantidade, Valor FROM Vendas";
                cm = new SqlCommand(query, cn);

                // Executa a consulta e armazena os resultados
                dt = cm.ExecuteReader();

                // Itera sobre os resultados e preenche a ListView
                while (dt.Read())
                {
                    // Cria um novo item para a ListView
                    ListViewItem item = new ListViewItem(dt["Produto"].ToString());
                    item.SubItems.Add(dt["Quantidade"].ToString());
                    item.SubItems.Add(dt["Valor"].ToString());

                    // Adiciona o item à ListView
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                // Fechar o reader e a conexão
                if (dt != null) dt.Close();
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica que quiser para manipular o que acontece
            // quando o usuário seleciona um item na ListView (caso necessário)
        }

        private void btncloselogerent_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria uma instância do SaveFileDialog para permitir que o usuário escolha onde salvar o PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório como PDF";

                // Se o usuário escolher um arquivo e clicar em "Salvar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Caminho onde o arquivo PDF será salvo
                    string caminhoPDF = saveFileDialog.FileName;

                    // Criar o documento PDF
                    Document doc = new Document(PageSize.A4); // Usando A4 como tamanho de página
                    PdfWriter.GetInstance(doc, new FileStream(caminhoPDF, FileMode.Create));

                    // Abrir o documento
                    doc.Open();

                    // Título do relatório
                    doc.Add(new Paragraph("Relatório de Vendas"));
                    doc.Add(new Paragraph("\n"));

                    // Criar uma tabela com 3 colunas: Produto, Quantidade, Valor
                    PdfPTable table = new PdfPTable(3);
                    table.AddCell("Produto");
                    table.AddCell("Quantidade");
                    table.AddCell("Valor");

                    // Iterar pela ListView e adicionar os dados à tabela
                    foreach (ListViewItem item in listView.Items)
                    {
                        table.AddCell(item.SubItems[0].Text);  // Produto
                        table.AddCell(item.SubItems[1].Text);  // Quantidade
                        table.AddCell(item.SubItems[2].Text);  // Valor
                    }

                    // Adicionar a tabela ao documento
                    doc.Add(table);

                    // Fechar o documento
                    doc.Close();

                    MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVoltar_Click(object sender, EventArgs e)
        {
            GerenteLog gerenteLog = new GerenteLog();
            gerenteLog.Show();
            this.Hide();
        }
    }
}
