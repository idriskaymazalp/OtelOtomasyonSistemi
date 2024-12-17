namespace OtelOtomasyonSistemi
{
    partial class FormKonaklama
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
            buttonKaydet = new Button();
            buttonFıltrele = new Button();
            textBoxEmailAdres = new TextBox();
            textBoxTelefonNO = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridKonaklama = new DataGridView();
            label6 = new Label();
            textBoxOdaNO = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePickerGırıs = new DateTimePicker();
            dateTimePickerCıkıs = new DateTimePicker();
            buttonTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridKonaklama).BeginInit();
            SuspendLayout();
            // 
            // buttonKaydet
            // 
            buttonKaydet.ForeColor = SystemColors.ControlText;
            buttonKaydet.Location = new Point(870, 456);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(94, 29);
            buttonKaydet.TabIndex = 46;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // buttonFıltrele
            // 
            buttonFıltrele.ForeColor = SystemColors.ControlText;
            buttonFıltrele.Location = new Point(169, 227);
            buttonFıltrele.Name = "buttonFıltrele";
            buttonFıltrele.Size = new Size(94, 29);
            buttonFıltrele.TabIndex = 43;
            buttonFıltrele.Text = "Filtrele";
            buttonFıltrele.UseVisualStyleBackColor = true;
            buttonFıltrele.Click += buttonFıltrele_Click;
            // 
            // textBoxEmailAdres
            // 
            textBoxEmailAdres.Location = new Point(169, 154);
            textBoxEmailAdres.Name = "textBoxEmailAdres";
            textBoxEmailAdres.Size = new Size(227, 27);
            textBoxEmailAdres.TabIndex = 42;
            // 
            // textBoxTelefonNO
            // 
            textBoxTelefonNO.Location = new Point(169, 121);
            textBoxTelefonNO.Name = "textBoxTelefonNO";
            textBoxTelefonNO.Size = new Size(227, 27);
            textBoxTelefonNO.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(24, 161);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 38;
            label5.Text = "E mail Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(24, 128);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 37;
            label4.Text = "Telefon No ";
            // 
            // dataGridKonaklama
            // 
            dataGridKonaklama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKonaklama.Location = new Point(1, 262);
            dataGridKonaklama.Name = "dataGridKonaklama";
            dataGridKonaklama.RowHeadersWidth = 51;
            dataGridKonaklama.Size = new Size(972, 188);
            dataGridKonaklama.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(24, 194);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 48;
            label6.Text = "Oda No ";
            // 
            // textBoxOdaNO
            // 
            textBoxOdaNO.Location = new Point(169, 187);
            textBoxOdaNO.Name = "textBoxOdaNO";
            textBoxOdaNO.Size = new Size(227, 27);
            textBoxOdaNO.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(24, 57);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 50;
            label7.Text = "Konuk Giriş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(24, 90);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 51;
            label8.Text = "Konuk Çıkış Tarihi";
            // 
            // dateTimePickerGırıs
            // 
            dateTimePickerGırıs.Location = new Point(169, 52);
            dateTimePickerGırıs.Name = "dateTimePickerGırıs";
            dateTimePickerGırıs.Size = new Size(227, 27);
            dateTimePickerGırıs.TabIndex = 52;
            dateTimePickerGırıs.ValueChanged += dateTimePickerGırıs_ValueChanged;
            // 
            // dateTimePickerCıkıs
            // 
            dateTimePickerCıkıs.Location = new Point(169, 85);
            dateTimePickerCıkıs.Name = "dateTimePickerCıkıs";
            dateTimePickerCıkıs.Size = new Size(227, 27);
            dateTimePickerCıkıs.TabIndex = 53;
            dateTimePickerCıkıs.ValueChanged += dateTimePickerCıkıs_ValueChanged;
            // 
            // buttonTemizle
            // 
            buttonTemizle.ForeColor = SystemColors.ControlText;
            buttonTemizle.Location = new Point(302, 227);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(94, 29);
            buttonTemizle.TabIndex = 54;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // FormKonaklama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(976, 489);
            Controls.Add(buttonTemizle);
            Controls.Add(dateTimePickerCıkıs);
            Controls.Add(dateTimePickerGırıs);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxOdaNO);
            Controls.Add(label6);
            Controls.Add(dataGridKonaklama);
            Controls.Add(buttonKaydet);
            Controls.Add(buttonFıltrele);
            Controls.Add(textBoxEmailAdres);
            Controls.Add(textBoxTelefonNO);
            Controls.Add(label5);
            Controls.Add(label4);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormKonaklama";
            Text = "Konaklama";
            ((System.ComponentModel.ISupportInitialize)dataGridKonaklama).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKaydet;
        private Button buttonFıltrele;
        private TextBox textBoxEmailAdres;
        private TextBox textBoxTelefonNO;
        private Label label5;
        private Label label4;
        private DataGridView dataGridKonaklama;
        private Label label6;
        private TextBox textBoxOdaNO;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePickerGırıs;
        private DateTimePicker dateTimePickerCıkıs;
        private Button buttonTemizle;
    }
}