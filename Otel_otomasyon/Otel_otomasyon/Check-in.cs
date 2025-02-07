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
using System.Net.Mail;

namespace Otel_otomasyon
{
    public partial class Check_in : Form
    {
        private string odano;
        private string ekyatak;
        private string kisi;
        public Check_in(string Odano, string Ekyatak,string Kisi)
        {
            odano = Odano;
            ekyatak = Ekyatak;
            kisi = Kisi;
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (rezno.Text == string.Empty)
            {
                if (string.IsNullOrWhiteSpace(mail.Text) || !Valid_mail(mail.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!");
                    mail.Focus();
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(ad.Text) || ad.Text.Length > 50 || ad.Text.Length < 2)
                {
                    MessageBox.Show("İsminiz 2 karakterden kısa veya 50 karakterden uzun olamaz!");
                    ad.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(soyad.Text) || ad.Text.Length > 50 || soyad.Text.Length < 2)
                {
                    MessageBox.Show("Soyadınız 2 karakterden kısa veya 50 karakterden uzun olamaz!");
                    soyad.Focus();
                    return;
                }


                if (erkek.Checked == false && kadın.Checked == false)
                {
                    MessageBox.Show("Lütfen cinsiyet seçimi yapınız.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tel.Text) || tel.Text.Trim().Length != 14)
                {
                    MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz!");
                    return;
                }
            }
            if (tc.Text.Trim().Length != 11)
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz!");
                tc.Focus();
                return;
            }

            baglanti.Open();
            try
            {
                SqlCommand kmt1 = new SqlCommand("CHECK_IN", baglanti)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (!string.IsNullOrEmpty(rezno.Text))
                {
                    kmt1.Parameters.AddWithValue("@REZ_ID", rezno.Text);
                }
                kmt1.Parameters.AddWithValue("@ISIM", ad.Text);
                kmt1.Parameters.AddWithValue("@SOYISIM", soyad.Text);
                kmt1.Parameters.AddWithValue("@TCNO", tc.Text);
                if (kadın.Checked == true) { kmt1.Parameters.AddWithValue("@CINSIYET", false); }
                else { kmt1.Parameters.AddWithValue("@CINSIYET", true); }
                kmt1.Parameters.AddWithValue("@TELEFON", tel.Text);
                kmt1.Parameters.AddWithValue("@MAIL", mail.Text);
                kmt1.Parameters.AddWithValue("@ODA_NO", odano);
                if (!string.IsNullOrEmpty(ekyatak))
                {
                    kmt1.Parameters.AddWithValue("@EK_YATAK", ekyatak);
                }
                if (!string.IsNullOrEmpty(kisi))
                {
                    kmt1.Parameters.AddWithValue("@KISI", kisi);
                }
                kmt1.Parameters.AddWithValue("@DOGUM_TARIH", doğum.Value);
                kmt1.ExecuteNonQuery();
                kisi = null;
                MessageBox.Show("Kayıt başarıyla yapıldı!");
                ad.Text = string.Empty;
                soyad.Text = string.Empty;
                tc.Text = string.Empty;
                erkek.Checked = false;
                kadın.Checked = false;
                tel.Text = string.Empty;
                mail.Text = string.Empty;
                doğum.Value = DateTime.Now;
                this.Close();
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

        private void rezno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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

        private void ad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void soyad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
