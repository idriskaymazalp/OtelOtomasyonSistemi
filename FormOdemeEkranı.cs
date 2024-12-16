using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonSistemi
{
    public partial class FormOdemeEkranı : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");
        public FormOdemeEkranı()
        {
            InitializeComponent();
        }

        public int OdaID { get; set; }
        public int OdaNo { get; set; }
        public decimal OdaUcreti { get; set; }
        public string OdaTuru { get; set; }
        public DateTime OdaGiris { get; set; }
        public DateTime OdaCıkıs { get; set; }

        private void FormOdemeEkranı_Load(object sender, EventArgs e)
        {
            textBoxOdaID.Text = OdaID.ToString();
            textBoxOdaNo.Text = OdaNo.ToString();
            textBoxOdaTuru.Text = OdaTuru.ToString();
            textBoxOdaUcreti.Text = OdaUcreti.ToString();
            dateTimePickerChekin.Value = OdaGiris.Date;
            dateTimePickerCheckout.Value = OdaCıkıs.Date;

        }

        private void MisafirVerileri()
        {
            try
            {
                string q = "SELECT KonaklamaID,MisafirID,MisafirAdi,MisafirSoyadi,TelefonNo,EmailAdress " +
                    "FROM TableKonaklama INNER JOIN TableMisafir" +
                    " ON TableKonaklama.Misafir = TableMisafir.MisafirID";
                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKonaklama.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonMisafirEkle_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TableMisafir (MisafirAdi, MisafirSoyadi, TelefonNo, EmailAdress)" +
                    " output INSERTED.MisafirID Values (@P1, @P2, @P3, @P4)", connection);

                cmd.Parameters.AddWithValue("@P1", textBoxMisafirAdı.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxMisafirSoyadı.Text);
                cmd.Parameters.AddWithValue("@P3", textBoxTelefonNo.Text);
                cmd.Parameters.AddWithValue("@P4", textBoxEmail.Text);

                labelMisafirID.Text = cmd.ExecuteScalar().ToString();

                MessageBox.Show("Misafir Basariyla eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu!", hata.Message);
            }
            finally { connection.Close(); }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (textBoxMisafirAdı.Text == "" && textBoxMisafirSoyadı.Text =="" && textBoxTelefonNo.Text == "" && textBoxEmail.Text == "")
            {

            }
            else
            {
                aramaSonuclarınıGoster();
            }
        }
        private void aramaSonuclarınıGoster()
        {
            try
            {

                string q = "SELECT * FROM TableMisafir WHERE MisafirAdi LIKE '" + textBoxMisafirAdı.Text + "%' "
                                                                               + " AND MisafirSoyadi LIKE '" + textBoxMisafirSoyadı.Text + "%' "
                                                                               + " AND TelefonNo LIKE '" + textBoxTelefonNo.Text + "%' "
                                                                               + " AND EmailAdress LIKE '" + textBoxEmail.Text + "%' ";
                                                                               
                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKonaklama.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonMisafirBilgileriGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableMisafir SET " +
                    "MisafirAdi='" + textBoxMisafirAdı.Text + "', " +
                    "MisafirSoyadi='" + textBoxMisafirSoyadı.Text + "', " +
                    "TelefonNo='" + textBoxTelefonNo.Text + "', " +
                    "EmailAdress='" + textBoxEmail.Text + "'" +
                    "WHERE MisafirID = @Id", connection);

                sqlCommand.Parameters.AddWithValue("@Id", labelMisafirID.Text);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Misafir bilgileri güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Misafir bilgileri güncellenirken hata oluştu!" + ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonMisafirSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableMisafir WHERE MisafirID = @P1", connection);
                sqlCommand.Parameters.AddWithValue("@P1", labelMisafirID.Text);

                sqlCommand.ExecuteNonQuery();
                Temizle();

                MessageBox.Show("Kayıtlı misafir bilgileri silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt silme işlemi sırasında hata oluştu!" + ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }
        private void Temizle()
        {
            textBoxMisafirAdı.Text = "";
            textBoxMisafirSoyadı.Text = "";
            textBoxTelefonNo.Text = "";
            textBoxEmail.Text = "";
        }

        private void CalculateTotalAmount()
        {
            int toplamTutar = CalculateAmountsForDays();

            if (checkBoxHavuz.Checked)
            {
                toplamTutar += 500;
            }
            if (checkBoxSauna.Checked)
            {
                toplamTutar += 250;
            }
            if (checkBoxSpaMerkezi.Checked)
            {
                toplamTutar += 1000;
            }
            if (checkBoxGeziTurları.Checked)
            {
                toplamTutar += 2000;
            }
            labelToplamUcret.Text = toplamTutar.ToString();
        }

        private int CalculateAmountsForDays()
        {
            DateTime giris = dateTimePickerChekin.Value.Date;
            DateTime cıkıs = dateTimePickerCheckout.Value.Date;
            int konaklamaSuresı = (int)(cıkıs - giris).TotalDays;
            int toplamTutar = (Convert.ToInt32(textBoxOdaUcreti.Text)) * konaklamaSuresı;
            return toplamTutar;
        }

        private void buttonOde_Click(object sender, EventArgs e)
        {


            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TableKonaklama (Personel, Misafir, Oda, MisafirGirisTarihi, MisafirCıkısTarihi, TotalUcret) " +
                    "Values (@P0, @P1, @P2, @P3, @P4, @P5)", connection);
                cmd.Parameters.AddWithValue("@P0", FormGiris.PersonelId);
                cmd.Parameters.AddWithValue("@P1", labelMisafirID.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxOdaID.Text);
                cmd.Parameters.AddWithValue("@P3", dateTimePickerChekin.Value.Date);
                cmd.Parameters.AddWithValue("@P4", dateTimePickerCheckout.Value.Date);
                cmd.Parameters.AddWithValue("@P5", labelToplamUcret.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ödeme işlemi başarıyla tamamlandı.");

                KonaklamaBılgılerı();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Ödemi işlemi sırasında bir hata oluştu.", hata.Message);
            }
            finally { connection.Close(); }

        }

        private void KonaklamaBılgılerı()
        {


            try
            {
                string q = "SELECT KonaklamaID, MisafirAdi, MisafirSoyadi, TelefonNo, EmailAdress, OdaTuru, OdaNumarasi, OdaUcreti, MisafirGirisTarihi, MisafirCıkısTarihi, TotalUcret " +
                "FROM TableKonaklama" +
                " INNER JOIN TableMisafir ON TableKonaklama.Misafir = TableMisafir.MisafirID INNER JOIN TableOda ON TableKonaklama.Oda = TableOda.OdaID" +
                " WHERE TableKonaklama.Oda = @P1 AND TableKonaklama.MisafirCıkısTarihi >= @P2" +
                " ORDER BY MisafirGirisTarihi asc";
                SqlCommand sqlCommand = new SqlCommand(q, connection);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxOdaID.Text);
                sqlCommand.Parameters.AddWithValue("@P2", DateTime.Now.Date);

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKonaklama.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePickerChekin_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void dateTimePickerCheckout_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void checkBoxHavuz_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void checkBoxSauna_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void checkBoxSpaMerkezi_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void checkBoxGeziTurları_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
    }
}
