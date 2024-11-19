namespace Sistema.View.AppCliente
{
    partial class QuemSomos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuemSomos));
            splitter1 = new Splitter();
            btnclose_cadcli = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            splitter2 = new Splitter();
            piclog_who = new PictureBox();
            Irlog_who = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            splitter4 = new Splitter();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclog_who).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // btnclose_cadcli
            // 
            btnclose_cadcli.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose_cadcli.Location = new Point(978, 0);
            btnclose_cadcli.Name = "btnclose_cadcli";
            btnclose_cadcli.Size = new Size(32, 34);
            btnclose_cadcli.TabIndex = 4;
            btnclose_cadcli.Text = "X";
            btnclose_cadcli.UseVisualStyleBackColor = true;
            btnclose_cadcli.Click += btnclose_cadcli_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 8;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(126, 217, 87);
            splitter2.BorderStyle = BorderStyle.FixedSingle;
            splitter2.Dock = DockStyle.Top;
            splitter2.Enabled = false;
            splitter2.Location = new Point(0, 34);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1010, 44);
            splitter2.TabIndex = 12;
            splitter2.TabStop = false;
            // 
            // piclog_who
            // 
            piclog_who.BackColor = Color.FromArgb(126, 217, 87);
            piclog_who.Cursor = Cursors.Hand;
            piclog_who.Image = Properties.Resources.login;
            piclog_who.Location = new Point(900, 37);
            piclog_who.Name = "piclog_who";
            piclog_who.Size = new Size(46, 38);
            piclog_who.SizeMode = PictureBoxSizeMode.StretchImage;
            piclog_who.TabIndex = 15;
            piclog_who.TabStop = false;
            piclog_who.Click += piclog_who_Click;
            // 
            // Irlog_who
            // 
            Irlog_who.AutoSize = true;
            Irlog_who.BackColor = Color.FromArgb(126, 217, 87);
            Irlog_who.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Irlog_who.Location = new Point(952, 44);
            Irlog_who.Name = "Irlog_who";
            Irlog_who.Size = new Size(46, 20);
            Irlog_who.TabIndex = 24;
            Irlog_who.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 217, 87);
            label3.Location = new Point(50, 125);
            label3.Name = "label3";
            label3.Size = new Size(386, 34);
            label3.TabIndex = 25;
            label3.Text = "Sobre a Fazenda GRIMPI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 81);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 26;
            label2.Text = "Login > Quem somos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(597, 200);
            label4.TabIndex = 27;
            label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.areafazenda1;
            pictureBox3.Location = new Point(615, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(376, 452);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // splitter4
            // 
            splitter4.BackColor = Color.FromArgb(126, 217, 87);
            splitter4.Dock = DockStyle.Bottom;
            splitter4.Enabled = false;
            splitter4.Location = new Point(0, 636);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(1010, 103);
            splitter4.TabIndex = 29;
            splitter4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(12, 418);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 31;
            label6.Text = "GRIMPI,";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(107, 421);
            label7.Name = "label7";
            label7.Size = new Size(458, 20);
            label7.TabIndex = 32;
            label7.Text = "referência nacional na excelência da qualidade do agronegócio.\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(126, 217, 87);
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(247, 645);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 33;
            label8.Text = "Endereço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(126, 217, 87);
            label9.Cursor = Cursors.IBeam;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(554, 682);
            label9.Name = "label9";
            label9.Size = new Size(274, 38);
            label9.TabIndex = 34;
            label9.Text = "Entre em contato com a GRIMPI \r\ntambém pelo telefone (31) 9876-5432";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(126, 217, 87);
            label10.Cursor = Cursors.IBeam;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(150, 682);
            label10.Name = "label10";
            label10.Size = new Size(306, 38);
            label10.TabIndex = 35;
            label10.Text = "Av. das Árvores, 456 - Bairro Colina Verde, \r\nBelo Horizonte - MG CEP: 30145-678";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(126, 217, 87);
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(637, 645);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 36;
            label11.Text = "Telefone";
            // 
            // QuemSomos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(splitter4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Irlog_who);
            Controls.Add(piclog_who);
            Controls.Add(splitter2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnclose_cadcli);
            Controls.Add(splitter1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuemSomos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuemSomos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclog_who).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private Button btnclose_cadcli;
        private Label label1;
        private PictureBox pictureBox1;
        private Splitter splitter2;
        private PictureBox piclog_who;
        private Label Irlog_who;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox3;
        private Splitter splitter4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}