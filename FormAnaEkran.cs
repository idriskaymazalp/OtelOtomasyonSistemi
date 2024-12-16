using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OtelOtomasyonSistemi
{
    public partial class FormAnaEkran : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");


        public FormAnaEkran()
        {
            InitializeComponent();
        }


        private void buttonMisafir_Click(object sender, EventArgs e)
        {
            FormMisafir formMisafir = new FormMisafir();
            formMisafir.Show();
        }

        private void buttonKonaklama_Click(object sender, EventArgs e)
        {
            FormKonaklama formKonaklama = new FormKonaklama();
            formKonaklama.Show();
        }

        private void buttonRezervasyon_Click(object sender, EventArgs e)
        {
            FormRezervasyon formRezervasyon = new FormRezervasyon();
            formRezervasyon.Show();
        }
    }
}
