namespace OtelOtomasyonSistemi
{
    partial class FormAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaEkran));
            buttonMisafir = new Button();
            buttonKonaklama = new Button();
            buttonRezervasyon = new Button();
            panel1 = new Panel();
            panelLogo = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            labelTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonMisafir
            // 
            buttonMisafir.FlatAppearance.BorderSize = 0;
            buttonMisafir.FlatStyle = FlatStyle.Flat;
            buttonMisafir.ForeColor = Color.Gainsboro;
            buttonMisafir.Image = (Image)resources.GetObject("buttonMisafir.Image");
            buttonMisafir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMisafir.Location = new Point(0, 148);
            buttonMisafir.Name = "buttonMisafir";
            buttonMisafir.Padding = new Padding(12, 0, 0, 0);
            buttonMisafir.Size = new Size(258, 60);
            buttonMisafir.TabIndex = 9;
            buttonMisafir.Text = "   Misafirler";
            buttonMisafir.TextAlign = ContentAlignment.MiddleLeft;
            buttonMisafir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMisafir.UseVisualStyleBackColor = true;
            buttonMisafir.Click += buttonMisafir_Click;
            // 
            // buttonKonaklama
            // 
            buttonKonaklama.FlatAppearance.BorderSize = 0;
            buttonKonaklama.FlatStyle = FlatStyle.Flat;
            buttonKonaklama.ForeColor = Color.Gainsboro;
            buttonKonaklama.Image = (Image)resources.GetObject("buttonKonaklama.Image");
            buttonKonaklama.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKonaklama.Location = new Point(0, 214);
            buttonKonaklama.Name = "buttonKonaklama";
            buttonKonaklama.Padding = new Padding(12, 0, 0, 0);
            buttonKonaklama.Size = new Size(258, 60);
            buttonKonaklama.TabIndex = 10;
            buttonKonaklama.Text = "   Konaklamalar";
            buttonKonaklama.TextAlign = ContentAlignment.MiddleLeft;
            buttonKonaklama.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonKonaklama.UseVisualStyleBackColor = true;
            buttonKonaklama.Click += buttonKonaklama_Click;
            // 
            // buttonRezervasyon
            // 
            buttonRezervasyon.FlatAppearance.BorderSize = 0;
            buttonRezervasyon.FlatStyle = FlatStyle.Flat;
            buttonRezervasyon.ForeColor = Color.Gainsboro;
            buttonRezervasyon.Image = (Image)resources.GetObject("buttonRezervasyon.Image");
            buttonRezervasyon.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRezervasyon.Location = new Point(0, 82);
            buttonRezervasyon.Name = "buttonRezervasyon";
            buttonRezervasyon.Padding = new Padding(12, 0, 0, 0);
            buttonRezervasyon.Size = new Size(258, 60);
            buttonRezervasyon.TabIndex = 11;
            buttonRezervasyon.Text = "   Rezervasyon";
            buttonRezervasyon.TextAlign = ContentAlignment.MiddleLeft;
            buttonRezervasyon.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRezervasyon.UseVisualStyleBackColor = true;
            buttonRezervasyon.Click += buttonRezervasyon_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 40);
            panel1.Controls.Add(panelLogo);
            panel1.Controls.Add(buttonKonaklama);
            panel1.Controls.Add(buttonRezervasyon);
            panel1.Controls.Add(buttonMisafir);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 581);
            panel1.TabIndex = 12;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 0, 30);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(258, 85);
            panelLogo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(53, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 14;
            label1.Text = "4 Season Hotel ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(labelTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(258, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 85);
            panel2.TabIndex = 13;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Maiandra GD", 16F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(281, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(150, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ANASAYFA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 276);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 581);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormAnaEkran";
            Text = "AnaEkran";
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonMisafir;
        private Button buttonKonaklama;
        private Button buttonRezervasyon;
        private Panel panel1;
        private Panel panelLogo;
        private Panel panel2;
        private Label labelTitle;
        private Label label1;
        private PictureBox pictureBox1;
    }
}