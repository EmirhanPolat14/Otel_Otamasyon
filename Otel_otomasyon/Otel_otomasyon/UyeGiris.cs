using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Otel_otomasyon
{
    public partial class UyeGiris : Form
    {
        public UyeGiris()
        {
            InitializeComponent();
        }

        private void goster_CheckedChanged(object sender, EventArgs e)
        {
            if (goster.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //alanların kontrolü
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !Valid_mail(textBox1.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Length < 8)
            {
                MessageBox.Show("Şifreniz en az 8 karakterden oluşmalıdır!");
                textBox2.Focus();
                return;
            }
            
            try
            {
                baglanti.InfoMessage += Baglanti_InfoMessage;
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                
                SqlCommand kmt = new SqlCommand("SELECT 1 FROM Uyeler WHERE E_mail = @p1 AND Sifre=@p2" , baglanti);
                kmt.Parameters.AddWithValue("@p1", textBox1.Text);
                kmt.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    UyeEkrani uyekran = new UyeEkrani(textBox1.Text);
                    uyekran.ShowDialog();
                    this.Show();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    goster.Checked = false;
                }
                else if (textBox1.Text == "admin@admin" && textBox2.Text == "admin123")
                {
                    this.Hide();
                    AdminEkran adminekran = new AdminEkran();
                    adminekran.ShowDialog();
                    this.Show();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    goster.Checked = false;
                }
                else
                {
                    MessageBox.Show("Hatalı şifre veya kullanıcı adı!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show($"{e.Message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Valid_mail(string email)
        {
            try
            {
                MailAddress nm = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
