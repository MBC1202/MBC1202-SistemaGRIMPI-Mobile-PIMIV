namespace Sistema.View.View.Gerencia
{
    partial class TelaDeDados
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
            label2 = new Label();
            label5 = new Label();
            splitter2 = new Splitter();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btncloselogerent = new Button();
            splitter1 = new Splitter();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnPDF = new Button();
            txtVoltar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 104);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 38;
            label2.Text = "Dados das Vendas ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 161, 76);
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(204, 46);
            label5.Name = "label5";
            label5.Size = new Size(601, 28);
            label5.TabIndex = 37;
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
            splitter2.TabIndex = 36;
            splitter2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 35;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btncloselogerent
            // 
            btncloselogerent.BackColor = Color.Transparent;
            btncloselogerent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncloselogerent.Location = new Point(978, 0);
            btncloselogerent.Name = "btncloselogerent";
            btncloselogerent.Size = new Size(32, 34);
            btncloselogerent.TabIndex = 33;
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
            splitter1.TabIndex = 32;
            splitter1.TabStop = false;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.Location = new Point(215, 147);
            listView.Name = "listView";
            listView.Size = new Size(601, 458);
            listView.TabIndex = 39;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Produto";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantidade";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor";
            columnHeader3.Width = 200;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.FromArgb(32, 161, 76);
            btnPDF.Location = new Point(449, 636);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(150, 36);
            btnPDF.TabIndex = 40;
            btnPDF.Text = "Exportar PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // txtVoltar
            // 
            txtVoltar.AutoSize = true;
            txtVoltar.BackColor = SystemColors.ButtonHighlight;
            txtVoltar.Cursor = Cursors.Hand;
            txtVoltar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVoltar.Location = new Point(946, 675);
            txtVoltar.Name = "txtVoltar";
            txtVoltar.Size = new Size(52, 25);
            txtVoltar.TabIndex = 41;
            txtVoltar.Text = "Sair";
            txtVoltar.Click += txtVoltar_Click;
            // 
            // TelaDeDados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(txtVoltar);
            Controls.Add(btnPDF);
            Controls.Add(listView);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(splitter2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btncloselogerent);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaDeDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeDados";
            Load += TelaDeDados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label5;
        private Splitter splitter2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btncloselogerent;
        private Splitter splitter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnPDF;
        private Label txtVoltar;
    }
}