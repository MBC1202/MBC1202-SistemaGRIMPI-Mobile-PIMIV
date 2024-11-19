namespace Sistema.View.AppCliente.HomeApp.Produtos
{
    partial class LavandaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LavandaForm));
            label5 = new Label();
            label3 = new Label();
            carrinho_Lavanda = new PictureBox();
            logout_Lavanda = new Label();
            label2 = new Label();
            conta_lavanda = new PictureBox();
            produtos_lavanda = new ComboBox();
            Quemsomos_lavanda = new Label();
            pictureBox2 = new PictureBox();
            splitter3 = new Splitter();
            label8 = new Label();
            splitter2 = new Splitter();
            btnclose_lavanda = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            splitter1 = new Splitter();
            panel1 = new Panel();
            buy_lavanda150 = new Button();
            label7 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            buy_lavanda300 = new Button();
            label9 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            buy_lavanda600 = new Button();
            label11 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            label13 = new Label();
            splitter4 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)carrinho_Lavanda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conta_lavanda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(101, 150);
            label5.Name = "label5";
            label5.Size = new Size(143, 34);
            label5.TabIndex = 61;
            label5.Text = "Lavanda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(901, 74);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 59;
            label3.Text = "Carrinho";
            // 
            // carrinho_Lavanda
            // 
            carrinho_Lavanda.Cursor = Cursors.Hand;
            carrinho_Lavanda.Image = Properties.Resources.shopping_cart;
            carrinho_Lavanda.Location = new Point(856, 65);
            carrinho_Lavanda.Name = "carrinho_Lavanda";
            carrinho_Lavanda.Size = new Size(39, 34);
            carrinho_Lavanda.SizeMode = PictureBoxSizeMode.StretchImage;
            carrinho_Lavanda.TabIndex = 58;
            carrinho_Lavanda.TabStop = false;
            carrinho_Lavanda.Click += carrinho_Lavanda_Click;
            // 
            // logout_Lavanda
            // 
            logout_Lavanda.AutoSize = true;
            logout_Lavanda.Cursor = Cursors.Hand;
            logout_Lavanda.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_Lavanda.Location = new Point(724, 85);
            logout_Lavanda.Name = "logout_Lavanda";
            logout_Lavanda.Size = new Size(35, 20);
            logout_Lavanda.TabIndex = 57;
            logout_Lavanda.Text = "Sair";
            logout_Lavanda.Click += logout_Lavanda_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(709, 65);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 56;
            label2.Text = "Sua conta";
            // 
            // conta_lavanda
            // 
            conta_lavanda.Cursor = Cursors.Hand;
            conta_lavanda.Image = Properties.Resources.user__1_;
            conta_lavanda.Location = new Point(664, 65);
            conta_lavanda.Name = "conta_lavanda";
            conta_lavanda.Size = new Size(39, 34);
            conta_lavanda.SizeMode = PictureBoxSizeMode.StretchImage;
            conta_lavanda.TabIndex = 55;
            conta_lavanda.TabStop = false;
            conta_lavanda.Click += conta_lavanda_Click;
            // 
            // produtos_lavanda
            // 
            produtos_lavanda.Cursor = Cursors.Hand;
            produtos_lavanda.FormattingEnabled = true;
            produtos_lavanda.Items.AddRange(new object[] { "Alecrim", "Cebolinha", "Coentro", "Hortelã", "Lavanda", "Orégano" });
            produtos_lavanda.Location = new Point(411, 76);
            produtos_lavanda.Name = "produtos_lavanda";
            produtos_lavanda.Size = new Size(137, 28);
            produtos_lavanda.TabIndex = 54;
            produtos_lavanda.Text = "        Produtos";
            produtos_lavanda.SelectedIndexChanged += produtos_lavanda_SelectedIndexChanged;
            // 
            // Quemsomos_lavanda
            // 
            Quemsomos_lavanda.AutoSize = true;
            Quemsomos_lavanda.BackColor = SystemColors.ButtonHighlight;
            Quemsomos_lavanda.Cursor = Cursors.Hand;
            Quemsomos_lavanda.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quemsomos_lavanda.Location = new Point(222, 78);
            Quemsomos_lavanda.Name = "Quemsomos_lavanda";
            Quemsomos_lavanda.Size = new Size(65, 26);
            Quemsomos_lavanda.TabIndex = 53;
            Quemsomos_lavanda.Text = "Home";
            Quemsomos_lavanda.Click += Quemsomos_lavanda_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.LOGOGRIMPI;
            pictureBox2.Location = new Point(0, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // splitter3
            // 
            splitter3.BorderStyle = BorderStyle.Fixed3D;
            splitter3.Dock = DockStyle.Top;
            splitter3.Enabled = false;
            splitter3.Location = new Point(0, 62);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1010, 48);
            splitter3.TabIndex = 51;
            splitter3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(126, 217, 87);
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(368, 37);
            label8.Name = "label8";
            label8.Size = new Size(258, 20);
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
            splitter2.Size = new Size(1010, 28);
            splitter2.TabIndex = 49;
            splitter2.TabStop = false;
            // 
            // btnclose_lavanda
            // 
            btnclose_lavanda.BackColor = SystemColors.ButtonHighlight;
            btnclose_lavanda.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose_lavanda.Location = new Point(978, 0);
            btnclose_lavanda.Name = "btnclose_lavanda";
            btnclose_lavanda.Size = new Size(32, 34);
            btnclose_lavanda.TabIndex = 48;
            btnclose_lavanda.Text = "X";
            btnclose_lavanda.UseVisualStyleBackColor = false;
            btnclose_lavanda.Click += btnclose_lavanda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 47;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buy_lavanda150);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(104, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 366);
            panel1.TabIndex = 62;
            // 
            // buy_lavanda150
            // 
            buy_lavanda150.BackColor = Color.FromArgb(126, 217, 87);
            buy_lavanda150.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buy_lavanda150.ForeColor = SystemColors.ButtonFace;
            buy_lavanda150.Location = new Point(42, 294);
            buy_lavanda150.Name = "buy_lavanda150";
            buy_lavanda150.Size = new Size(139, 35);
            buy_lavanda150.TabIndex = 34;
            buy_lavanda150.Text = "COMPRAR";
            buy_lavanda150.UseVisualStyleBackColor = false;
            buy_lavanda150.Click += buy_lavanda150_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.CausesValidation = false;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 251);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 35;
            label7.Text = "R$ 22,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.CausesValidation = false;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 218);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 34;
            label6.Text = "Lavanda 150g";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buy_lavanda300);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(377, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 366);
            panel2.TabIndex = 63;
            // 
            // buy_lavanda300
            // 
            buy_lavanda300.BackColor = Color.FromArgb(126, 217, 87);
            buy_lavanda300.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buy_lavanda300.ForeColor = SystemColors.ButtonFace;
            buy_lavanda300.Location = new Point(42, 294);
            buy_lavanda300.Name = "buy_lavanda300";
            buy_lavanda300.Size = new Size(139, 35);
            buy_lavanda300.TabIndex = 34;
            buy_lavanda300.Text = "COMPRAR";
            buy_lavanda300.UseVisualStyleBackColor = false;
            buy_lavanda300.Click += buy_lavanda300_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.CausesValidation = false;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(64, 251);
            label9.Name = "label9";
            label9.Size = new Size(96, 28);
            label9.TabIndex = 35;
            label9.Text = "R$ 44,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.CausesValidation = false;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(51, 218);
            label10.Name = "label10";
            label10.Size = new Size(121, 22);
            label10.TabIndex = 34;
            label10.Text = "Lavanda 300g";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(177, 186);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(buy_lavanda600);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(652, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 366);
            panel3.TabIndex = 63;
            // 
            // buy_lavanda600
            // 
            buy_lavanda600.BackColor = Color.FromArgb(126, 217, 87);
            buy_lavanda600.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buy_lavanda600.ForeColor = SystemColors.ButtonFace;
            buy_lavanda600.Location = new Point(42, 294);
            buy_lavanda600.Name = "buy_lavanda600";
            buy_lavanda600.Size = new Size(139, 35);
            buy_lavanda600.TabIndex = 34;
            buy_lavanda600.Text = "COMPRAR";
            buy_lavanda600.UseVisualStyleBackColor = false;
            buy_lavanda600.Click += buy_lavanda600_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.CausesValidation = false;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(64, 251);
            label11.Name = "label11";
            label11.Size = new Size(96, 28);
            label11.TabIndex = 35;
            label11.Text = "R$ 88,00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.CausesValidation = false;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(51, 218);
            label12.Name = "label12";
            label12.Size = new Size(121, 22);
            label12.TabIndex = 34;
            label12.Text = "Lavanda 600g";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(25, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(177, 186);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(126, 217, 87);
            label13.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(302, 710);
            label13.Name = "label13";
            label13.Size = new Size(401, 20);
            label13.TabIndex = 65;
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
            splitter4.TabIndex = 64;
            splitter4.TabStop = false;
            // 
            // LavandaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 739);
            Controls.Add(label13);
            Controls.Add(splitter4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(carrinho_Lavanda);
            Controls.Add(logout_Lavanda);
            Controls.Add(label2);
            Controls.Add(conta_lavanda);
            Controls.Add(produtos_lavanda);
            Controls.Add(Quemsomos_lavanda);
            Controls.Add(pictureBox2);
            Controls.Add(splitter3);
            Controls.Add(label8);
            Controls.Add(splitter2);
            Controls.Add(btnclose_lavanda);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LavandaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavanda";
            ((System.ComponentModel.ISupportInitialize)carrinho_Lavanda).EndInit();
            ((System.ComponentModel.ISupportInitialize)conta_lavanda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private PictureBox carrinho_Lavanda;
        private Label logout_Lavanda;
        private Label label2;
        private PictureBox conta_lavanda;
        private ComboBox produtos_lavanda;
        private Label Quemsomos_lavanda;
        private PictureBox pictureBox2;
        private Splitter splitter3;
        private Label label8;
        private Splitter splitter2;
        private Button btnclose_lavanda;
        private Label label1;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Panel panel1;
        private Button buy_lavanda150;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button buy_lavanda300;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button buy_lavanda600;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox5;
        private Label label13;
        private Splitter splitter4;
    }
}