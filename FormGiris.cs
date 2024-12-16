using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace OtelOtomasyonSistemi
{
    public partial class FormGiris : Form
    {
        FormAnaEkran FormAnaEkran;

        public static int PersonelId;

        public FormGiris()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=OtelOtomasyonDB;Integrated Security=True");

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxKullac�Ad�.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullac� Ad� veya �ifre hatal�d�r.");
                return;
            }

            try
            {
                string sifre = "";
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT PersonelID, Sifre FROM TablePersonel WHERE Kullan�c�Adi = @P1", connection);
                cmd.Parameters.AddWithValue("@P1", textBoxKullac�Ad�.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sifre = reader[1].ToString();
                    PersonelId = Convert.ToInt32(reader[0]);
                }
                if (sifre == textBoxSifre.Text)
                {
                    FormAnaEkran = new FormAnaEkran();
                    this.Hide();
                    FormAnaEkran.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� Ad� veya �ifre hatal�d�r.");
                    textBoxKullac�Ad�.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Ba�lant� Hatas� !", hata.Message);
            }
            finally { connection.Close(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
