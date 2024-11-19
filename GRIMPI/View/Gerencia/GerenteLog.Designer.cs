namespace Sistema.View.Gerencia
{
    partial class GerenteLog
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
            splitter2 = new Splitter();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btncloselogerent = new Button();
            splitter1 = new Splitter();
            back_logerent = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtSenha = new MaskedTextBox();
            btnEntrar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            splitter3 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            splitter2.TabIndex = 19;
            splitter2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 18;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btncloselogerent
            // 
            btncloselogerent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncloselogerent.Location = new Point(978, 0);
            btncloselogerent.Name = "btncloselogerent";
            btncloselogerent.Size = new Size(32, 34);
            btncloselogerent.TabIndex = 16;
            btncloselogerent.Text = "X";
            btncloselogerent.UseVisualStyleBackColor = true;
            btncloselogerent.Click += btncloselogerent_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 15;
            splitter1.TabStop = false;
            // 
            // back_logerent
            // 
            back_logerent.AutoSize = true;
            back_logerent.BackColor = SystemColors.ButtonHighlight;
            back_logerent.Cursor = Cursors.Hand;
            back_logerent.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_logerent.Location = new Point(910, 87);
            back_logerent.Name = "back_logerent";
            back_logerent.Size = new Size(73, 25);
            back_logerent.TabIndex = 20;
            back_logerent.Text = "Voltar";
            back_logerent.Click += back_logerent_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(166, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 467);
            panel2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGOGRIMPI;
            pictureBox2.Location = new Point(21, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(251, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(451, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 467);
            panel1.TabIndex = 21;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(66, 243);
            txtSenha.Mask = "0000";
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(255, 27);
            txtSenha.TabIndex = 6;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(32, 161, 76);
            btnEntrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(112, 296);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(169, 38);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 203);
            label4.Name = "label4";
            label4.Size = new Size(75, 26);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 125);
            label3.Name = "label3";
            label3.Size = new Size(42, 26);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(66, 154);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(255, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 161, 76);
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(204, 46);
            label5.Name = "label5";
            label5.Size = new Size(601, 28);
            label5.TabIndex = 23;
            label5.Text = "Sistema Integrado de Gerenciamento GRIMPI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(32, 161, 76);
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(383, 710);
            label8.Name = "label8";
            label8.Size = new Size(247, 20);
            label8.TabIndex = 25;
            label8.Text = "Grupo Fazenda Urbana GRIMPI";
            // 
            // splitter3
            // 
            splitter3.BackColor = Color.FromArgb(32, 161, 76);
            splitter3.Dock = DockStyle.Bottom;
            splitter3.Enabled = false;
            splitter3.Location = new Point(0, 699);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1010, 40);
            splitter3.TabIndex = 24;
            splitter3.TabStop = false;
            // 
            // GerenteLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(label8);
            Controls.Add(splitter3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(back_logerent);
            Controls.Add(splitter2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btncloselogerent);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenteLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Adm";
            Load += GerenteLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Splitter splitter2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btncloselogerent;
        private Splitter splitter1;
        private Label back_logerent;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btnEntrar;
        private TextBox txtsenhalogerent;
        private Label label4;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private Label label5;
        private Label label8;
        private Splitter splitter3;
        private MaskedTextBox txtSenha;
    }
}