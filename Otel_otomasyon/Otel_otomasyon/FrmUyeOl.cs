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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_otomasyon
{
    public partial class FrmUyeOl : Form
    {
        public FrmUyeOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");
        private void btnok_Click(object sender, EventArgs e)
        {
            if (tc.Text.Trim().Length != 11)
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz!");
                tc.Focus();
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

            if (string.IsNullOrWhiteSpace(sifre.Text) || sifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır!");
                sifre.Focus(); 
                return;
            }

            if (string.IsNullOrWhiteSpace(mail.Text) || !Valid_mail(mail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!");
                mail.Focus();
                return;
            }

            if (DateTime.Now.Year - doğum.Value.Year < 18)
            {
                MessageBox.Show("Üyelik oluşturabilmek için yaşınız en az 18 olmalı!");
                doğum.Focus();
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
            
            try
            {
                baglanti.InfoMessage += Baglanti_InfoMessage;
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                
                SqlCommand uyeol = new SqlCommand("IF (NOT EXISTS (SELECT 1 FROM Uyeler WHERE E_mail = @p4 )) BEGIN \r\n\t INSERT INTO Uyeler(Tc_No, Isim, Soyisim, E_mail, Sifre, Dogum_Tarihi, Cinsiyet, Telefon) VALUES(@p1,@p2,@p3,@p4,@p5,CONVERT(DATE,@p6,104),@p7,@p8) \r\n END \r\nELSE \r\nBEGIN\r\n\tRAISERROR('Bu mail adresine bağlı bir üyelik bulunmaktadır!',16,1)\r\nEND", baglanti);
                uyeol.Parameters.AddWithValue("@p1", tc.Text);
                uyeol.Parameters.AddWithValue("@p2", ad.Text);
                uyeol.Parameters.AddWithValue("@p3", soyad.Text);
                uyeol.Parameters.AddWithValue("@p4", mail.Text);
                uyeol.Parameters.AddWithValue("@p5", sifre.Text);
                uyeol.Parameters.AddWithValue("@p6", doğum.Value);
                if (erkek.Checked == true) { uyeol.Parameters.AddWithValue("@p7", true); }
                else if (kadın.Checked == true) { uyeol.Parameters.AddWithValue("@p7", false); }
                uyeol.Parameters.AddWithValue("@p8", tel.Text);            

                uyeol.ExecuteNonQuery();

                MessageBox.Show("Üyelik başarıyla oluşturuldu.");
                this.Hide();
                UyeEkrani uyekran = new UyeEkrani(mail.Text);
                uyekran.ShowDialog();
                this.Close();

                // Formun temizlenmesi
                tc.Text = string.Empty;
                ad.Text = string.Empty;
                soyad.Text = string.Empty;
                mail.Text = string.Empty;
                doğum.Value = DateTime.Now;
                kadın.Checked = false;
                erkek.Checked = false;
                tel.Text = string.Empty;
                sifre.Text = string.Empty;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            
        }

        private void goster_CheckedChanged(object sender, EventArgs e)
        {
            if (goster.Checked) { sifre.UseSystemPasswordChar = false; }
            else { sifre.UseSystemPasswordChar= true; }
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show($"{e.Message}","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public bool Valid_mail(string email)
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
