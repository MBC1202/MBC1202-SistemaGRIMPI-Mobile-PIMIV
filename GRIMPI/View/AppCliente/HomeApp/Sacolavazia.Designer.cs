namespace Sistema.View.AppCliente.HomeApp
{
    partial class Sacolavazia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            carrinho_sacolavaz = new PictureBox();
            logout_sacolavaz = new Label();
            label2 = new Label();
            conta_sacolavaz = new PictureBox();
            produtos_sacolavaz = new ComboBox();
            Quemsomos_sacolavaz = new Label();
            pictureBox2 = new PictureBox();
            splitter3 = new Splitter();
            label8 = new Label();
            splitter2 = new Splitter();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnclosesacolavaz = new Button();
            splitter1 = new Splitter();
            label13 = new Label();
            splitter4 = new Splitter();
            listCarinho = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnAvancar = new Button();
            btnExcluir = new Button();
            txtValorCarrinho = new Label();
            ((System.ComponentModel.ISupportInitialize)carrinho_sacolavaz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conta_sacolavaz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(885, 84);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 59;
            label3.Text = "Carrinho";
            // 
            // carrinho_sacolavaz
            // 
            carrinho_sacolavaz.Cursor = Cursors.Hand;
            carrinho_sacolavaz.Image = Properties.Resources.shopping_cart;
            carrinho_sacolavaz.Location = new Point(840, 75);
            carrinho_sacolavaz.Name = "carrinho_sacolavaz";
            carrinho_sacolavaz.Size = new Size(39, 34);
            carrinho_sacolavaz.SizeMode = PictureBoxSizeMode.StretchImage;
            carrinho_sacolavaz.TabIndex = 58;
            carrinho_sacolavaz.TabStop = false;
            carrinho_sacolavaz.Click += carrinho_sacolavaz_Click;
            // 
            // logout_sacolavaz
            // 
            logout_sacolavaz.AutoSize = true;
            logout_sacolavaz.Cursor = Cursors.Hand;
            logout_sacolavaz.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_sacolavaz.Location = new Point(733, 89);
            logout_sacolavaz.Name = "logout_sacolavaz";
            logout_sacolavaz.Size = new Size(35, 20);
            logout_sacolavaz.TabIndex = 57;
            logout_sacolavaz.Text = "Sair";
            logout_sacolavaz.Click += logout_sacolavaz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(715, 72);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 56;
            label2.Text = "Sua conta";
            // 
            // conta_sacolavaz
            // 
            conta_sacolavaz.Cursor = Cursors.Hand;
            conta_sacolavaz.Image = Properties.Resources.user__1_;
            conta_sacolavaz.Location = new Point(670, 72);
            conta_sacolavaz.Name = "conta_sacolavaz";
            conta_sacolavaz.Size = new Size(39, 34);
            conta_sacolavaz.SizeMode = PictureBoxSizeMode.StretchImage;
            conta_sacolavaz.TabIndex = 55;
            conta_sacolavaz.TabStop = false;
            conta_sacolavaz.Click += conta_sacolavaz_Click;
            // 
            // produtos_sacolavaz
            // 
            produtos_sacolavaz.Cursor = Cursors.Hand;
            produtos_sacolavaz.FormattingEnabled = true;
            produtos_sacolavaz.Items.AddRange(new object[] { "Alecrim", "Cebolinha", "Coentro", "Hortelã", "Lavanda", "Orégano" });
            produtos_sacolavaz.Location = new Point(410, 77);
            produtos_sacolavaz.Name = "produtos_sacolavaz";
            produtos_sacolavaz.Size = new Size(137, 28);
            produtos_sacolavaz.TabIndex = 54;
            produtos_sacolavaz.Text = "        Produtos";
            produtos_sacolavaz.SelectedIndexChanged += produtos_sacolavaz_SelectedIndexChanged;
            // 
            // Quemsomos_sacolavaz
            // 
            Quemsomos_sacolavaz.AutoSize = true;
            Quemsomos_sacolavaz.BackColor = SystemColors.ButtonHighlight;
            Quemsomos_sacolavaz.Cursor = Cursors.Hand;
            Quemsomos_sacolavaz.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quemsomos_sacolavaz.Location = new Point(203, 79);
            Quemsomos_sacolavaz.Name = "Quemsomos_sacolavaz";
            Quemsomos_sacolavaz.Size = new Size(65, 26);
            Quemsomos_sacolavaz.TabIndex = 53;
            Quemsomos_sacolavaz.Text = "Home";
            Quemsomos_sacolavaz.Click += Quemsomos_sacolavaz_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.LOGOGRIMPI;
            pictureBox2.Location = new Point(0, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // splitter3
            // 
            splitter3.BorderStyle = BorderStyle.Fixed3D;
            splitter3.Dock = DockStyle.Top;
            splitter3.Enabled = false;
            splitter3.Location = new Point(0, 69);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1010, 46);
            splitter3.TabIndex = 51;
            splitter3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(126, 217, 87);
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(320, 37);
            label8.Name = "label8";
            label8.Size = new Size(330, 26);
            label8.TabIndex = 50;
            label8.Text = "Onde a natureza encontra a cidade";
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(126, 217, 87);
            splitter2.Dock = DockStyle.Top;
            splitter2.Enabled = false;
            splitter2.Location = new Point(0, 34);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1010, 35);
            splitter2.TabIndex = 49;
            splitter2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 47;
            label1.Text = "GRIMPI";
            // 
            // btnclosesacolavaz
            // 
            btnclosesacolavaz.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclosesacolavaz.Location = new Point(978, 0);
            btnclosesacolavaz.Name = "btnclosesacolavaz";
            btnclosesacolavaz.Size = new Size(32, 34);
            btnclosesacolavaz.TabIndex = 46;
            btnclosesacolavaz.Text = "X";
            btnclosesacolavaz.UseVisualStyleBackColor = true;
            btnclosesacolavaz.Click += btnclosesacolavaz_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 45;
            splitter1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(126, 217, 87);
            label13.Cursor = Cursors.Hand;
            label13.Enabled = false;
            label13.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(320, 710);
            label13.Name = "label13";
            label13.Size = new Size(401, 20);
            label13.TabIndex = 343;
            label13.Text = "Compre agora e leve a essência da natureza para casa!";
            // 
            // splitter4
            // 
            splitter4.BackColor = Color.FromArgb(126, 217, 87);
            splitter4.Dock = DockStyle.Bottom;
            splitter4.Enabled = false;
            splitter4.Location = new Point(0, 706);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(1010, 33);
            splitter4.TabIndex = 342;
            splitter4.TabStop = false;
            // 
            // listCarinho
            // 
            listCarinho.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listCarinho.Location = new Point(50, 150);
            listCarinho.Name = "listCarinho";
            listCarinho.Size = new Size(912, 486);
            listCarinho.TabIndex = 345;
            listCarinho.UseCompatibleStateImageBehavior = false;
            listCarinho.View = System.Windows.Forms.View.Details;
            listCarinho.SelectedIndexChanged += listCarinho_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Produto";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantidade";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor";
            columnHeader3.Width = 300;
            // 
            // btnAvancar
            // 
            btnAvancar.Location = new Point(868, 658);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(94, 29);
            btnAvancar.TabIndex = 346;
            btnAvancar.Text = "Avançar";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(733, 658);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 347;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtValorCarrinho
            // 
            txtValorCarrinho.AutoSize = true;
            txtValorCarrinho.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorCarrinho.Location = new Point(50, 649);
            txtValorCarrinho.Name = "txtValorCarrinho";
            txtValorCarrinho.Size = new Size(131, 38);
            txtValorCarrinho.TabIndex = 348;
            txtValorCarrinho.Text = "Total R$ ";
            txtValorCarrinho.Click += txtValorCarrinho_Click;
            // 
            // Sacolavazia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(txtValorCarrinho);
            Controls.Add(btnExcluir);
            Controls.Add(btnAvancar);
            Controls.Add(listCarinho);
            Controls.Add(label13);
            Controls.Add(splitter4);
            Controls.Add(label3);
            Controls.Add(carrinho_sacolavaz);
            Controls.Add(logout_sacolavaz);
            Controls.Add(label2);
            Controls.Add(conta_sacolavaz);
            Controls.Add(produtos_sacolavaz);
            Controls.Add(Quemsomos_sacolavaz);
            Controls.Add(pictureBox2);
            Controls.Add(splitter3);
            Controls.Add(label8);
            Controls.Add(splitter2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnclosesacolavaz);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sacolavazia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sacolavazia";
            Load += Sacolavazia_Load;
            ((System.ComponentModel.ISupportInitialize)carrinho_sacolavaz).EndInit();
            ((System.ComponentModel.ISupportInitialize)conta_sacolavaz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox carrinho_sacolavaz;
        private Label logout_sacolavaz;
        private Label label2;
        private PictureBox conta_sacolavaz;
        private ComboBox produtos_sacolavaz;
        private Label Quemsomos_sacolavaz;
        private PictureBox pictureBox2;
        private Splitter splitter3;
        private Label label8;
        private Splitter splitter2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnclosesacolavaz;
        private Splitter splitter1;
        private Label label13;
        private Splitter splitter4;
        private ListView listCarinho;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAvancar;
        private Button btnExcluir;
        private Label txtValorCarrinho;
    }
}