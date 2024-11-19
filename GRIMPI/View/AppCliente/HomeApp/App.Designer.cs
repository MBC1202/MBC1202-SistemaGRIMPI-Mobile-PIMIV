namespace Sistema.View.AppCliente
{
    partial class App
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
            components = new System.ComponentModel.Container();
            splitter1 = new Splitter();
            btnclosehome = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            splitter2 = new Splitter();
            label8 = new Label();
            splitter3 = new Splitter();
            pictureBox2 = new PictureBox();
            Quemsomos_home = new Label();
            produtos_home = new ComboBox();
            conta_home = new PictureBox();
            label2 = new Label();
            logout_home = new Label();
            carrinho_home = new PictureBox();
            picbCarrossel = new PictureBox();
            splitter4 = new Splitter();
            label4 = new Label();
            timeCarrossel = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conta_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carrinho_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbCarrossel).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Enabled = false;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1010, 34);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // btnclosehome
            // 
            btnclosehome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclosehome.Location = new Point(978, 0);
            btnclosehome.Name = "btnclosehome";
            btnclosehome.Size = new Size(32, 34);
            btnclosehome.TabIndex = 2;
            btnclosehome.Text = "X";
            btnclosehome.UseVisualStyleBackColor = true;
            btnclosehome.Click += btnclosehome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 6;
            label1.Text = "GRIMPI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(126, 217, 87);
            splitter2.Dock = DockStyle.Top;
            splitter2.Enabled = false;
            splitter2.Location = new Point(0, 34);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1010, 35);
            splitter2.TabIndex = 11;
            splitter2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(126, 217, 87);
            label8.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(320, 37);
            label8.Name = "label8";
            label8.Size = new Size(330, 26);
            label8.TabIndex = 16;
            label8.Text = "Onde a natureza encontra a cidade";
            // 
            // splitter3
            // 
            splitter3.BorderStyle = BorderStyle.Fixed3D;
            splitter3.Dock = DockStyle.Top;
            splitter3.Enabled = false;
            splitter3.Location = new Point(0, 69);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1010, 46);
            splitter3.TabIndex = 17;
            splitter3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.LOGOGRIMPI;
            pictureBox2.Location = new Point(0, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Quemsomos_home
            // 
            Quemsomos_home.AutoSize = true;
            Quemsomos_home.BackColor = SystemColors.ButtonHighlight;
            Quemsomos_home.Cursor = Cursors.Hand;
            Quemsomos_home.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quemsomos_home.Location = new Point(101, 77);
            Quemsomos_home.Name = "Quemsomos_home";
            Quemsomos_home.Size = new Size(226, 26);
            Quemsomos_home.TabIndex = 19;
            Quemsomos_home.Text = "Quem somos e Contatos";
            Quemsomos_home.Click += Quemsomos_home_Click;
            // 
            // produtos_home
            // 
            produtos_home.Cursor = Cursors.Hand;
            produtos_home.FormattingEnabled = true;
            produtos_home.Items.AddRange(new object[] { "Alecrim", "Cebolinha", "Coentro", "Hortelã", "Lavanda", "Orégano" });
            produtos_home.Location = new Point(410, 77);
            produtos_home.Name = "produtos_home";
            produtos_home.Size = new Size(137, 28);
            produtos_home.TabIndex = 21;
            produtos_home.Text = "        Produtos";
            produtos_home.SelectedIndexChanged += produtos_home_SelectedIndexChanged;
            // 
            // conta_home
            // 
            conta_home.Cursor = Cursors.Hand;
            conta_home.Image = Properties.Resources.user__1_;
            conta_home.Location = new Point(670, 72);
            conta_home.Name = "conta_home";
            conta_home.Size = new Size(39, 34);
            conta_home.SizeMode = PictureBoxSizeMode.StretchImage;
            conta_home.TabIndex = 22;
            conta_home.TabStop = false;
            conta_home.Click += conta_home_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(715, 72);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 23;
            label2.Text = "Sua conta";
            // 
            // logout_home
            // 
            logout_home.AutoSize = true;
            logout_home.Cursor = Cursors.Hand;
            logout_home.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_home.Location = new Point(733, 89);
            logout_home.Name = "logout_home";
            logout_home.Size = new Size(35, 20);
            logout_home.TabIndex = 24;
            logout_home.Text = "Sair";
            logout_home.Click += logout_home_Click;
            // 
            // carrinho_home
            // 
            carrinho_home.Cursor = Cursors.Hand;
            carrinho_home.Image = Properties.Resources.shopping_cart;
            carrinho_home.Location = new Point(840, 71);
            carrinho_home.Name = "carrinho_home";
            carrinho_home.Size = new Size(39, 34);
            carrinho_home.SizeMode = PictureBoxSizeMode.StretchImage;
            carrinho_home.TabIndex = 25;
            carrinho_home.TabStop = false;
            carrinho_home.Click += carrinho_home_Click;
            // 
            // picbCarrossel
            // 
            picbCarrossel.Image = Properties.Resources.Post_Instagram_Banho_para_Limpeza_e_Proteção_Verde__1_;
            picbCarrossel.Location = new Point(138, 142);
            picbCarrossel.Name = "picbCarrossel";
            picbCarrossel.Size = new Size(714, 506);
            picbCarrossel.SizeMode = PictureBoxSizeMode.StretchImage;
            picbCarrossel.TabIndex = 26;
            picbCarrossel.TabStop = false;
            // 
            // splitter4
            // 
            splitter4.BackColor = Color.FromArgb(126, 217, 87);
            splitter4.Dock = DockStyle.Bottom;
            splitter4.Enabled = false;
            splitter4.Location = new Point(0, 706);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(1010, 33);
            splitter4.TabIndex = 27;
            splitter4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(126, 217, 87);
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(308, 710);
            label4.Name = "label4";
            label4.Size = new Size(401, 20);
            label4.TabIndex = 28;
            label4.Text = "Compre agora e leve a essência da natureza para casa!";
            // 
            // timeCarrossel
            // 
            timeCarrossel.Interval = 3000;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(885, 84);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 29;
            label3.Text = "Carrinho";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1010, 739);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(splitter4);
            Controls.Add(picbCarrossel);
            Controls.Add(carrinho_home);
            Controls.Add(logout_home);
            Controls.Add(label2);
            Controls.Add(conta_home);
            Controls.Add(produtos_home);
            Controls.Add(Quemsomos_home);
            Controls.Add(pictureBox2);
            Controls.Add(splitter3);
            Controls.Add(label8);
            Controls.Add(splitter2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnclosehome);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += App_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)conta_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)carrinho_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbCarrossel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private Button btnclosehome;
        private Label label1;
        private PictureBox pictureBox1;
        private Splitter splitter2;
        private Label label8;
        private Splitter splitter3;
        private PictureBox pictureBox2;
        private Label Quemsomos_home;
        private ComboBox produtos_home;
        private PictureBox conta_home;
        private Label label2;
        private Label logout_home;
        private PictureBox carrinho_home;
        private PictureBox picbCarrossel;
        private Splitter splitter4;
        private Label label4;
        private System.Windows.Forms.Timer timeCarrossel;
        private Label label3;
    }
}