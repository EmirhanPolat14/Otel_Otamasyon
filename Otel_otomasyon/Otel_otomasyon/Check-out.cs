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

namespace Otel_otomasyon
{
    public partial class Check_out : Form
    {
        private string odano;
        public Check_out(string Odano)
        {
            odano = Odano;
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");


        private void Check_out_Load(object sender, EventArgs e)
        {
            if (odano != null)
            {
                oda.Text = odano;
                oda.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.InfoMessage += Baglanti_InfoMessage;
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("CHECK_OUT", baglanti)
                {
                    CommandType = CommandType.StoredProcedure
                };
                kmt.Parameters.AddWithValue("@ODA_NO", oda.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Çıkış işlemi başarıyla gerçekleşti!");
                this.Close();
            }
            catch(Exception sqlEx)
            {
                MessageBox.Show("Hata: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { baglanti.Close(); }
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // SQL Server'dan gelen mesajları al ve işle
            MessageBox.Show($"{e.Message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
