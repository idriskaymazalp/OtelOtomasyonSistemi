using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OtelOtomasyonSistemi
{
    public partial class FormKonaklama : Form
    {
        private bool IncludeDatesToFilter;

        public FormKonaklama()
        {
            InitializeComponent();
            AramaFiltreleme();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");
        SqlCommandBuilder sqlCommandBuilder;
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        private void buttonFıltrele_Click(object sender, EventArgs e)
        {
            AramaFiltreleme();
        }

        private void AramaFiltreleme()
        {
            string mainQuery = "SELECT KonaklamaID, KullanıcıAdi AS 'Personel', MisafirAdi + ' ' + MisafirSoyadi AS 'Misafir', OdaNumarasi, MisafirGirisTarihi, MisafirCıkısTarihi, TotalUcret FROM TableKonaklama " +
                "INNER JOIN TableMisafir " +
                "ON TableKonaklama.Misafir = TableMisafir.MisafirID " +
                "INNER JOIN TablePersonel " +
                "ON TableKonaklama.Personel = TablePersonel.PersonelID " +
                "INNER JOIN TableOda " +
                "ON TableKonaklama.Oda = TableOda.OdaID";

            string whereQuery = "";

            if (textBoxTelefonNO.Text != "")
            {
                whereQuery = " WHERE  TelefonNo LIKE @P1 ";
            }

            if (textBoxEmailAdres.Text != "")
            {
                if (whereQuery == "")
                    whereQuery += " WHERE EmailAdress LIKE @P2 ";
                else
                    whereQuery += " AND EmailAdress LIKE @P2 ";
            }

            int p3Value = 0;
            if (textBoxOdaNO.Text != "")
            {
                p3Value = Convert.ToInt32(textBoxOdaNO.Text);
                if (whereQuery == "")
                    whereQuery += " WHERE OdaNumarasi = @P3 ";
                else
                    whereQuery += " AND OdaNumarasi = @P3 ";
            }


            if (IncludeDatesToFilter == true)
            {
                if (whereQuery == "")
                    whereQuery += " WHERE MisafirGirisTarihi between @P4 and @P5 and " +
                                         "MisafirCıkısTarihi between @P4 and @P5; ";
                else
                    whereQuery += " AND MisafirGirisTarihi between @P4 and @P5 and " +
                                       "MisafirCıkısTarihi between @P4 and @P5; ";
            }

            mainQuery += whereQuery;

            SqlCommand cmd = new SqlCommand(mainQuery, connection);
            cmd.Parameters.AddWithValue("@P1", textBoxTelefonNO.Text + "%");
            cmd.Parameters.AddWithValue("@P2", textBoxEmailAdres.Text);
            cmd.Parameters.AddWithValue("@P3", p3Value);
            cmd.Parameters.AddWithValue("@P4", dateTimePickerGırıs.Value);
            cmd.Parameters.AddWithValue("@P5", dateTimePickerCıkıs.Value);



            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridKonaklama.DataSource = dt;
            }
            else
            {
                dataGridKonaklama.DataSource = null;
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(table);
            AramaFiltreleme();
        }

        private void dateTimePickerGırıs_ValueChanged(object sender, EventArgs e)
        {
            IncludeDatesToFilter = true;
        }

        private void dateTimePickerCıkıs_ValueChanged(object sender, EventArgs e)
        {
            IncludeDatesToFilter = true;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxTelefonNO.Text = "";
            textBoxEmailAdres.Text = "";
            textBoxOdaNO.Text = "";

            if (IncludeDatesToFilter == true)
            {
                IncludeDatesToFilter = false;
                dateTimePickerGırıs.Value = DateTime.Now;
                dateTimePickerCıkıs.Value = DateTime.Now;
            }
            AramaFiltreleme();
        }
    }
}
