namespace OtelOtomasyonSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            label1 = new Label();
            label2 = new Label();
            textBoxKullacıAdı = new TextBox();
            textBoxSifre = new TextBox();
            label3 = new Label();
            buttonGiris = new Button();
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 113);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 170);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // textBoxKullacıAdı
            // 
            textBoxKullacıAdı.Location = new Point(75, 138);
            textBoxKullacıAdı.Name = "textBoxKullacıAdı";
            textBoxKullacıAdı.Size = new Size(259, 27);
            textBoxKullacıAdı.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(75, 195);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(259, 27);
            textBoxSifre.TabIndex = 3;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(181, 14);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 4;
            label3.Text = "Giriş";
            // 
            // buttonGiris
            // 
            buttonGiris.FlatAppearance.BorderColor = Color.White;
            buttonGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            buttonGiris.FlatStyle = FlatStyle.Flat;
            buttonGiris.ForeColor = Color.White;
            buttonGiris.Location = new Point(114, 268);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(180, 61);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 46);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 7;
            label4.Text = "4 Season Hotel";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(937, 0);
            button1.Name = "button1";
            button1.Size = new Size(48, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonGiris);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxKullacıAdı);
            panel2.Controls.Add(textBoxSifre);
            panel2.Location = new Point(277, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 435);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(138, 347);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(133, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Yeni Hesap Oluştur";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(146, 235);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(985, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGiris";
            ShowIcon = false;
            Text = "Otel Otomasyon Sistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKullacıAdı;
        private TextBox textBoxSifre;
        private Label label3;
        private Button buttonGiris;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private Panel panel2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
