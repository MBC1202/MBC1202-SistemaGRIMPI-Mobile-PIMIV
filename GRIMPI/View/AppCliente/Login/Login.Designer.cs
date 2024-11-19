namespace Sistema.View.Home
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            splitter1 = new Splitter();
            btncloselog = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            cademp_log = new LinkLabel();
            cadpess_login = new LinkLabel();
            label5 = new Label();
            splitter2 = new Splitter();
            Quemsomoslog = new Label();
            splitter3 = new Splitter();
            admlog = new LinkLabel();
            label8 = new Label();
            label2 = new Label();
            txtuserlog = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtsenhalog = new TextBox();
            btnenterlog = new Button();
            label6 = new Label();
            panel1 = new Panel();
            lookpassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookpassword).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // btncloselog
            // 
            btncloselog.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncloselog.Location = new Point(978, 0);
            btncloselog.Name = "btncloselog";
            btncloselog.Size = new Size(32, 34);
            btncloselog.TabIndex = 1;
            btncloselog.Text = "X";
            btncloselog.UseVisualStyleBackColor = true;
            btncloselog.Click += btncloselog_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 5;
            label1.Text = "GRIMPI";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Enabled = false;
            panel2.Location = new Point(166, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 467);
            panel2.TabIndex = 8;
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
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(cademp_log);
            panel6.Controls.Add(cadpess_login);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(451, 533);
            panel6.Name = "panel6";
            panel6.Size = new Size(393, 83);
            panel6.TabIndex = 9;
            // 
            // cademp_log
            // 
            cademp_log.AutoSize = true;
            cademp_log.Location = new Point(124, 42);
            cademp_log.Name = "cademp_log";
            cademp_log.Size = new Size(150, 20);
            cademp_log.TabIndex = 2;
            cademp_log.TabStop = true;
            cademp_log.Text = "Cadastro Empresarial";
            cademp_log.LinkClicked += cademp_log_LinkClicked;
            // 
            // cadpess_login
            // 
            cadpess_login.AutoSize = true;
            cadpess_login.Location = new Point(137, 22);
            cadpess_login.Name = "cadpess_login";
            cadpess_login.Size = new Size(120, 20);
            cadpess_login.TabIndex = 1;
            cadpess_login.TabStop = true;
            cadpess_login.Text = "Cadastro Pessoal";
            cadpess_login.LinkClicked += cadpess_login_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 0);
            label5.Name = "label5";
            label5.Size = new Size(231, 22);
            label5.TabIndex = 0;
            label5.Text = "Não tem conta? Cadastre-se";
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(126, 217, 87);
            splitter2.BorderStyle = BorderStyle.FixedSingle;
            splitter2.Dock = DockStyle.Top;
            splitter2.Enabled = false;
            splitter2.Location = new Point(0, 34);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1010, 39);
            splitter2.TabIndex = 10;
            splitter2.TabStop = false;
            // 
            // Quemsomoslog
            // 
            Quemsomoslog.AutoSize = true;
            Quemsomoslog.BackColor = Color.FromArgb(126, 217, 87);
            Quemsomoslog.Cursor = Cursors.Hand;
            Quemsomoslog.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quemsomoslog.Location = new Point(50, 43);
            Quemsomoslog.Name = "Quemsomoslog";
            Quemsomoslog.Size = new Size(226, 26);
            Quemsomoslog.TabIndex = 11;
            Quemsomoslog.Text = "Quem somos e Contatos";
            Quemsomoslog.Click += Quemsomoslog_Click;
            // 
            // splitter3
            // 
            splitter3.BackColor = Color.FromArgb(126, 217, 87);
            splitter3.Dock = DockStyle.Bottom;
            splitter3.Enabled = false;
            splitter3.Location = new Point(0, 699);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1010, 40);
            splitter3.TabIndex = 13;
            splitter3.TabStop = false;
            // 
            // admlog
            // 
            admlog.AutoSize = true;
            admlog.BackColor = Color.FromArgb(126, 217, 87);
            admlog.Cursor = Cursors.Hand;
            admlog.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admlog.Location = new Point(802, 43);
            admlog.Name = "admlog";
            admlog.Size = new Size(196, 20);
            admlog.TabIndex = 14;
            admlog.TabStop = true;
            admlog.Text = "Entre como administrador";
            admlog.LinkClicked += admlog_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(126, 217, 87);
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(392, 710);
            label8.Name = "label8";
            label8.Size = new Size(247, 20);
            label8.TabIndex = 15;
            label8.Text = "Grupo Fazenda Urbana GRIMPI";
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
            // txtuserlog
            // 
            txtuserlog.Location = new Point(66, 154);
            txtuserlog.MaxLength = 20;
            txtuserlog.Name = "txtuserlog";
            txtuserlog.Size = new Size(255, 27);
            txtuserlog.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 125);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 2;
            label3.Text = "CPF/CNPJ:";
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
            // txtsenhalog
            // 
            txtsenhalog.Location = new Point(66, 232);
            txtsenhalog.MaxLength = 25;
            txtsenhalog.Name = "txtsenhalog";
            txtsenhalog.Size = new Size(226, 27);
            txtsenhalog.TabIndex = 4;
            txtsenhalog.UseSystemPasswordChar = true;
            // 
            // btnenterlog
            // 
            btnenterlog.BackColor = Color.FromArgb(126, 217, 87);
            btnenterlog.Location = new Point(124, 284);
            btnenterlog.Name = "btnenterlog";
            btnenterlog.Size = new Size(150, 36);
            btnenterlog.TabIndex = 5;
            btnenterlog.Text = "Entrar";
            btnenterlog.UseVisualStyleBackColor = false;
            btnenterlog.Click += btnenterlog_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 194);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lookpassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnenterlog);
            panel1.Controls.Add(txtsenhalog);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtuserlog);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(451, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 378);
            panel1.TabIndex = 7;
            // 
            // lookpassword
            // 
            lookpassword.Cursor = Cursors.Hand;
            lookpassword.Image = (Image)resources.GetObject("lookpassword.Image");
            lookpassword.Location = new Point(291, 232);
            lookpassword.Name = "lookpassword";
            lookpassword.Size = new Size(30, 27);
            lookpassword.SizeMode = PictureBoxSizeMode.StretchImage;
            lookpassword.TabIndex = 16;
            lookpassword.TabStop = false;
            lookpassword.Click += lookpassword_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(label8);
            Controls.Add(admlog);
            Controls.Add(splitter3);
            Controls.Add(Quemsomoslog);
            Controls.Add(splitter2);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btncloselog);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicial";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookpassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private Button btncloselog;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label label5;
        private Splitter splitter2;
        private Label Quemsomoslog;
        private Splitter splitter3;
        private LinkLabel admlog;
        private Label label8;
        private LinkLabel cademp_log;
        private LinkLabel cadpess_login;
        private Label label2;
        private TextBox txtuserlog;
        private Label label3;
        private Label label4;
        private TextBox txtsenhalog;
        private Button btnenterlog;
        private Label label6;
        private Panel panel1;
        private PictureBox lookpassword;
    }
}