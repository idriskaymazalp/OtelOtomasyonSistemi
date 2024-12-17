using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonSistemi
{
    public partial class FormRezervasyon : Form
    {
        public FormRezervasyon()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");
        int secilenSatirOdaId;
        int secilenSatirOdaNo;
        decimal secilenSatirOdaUcreti;
        string secilenSatirOdaTuru;
        bool RoomIsFull = false;
        DateTime OdaGiris;
        DateTime OdaCıkıs;

        private void GetirTumOdalar()
        {
            //1. adim tum odalari getirmek Ok.
            SqlCommand query = new SqlCommand("SELECT * FROM TableOda", connection);
            SorguCalistir(query);

            //2.adim Oda durumu adinda yeni bir kolon olustur Ok.
            dataGridViewOdalar.Columns.Add("OdaDurumu", "OdaDurumu");
            dataGridViewOdalar.Columns["OdaDurumu"].ValueType = typeof(string);

            //3.adim bu kolonu odanin durumunu kontrol edip dolu veya bos olarak doldur.
            for (int i = 0; i < dataGridViewOdalar.Rows.Count - 1; i++)
            {
                int odaID = Convert.ToInt32(dataGridViewOdalar.Rows[i].Cells["OdaID"].Value);

                string sonuc = OdaDurumunuKontrolEt(odaID);

                dataGridViewOdalar.Rows[i].Cells["OdaDurumu"].Value = sonuc;
            }
        }

        private string OdaDurumunuKontrolEt(int OdaId)
        {
            SqlCommand q = new SqlCommand("SELECT * FROM TableOda [to] INNER JOIN TableKonaklama tk ON [to].OdaID = tk.Oda " +
                            "WHERE (tk.MisafirGirisTarihi >= @CheckinDate and tk.MisafirGirisTarihi <= @CheckoutDate or " +
                            "tk.MisafirCıkısTarihi >= @CheckinDate and tk.MisafirCıkısTarihi <= @CheckoutDate) and [to].OdaID = @OdaID;", connection);

            q.Parameters.AddWithValue("@CheckinDate", dateTimePickerGiris.Value.Date);
            q.Parameters.AddWithValue("@CheckoutDate", dateTimePickerCıkıs.Value.Date);
            q.Parameters.AddWithValue("@OdaID", OdaId);

            SqlDataAdapter da = new SqlDataAdapter(q);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return "Dolu";
            else
                return "Bos";
        }

        private void GetirDoluOdalar()
        {
            SqlCommand q = new SqlCommand("SELECT OdaID,OdaTuru,OdaNumarasi,OdaUcreti FROM TableOda [to] INNER JOIN TableKonaklama tk ON [to].OdaID = tk.Oda " +
                "WHERE tk.MisafirGirisTarihi >= @CheckinDate and tk.MisafirGirisTarihi <= @CheckoutDate or " +
                "tk.MisafirCıkısTarihi >= @CheckinDate and tk.MisafirCıkısTarihi <= @CheckoutDate;", connection);

            q.Parameters.AddWithValue("@CheckinDate", dateTimePickerGiris.Value.Date);
            q.Parameters.AddWithValue("@CheckoutDate", dateTimePickerCıkıs.Value.Date);

            SorguCalistir(query: q);
        }
        private void GetirBosOdalar()
        {
            SqlCommand q = new SqlCommand("SELECT * FROM TableOda [to] WHERE[to].OdaID not in " +
                "(SELECT [to].OdaID FROM TableOda [to] INNER JOIN TableKonaklama tk ON [to].OdaID = tk.Oda " +
                "WHERE tk.MisafirGirisTarihi >= @CheckinDate and tk.MisafirGirisTarihi <= @CheckoutDate or" +
                " tk.MisafirCıkısTarihi >= @CheckinDate and tk.MisafirCıkısTarihi <= @CheckoutDate);", connection);

            q.Parameters.AddWithValue("@CheckinDate", dateTimePickerGiris.Value.Date);
            q.Parameters.AddWithValue("@CheckoutDate", dateTimePickerCıkıs.Value.Date);

            SorguCalistir(query: q);
        }

        private void SorguCalistir(SqlCommand query)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewOdalar.DataSource = dt;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void buttonFıltrele_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewOdalar.Columns.Contains("OdaDurumu"))
                dataGridViewOdalar.Columns.Remove("OdaDurumu");
            if (comboBoxOdalar.SelectedItem != null)
            {
                string secim = comboBoxOdalar.SelectedItem.ToString();
                if (secim == "Hepsi")
                {
                    GetirTumOdalar();
                }
                else if (secim == "Boş Odalar")
                {
                    GetirBosOdalar();
                }
                else if (secim == "Dolu Odalar")
                {
                    GetirDoluOdalar();
                }
            }

            else
            {
                MessageBox.Show("Lütfen devam etmek istediğiniz oda durumunu seçiniz!");
            }
        }

        private void dataGridViewOdalar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridViewOdalar.SelectedCells[0].RowIndex;
            secilenSatirOdaId = Convert.ToInt32(dataGridViewOdalar.Rows[secilenSatır].Cells[0].Value);
            secilenSatirOdaNo = Convert.ToInt32(dataGridViewOdalar.Rows[secilenSatır].Cells[2].Value);
            secilenSatirOdaTuru = (string)dataGridViewOdalar.Rows[secilenSatır].Cells[1].Value;
            secilenSatirOdaUcreti = Convert.ToInt32(dataGridViewOdalar.Rows[secilenSatır].Cells[3].Value);

            string secim = comboBoxOdalar.SelectedItem.ToString();
            if (secim == "Hepsi")
                RoomIsFull = (string)dataGridViewOdalar.Rows[secilenSatır].Cells["OdaDurumu"].Value == "Dolu";
        }


        private void buttonDevam_Click_1(object sender, EventArgs e)
        {
            FormOdemeEkranı formOdemeEkranı = new FormOdemeEkranı();
            formOdemeEkranı.OdaID = secilenSatirOdaId;
            formOdemeEkranı.OdaNo = secilenSatirOdaNo;
            formOdemeEkranı.OdaTuru = secilenSatirOdaTuru;
            formOdemeEkranı.OdaUcreti = secilenSatirOdaUcreti;
            formOdemeEkranı.OdaGiris = dateTimePickerGiris.Value.Date;
            formOdemeEkranı.OdaCıkıs = dateTimePickerCıkıs.Value.Date;

            if (comboBoxOdalar.SelectedItem != null)
            {
                string secim = comboBoxOdalar.SelectedItem.ToString();
                if (secim == "Dolu Odalar")
                {
                    MessageBox.Show("Seçtiğiniz oda dolu olduğu için devam edilememektedir! Lütfen boş bir oda seçiniz.");
                }
                else if (secim == "Hepsi")
                {
                    if (RoomIsFull)
                        MessageBox.Show("Seçtiğiniz oda dolu olduğu için devam edilememektedir! Lütfen boş bir oda seçiniz.");
                }
                else
                {
                    this.Hide();
                    formOdemeEkranı.Show();
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
