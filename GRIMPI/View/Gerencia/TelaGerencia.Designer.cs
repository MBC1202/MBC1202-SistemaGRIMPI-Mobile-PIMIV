namespace Sistema.View.View.Gerencia
{
    partial class TelaGerencia
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
            label5 = new Label();
            splitter2 = new Splitter();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btncloselogerent = new Button();
            splitter1 = new Splitter();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new MaskedTextBox();
            btnenterlog = new Button();
            listAutorizadas = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnExcluir = new Button();
            txtSair = new Label();
            txtDados = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 161, 76);
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(186, 46);
            label5.Name = "label5";
            label5.Size = new Size(601, 28);
            label5.TabIndex = 30;
            label5.Text = "Sistema Integrado de Gerenciamento GRIMPI";
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(32, 161, 76);
            splitter2.BorderStyle = BorderStyle.FixedSingle;
            splitter2.Dock = DockStyle.Top;
            splitter2.Enabled = false;
            splitter2.Location = new Point(0, 34);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1010, 50);
            splitter2.TabIndex = 28;
            splitter2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 27;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btncloselogerent
            // 
            btncloselogerent.BackColor = Color.Transparent;
            btncloselogerent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncloselogerent.Location = new Point(978, 0);
            btncloselogerent.Name = "btncloselogerent";
            btncloselogerent.Size = new Size(32, 34);
            btncloselogerent.TabIndex = 25;
            btncloselogerent.Text = "X";
            btncloselogerent.UseVisualStyleBackColor = false;
            btncloselogerent.Click += btncloselogerent_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 24;
            splitter1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(353, 97);
            label2.Name = "label2";
            label2.Size = new Size(299, 25);
            label2.TabIndex = 31;
            label2.Text = "Cadastrar pessoa autorizada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(278, 156);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 32;
            label3.Text = "Digite o Usuário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 203);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 33;
            label4.Text = "Digite a senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(464, 154);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 27);
            txtUsuario.TabIndex = 34;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(464, 201);
            txtSenha.Mask = "0000";
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(57, 27);
            txtSenha.TabIndex = 35;
            // 
            // btnenterlog
            // 
            btnenterlog.BackColor = Color.FromArgb(32, 161, 76);
            btnenterlog.Location = new Point(464, 258);
            btnenterlog.Name = "btnenterlog";
            btnenterlog.Size = new Size(150, 36);
            btnenterlog.TabIndex = 36;
            btnenterlog.Text = "Cadastrar";
            btnenterlog.UseVisualStyleBackColor = false;
            btnenterlog.Click += btnenterlog_Click;
            // 
            // listAutorizadas
            // 
            listAutorizadas.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3 });
            listAutorizadas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listAutorizadas.Location = new Point(170, 300);
            listAutorizadas.Name = "listAutorizadas";
            listAutorizadas.Size = new Size(708, 325);
            listAutorizadas.TabIndex = 37;
            listAutorizadas.UseCompatibleStateImageBehavior = false;
            listAutorizadas.View = System.Windows.Forms.View.Details;
            listAutorizadas.SelectedIndexChanged += listAutorizadas_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Senha";
            columnHeader3.Width = 350;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(728, 657);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 36);
            btnExcluir.TabIndex = 38;
            btnExcluir.Text = "Excluir cadastro";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtSair
            // 
            txtSair.AutoSize = true;
            txtSair.BackColor = SystemColors.ButtonHighlight;
            txtSair.Cursor = Cursors.Hand;
            txtSair.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSair.Location = new Point(12, 705);
            txtSair.Name = "txtSair";
            txtSair.Size = new Size(52, 25);
            txtSair.TabIndex = 39;
            txtSair.Text = "Sair";
            txtSair.Click += txtSair_Click;
            // 
            // txtDados
            // 
            txtDados.AutoSize = true;
            txtDados.BackColor = Color.FromArgb(32, 161, 76);
            txtDados.Cursor = Cursors.Hand;
            txtDados.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtDados.Location = new Point(861, 46);
            txtDados.Name = "txtDados";
            txtDados.Size = new Size(149, 20);
            txtDados.TabIndex = 40;
            txtDados.Text = "Dados das Vendas";
            txtDados.Click += txtDados_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(32, 161, 76);
            pictureBox2.Image = Properties.Resources.folder;
            pictureBox2.Location = new Point(807, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // TelaGerencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(pictureBox2);
            Controls.Add(txtDados);
            Controls.Add(txtSair);
            Controls.Add(btnExcluir);
            Controls.Add(listAutorizadas);
            Controls.Add(btnenterlog);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(splitter2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btncloselogerent);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaGerencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaGerencia";
            Load += TelaGerencia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Splitter splitter2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btncloselogerent;
        private Splitter splitter1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private MaskedTextBox txtSenha;
        private Button btnenterlog;
        private ListView listAutorizadas;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnExcluir;
        private Label txtSair;
        private Label txtDados;
        private PictureBox pictureBox2;
    }
}