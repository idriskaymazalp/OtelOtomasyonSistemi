namespace OtelOtomasyonSistemi
{
    partial class FormRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyon));
            buttonDevam = new Button();
            label2 = new Label();
            comboBoxOdalar = new ComboBox();
            label1 = new Label();
            dateTimePickerCıkıs = new DateTimePicker();
            dateTimePickerGiris = new DateTimePicker();
            buttonFıltrele = new Button();
            label3 = new Label();
            dataGridViewOdalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdalar).BeginInit();
            SuspendLayout();
            // 
            // buttonDevam
            // 
            buttonDevam.ForeColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(buttonDevam, "buttonDevam");
            buttonDevam.Name = "buttonDevam";
            buttonDevam.UseVisualStyleBackColor = true;
            buttonDevam.Click += buttonDevam_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.Control;
            label2.Name = "label2";
            // 
            // comboBoxOdalar
            // 
            comboBoxOdalar.FormattingEnabled = true;
            comboBoxOdalar.Items.AddRange(new object[] { resources.GetString("comboBoxOdalar.Items"), resources.GetString("comboBoxOdalar.Items1"), resources.GetString("comboBoxOdalar.Items2") });
            resources.ApplyResources(comboBoxOdalar, "comboBoxOdalar");
            comboBoxOdalar.Name = "comboBoxOdalar";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // dateTimePickerCıkıs
            // 
            resources.ApplyResources(dateTimePickerCıkıs, "dateTimePickerCıkıs");
            dateTimePickerCıkıs.Name = "dateTimePickerCıkıs";
            // 
            // dateTimePickerGiris
            // 
            resources.ApplyResources(dateTimePickerGiris, "dateTimePickerGiris");
            dateTimePickerGiris.Name = "dateTimePickerGiris";
            // 
            // buttonFıltrele
            // 
            buttonFıltrele.ForeColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(buttonFıltrele, "buttonFıltrele");
            buttonFıltrele.Name = "buttonFıltrele";
            buttonFıltrele.UseVisualStyleBackColor = true;
            buttonFıltrele.Click += buttonFıltrele_Click_1;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.Control;
            label3.Name = "label3";
            // 
            // dataGridViewOdalar
            // 
            dataGridViewOdalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewOdalar, "dataGridViewOdalar");
            dataGridViewOdalar.Name = "dataGridViewOdalar";
            dataGridViewOdalar.CellClick += dataGridViewOdalar_CellClick_1;
            // 
            // FormRezervasyon
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(dataGridViewOdalar);
            Controls.Add(label3);
            Controls.Add(buttonDevam);
            Controls.Add(label2);
            Controls.Add(comboBoxOdalar);
            Controls.Add(label1);
            Controls.Add(dateTimePickerCıkıs);
            Controls.Add(dateTimePickerGiris);
            Controls.Add(buttonFıltrele);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormRezervasyon";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDevam;
        private Label label2;
        private ComboBox comboBoxOdalar;
        private Label label1;
        private DateTimePicker dateTimePickerCıkıs;
        private DateTimePicker dateTimePickerGiris;
        private Button buttonFıltrele;
        private Label label3;
        private DataGridView dataGridViewOdalar;
        private DataGridViewTextBoxColumn Column1;
    }
}