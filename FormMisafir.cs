using System;
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
    public partial class FormMisafir : Form
    {
        public FormMisafir()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");
        private void buttonFıltrele_Click(object sender, EventArgs e)
        {
            filtrelemeSonuclarınıGoster();
        }
        private void filtrelemeSonuclarınıGoster()
        {
            try
            {

                string q = "SELECT * FROM TableMisafir WHERE MisafirAdi LIKE '" + textBoxMisafirAd.Text + "%' "
                                                                               + " AND MisafirSoyadi LIKE '" + textBoxMisafirSoyad.Text + "%' "
                                                                               + " AND TelefonNo LIKE '" + textBoxTelefonNu.Text + "%' "
                                                                               + " AND EmailAdress LIKE '" + textBoxEmaill.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridMisafirler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TableMisafir (MisafirAdi, MisafirSoyadi, TelefonNo, EmailAdress)" +
                    " output INSERTED.MisafirID Values (@P1, @P2, @P3, @P4)", connection);

                cmd.Parameters.AddWithValue("@P1", textBoxMisafirAd.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxMisafirSoyad.Text);
                cmd.Parameters.AddWithValue("@P3", textBoxTelefonNu.Text);
                cmd.Parameters.AddWithValue("@P4", textBoxEmaill.Text);

                labelMisafirID.Text = cmd.ExecuteScalar().ToString();

                MessageBox.Show("Misafir Basariyla eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu!", hata.Message);
            }
            finally { connection.Close(); }

            filtrelemeSonuclarınıGoster();
        }

        private void buttonGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableMisafir SET " +
                    "MisafirAdi='" + textBoxMisafirAd.Text + "', " +
                    "MisafirSoyadi='" + textBoxMisafirSoyad.Text + "', " +
                    "TelefonNo='" + textBoxTelefonNu.Text + "', " +
                    "EmailAdress='" + textBoxEmaill.Text + "'" +
                    "WHERE MisafirID = @Id", connection);

                sqlCommand.Parameters.AddWithValue("@Id", labelMisafirID.Text);

                sqlCommand.ExecuteNonQuery();
                Temizle();
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

        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableMisafir WHERE MisafirID = @P1", connection);
                sqlCommand.Parameters.AddWithValue("@P1", labelMisafirID.Text);

                sqlCommand.ExecuteNonQuery();
                Temizle();
                filtrelemeSonuclarınıGoster();

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
            labelMisafirID.Text = "";
            textBoxMisafirAd.Text = "";
            textBoxMisafirSoyad.Text = "";
            textBoxTelefonNu.Text = "";
            textBoxEmaill.Text = "";
        }

        private void dataGridMisafirler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridMisafirler.SelectedCells[0].RowIndex;
            labelMisafirID.Text = dataGridMisafirler.Rows[secilenSatır].Cells[0].Value.ToString();
            textBoxMisafirAd.Text = dataGridMisafirler.Rows[secilenSatır].Cells[1].Value.ToString();
            textBoxMisafirSoyad.Text = dataGridMisafirler.Rows[secilenSatır].Cells[2].Value.ToString();
            textBoxTelefonNu.Text = dataGridMisafirler.Rows[secilenSatır].Cells[3].Value.ToString();
            textBoxEmaill.Text = dataGridMisafirler.Rows[secilenSatır].Cells[4].Value.ToString();
        }
    }
}
