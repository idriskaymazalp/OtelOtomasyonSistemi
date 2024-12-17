namespace OtelOtomasyonSistemi
{
    partial class FormMisafir
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
            dataGridMisafirler = new DataGridView();
            textBoxEmaill = new TextBox();
            textBoxTelefonNu = new TextBox();
            labelMisafirID = new Label();
            textBoxMisafirSoyad = new TextBox();
            textBoxMisafirAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonFıltrele = new Button();
            buttonEkle = new Button();
            buttonGuncelle = new Button();
            buttonSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridMisafirler).BeginInit();
            SuspendLayout();
            // 
            // dataGridMisafirler
            // 
            dataGridMisafirler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMisafirler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMisafirler.Location = new Point(1, 261);
            dataGridMisafirler.Name = "dataGridMisafirler";
            dataGridMisafirler.RowHeadersWidth = 51;
            dataGridMisafirler.Size = new Size(798, 188);
            dataGridMisafirler.TabIndex = 0;
            dataGridMisafirler.CellClick += dataGridMisafirler_CellClick;
            // 
            // textBoxEmaill
            // 
            textBoxEmaill.Location = new Point(187, 164);
            textBoxEmaill.Name = "textBoxEmaill";
            textBoxEmaill.Size = new Size(205, 27);
            textBoxEmaill.TabIndex = 28;
            // 
            // textBoxTelefonNu
            // 
            textBoxTelefonNu.Location = new Point(187, 131);
            textBoxTelefonNu.Name = "textBoxTelefonNu";
            textBoxTelefonNu.Size = new Size(205, 27);
            textBoxTelefonNu.TabIndex = 27;
            // 
            // labelMisafirID
            // 
            labelMisafirID.AutoSize = true;
            labelMisafirID.ForeColor = SystemColors.ControlText;
            labelMisafirID.Location = new Point(187, 36);
            labelMisafirID.Name = "labelMisafirID";
            labelMisafirID.Size = new Size(21, 20);
            labelMisafirID.TabIndex = 19;
            labelMisafirID.Text = "--";
            // 
            // textBoxMisafirSoyad
            // 
            textBoxMisafirSoyad.Location = new Point(187, 98);
            textBoxMisafirSoyad.Name = "textBoxMisafirSoyad";
            textBoxMisafirSoyad.Size = new Size(205, 27);
            textBoxMisafirSoyad.TabIndex = 26;
            // 
            // textBoxMisafirAd
            // 
            textBoxMisafirAd.Location = new Point(187, 66);
            textBoxMisafirAd.Name = "textBoxMisafirAd";
            textBoxMisafirAd.Size = new Size(205, 27);
            textBoxMisafirAd.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(42, 171);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 24;
            label5.Text = "E mail Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(42, 138);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 23;
            label4.Text = "Telefon No ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(42, 101);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 22;
            label3.Text = "Konuk Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 21;
            label2.Text = "Konuk Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(42, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 20;
            label1.Text = "Konuk ID";
            // 
            // buttonFıltrele
            // 
            buttonFıltrele.ForeColor = SystemColors.ControlText;
            buttonFıltrele.Location = new Point(187, 208);
            buttonFıltrele.Name = "buttonFıltrele";
            buttonFıltrele.Size = new Size(94, 29);
            buttonFıltrele.TabIndex = 29;
            buttonFıltrele.Text = "Filtrele";
            buttonFıltrele.UseVisualStyleBackColor = true;
            buttonFıltrele.Click += buttonFıltrele_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.ForeColor = SystemColors.ControlText;
            buttonEkle.Location = new Point(298, 208);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(94, 29);
            buttonEkle.TabIndex = 30;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click_1;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.ForeColor = SystemColors.ControlText;
            buttonGuncelle.Location = new Point(409, 208);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(94, 29);
            buttonGuncelle.TabIndex = 31;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click_1;
            // 
            // buttonSil
            // 
            buttonSil.ForeColor = SystemColors.ControlText;
            buttonSil.Location = new Point(520, 208);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 29);
            buttonSil.TabIndex = 32;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click_1;
            // 
            // FormMisafir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSil);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonEkle);
            Controls.Add(buttonFıltrele);
            Controls.Add(textBoxEmaill);
            Controls.Add(textBoxTelefonNu);
            Controls.Add(labelMisafirID);
            Controls.Add(textBoxMisafirSoyad);
            Controls.Add(textBoxMisafirAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridMisafirler);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMisafir";
            Text = "Konuk";
            ((System.ComponentModel.ISupportInitialize)dataGridMisafirler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridMisafirler;
        private TextBox textBoxEmaill;
        private TextBox textBoxTelefonNu;
        private Label labelMisafirID;
        private TextBox textBoxMisafirSoyad;
        private TextBox textBoxMisafirAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonFıltrele;
        private Button buttonEkle;
        private Button buttonGuncelle;
        private Button buttonSil;
    }
}