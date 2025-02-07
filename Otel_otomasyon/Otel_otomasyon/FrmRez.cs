using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_otomasyon
{
    public partial class FrmRez : Form
    {
        private string isim = string.Empty;
        private string soyisim = string.Empty;
        private string tece = string.Empty;
        private string dtarih = string.Empty;
        private string cins = string.Empty;
        private string telefon = string.Empty;
        private string email = string.Empty;
        private int n = 1;
        public int i = 1;
        public FrmRez()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");

        public void FrmRez_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet1.Odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.otelDataSet1.Odalar);
            
            button1.Enabled = false;
        }
        
        private void btnara_Click(object sender, EventArgs e)
        {
            //alanların düzgün girilip girilmediğini denetleme
            if (string.IsNullOrWhiteSpace(kisi.Text))
            {
                MessageBox.Show("Kişi Sayısı girmek zorunludur.");
                kisi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(eyatak.Text))
            {
                eyatak.Text = "0";
            }
            if (baslangic.Value > bitis.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden daha erken olmalıdır!");
                baslangic.Focus();
                return;
            }

            // butona bir daha basarsa bir önceki listelenen odalar silinsin
            oda.Items.Clear();
            // boş odalaraın sp yardımıyla combobox'da gözükmesi
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM dbo.MUSAITODA(@p1,@p2,@p3,@p4)", baglanti);
            kmt.Parameters.AddWithValue("@p1", kisi.Text);
            kmt.Parameters.AddWithValue("@p2", baslangic.Value);
            kmt.Parameters.AddWithValue("@p3", bitis.Value);
            kmt.Parameters.AddWithValue("@p4", eyatak.Text);
            SqlDataReader dr1 = kmt.ExecuteReader();
            while (dr1.Read())
            {
                oda.Items.Add(dr1[0]);
            }
            baglanti.Close();
            button1.Enabled = true;
            n = Convert.ToInt16(kisi.Text);
            if (n > 1) { button1.Text = "Sonraki"; }
            else if (n == 1) { button1.Text = "Rezervasyon Yap"; }
            else { MessageBox.Show("Lütfen kişi sayısını doğru girin!"); }

            // data
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Odalar WHERE Oda_no IN(SELECT ODANO FROM DBO.MUSAITODA(@p1,@p2,@p3,@p4))", baglanti);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p1", kisi.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p2", baslangic.Value);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p3", bitis.Value);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p4", eyatak.Text);

            // DataTable oluşturulup, veriler alınıyor
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            // DataGridView'e DataTable'ı yollama
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //alanlara girilen değerlerin kontrolü
            if (string.IsNullOrWhiteSpace(oda.Text))
            {
                MessageBox.Show("Oda alanı boş bırakılamaz!");
                oda.Focus();
                return;
            }

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

            // sadece ilk kişinin email zorunlu ve sadece ilk yani rezervasyon kaydı yapacak kişi 18  yaştan büyük olmalı
            if ( i == 1  )
            {
                if (string.IsNullOrWhiteSpace(mail.Text) || !Valid_mail(mail.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin! " );

                    mail.Focus();
                    return;
                }
                 
            }
            else
            {
                if (string.IsNullOrWhiteSpace(mail.Text) == false && !Valid_mail(mail.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin! ");

                    mail.Focus();
                    return;
                }
            }


            if (DateTime.Now.Year - doğum.Value.Year < 18 && i == 1)
            {
                MessageBox.Show("Rezervasyon oluşturabilmek için yaşınız en az 18 olmalı!");
                doğum.Focus();
                return;
            }

            if (erkek.Checked == false && kadın.Checked == false)
            {
                MessageBox.Show("Lütfen cinsiyet seçimi yapınız.");
                return;
            }

            // yaş 18den küçükse zaten telefon olmayacaktır
            if ((string.IsNullOrWhiteSpace(tel.Text) || tel.Text.Trim().Length != 14) && DateTime.Now.Year - doğum.Value.Year > 18 )
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz!");
                return;
            }


            if (button1.Text == "Rezervasyon Yap")
            {
                isim += ad.Text + ",";
                soyisim += soyad.Text + ",";
                tece += tc.Text + ",";
                dtarih += doğum.Value + ",";
                telefon += tel.Text + ",";
                email += mail.Text + ",";

                if (erkek.Checked == true)
                {
                    cins += "1" + ",";
                }
                else if (kadın.Checked == true)
                {
                    cins += "0" + ",";
                }
                try
                {
                    
                    // sqlden aldığımız hataları ekleme
                    baglanti.InfoMessage += Baglanti_InfoMessage;
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    // sp için komut oluştur
                    SqlCommand rezsp = new SqlCommand("REZERVASYON", baglanti)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    // parametrelerin eklenmesi
                    rezsp.Parameters.AddWithValue("@ISIM", isim);
                    rezsp.Parameters.AddWithValue("@SOYISIM", soyisim);
                    rezsp.Parameters.AddWithValue("@TCNO", tece);
                    rezsp.Parameters.AddWithValue("@CINSIYET", cins);
                    rezsp.Parameters.AddWithValue("@TELEFON", telefon);
                    rezsp.Parameters.AddWithValue("@MAIL", email);
                    rezsp.Parameters.AddWithValue("@DOGUM_TARIH", dtarih);
                    rezsp.Parameters.AddWithValue("@ODA_NO", oda.Text);
                    rezsp.Parameters.AddWithValue("@BASLANGICTARIHI", baslangic.Value);
                    rezsp.Parameters.AddWithValue("@BITISTARIHI", bitis.Value);
                    rezsp.Parameters.AddWithValue("@KISI", kisi.Text);
                    rezsp.Parameters.AddWithValue("@EK_YATAK", eyatak.Text);
                    rezsp.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    // Konsola SQL hatasını yazdırıyoruz
                    MessageBox.Show("SQL Hatası: " + ex.Message);

                }
                finally
                {
                    baglanti.Close();
                    this.Close();
                }
            }
            else if (button1.Text == "Sonraki")
            {
                
                // önce tüm isimleri VS. toplayacak
                isim += ad.Text + ",";
                soyisim += soyad.Text + ",";
                tece += tc.Text + ",";
                dtarih += doğum.Value + ",";
                telefon += tel.Text + ",";
                email += mail.Text + ",";
                

                if (erkek.Checked == true)
                {
                    cins += "1" + ",";
                }
                else if (kadın.Checked == true)
                {
                    cins += "0" + ",";
                }

                if (i == n-1)
                {
                    // son kayıt yapılacağı zaman butonun text'i değiştirilir
                    // ve prosedür çalışmaya uygun hale gelmiş olur
                    button1.Text = "Rezervasyon Yap";
                }

                i++;
                
                if (i > 1)
                {
                    // ilk kayıttan sonra tekrardan alınması gerkmeyen alanlara erişim kısıtlanır
                    kisi.Enabled = false;
                    baslangic.Enabled = false;
                    bitis.Enabled = false;
                    oda.Enabled = false;
                    eyatak.Enabled = false;
                    btnara.Enabled = false;
                    // ilk kayıttan sonra giriş yapılan alanlar temizlenir
                    tc.Text = string.Empty;
                    ad.Text = string.Empty;
                    soyad.Text = string.Empty;
                    doğum.Value = DateTime.Today;
                    tel.Text = string.Empty;
                    mail.Text = string.Empty;
                    kadın.Checked = false;
                    erkek.Checked = false;
                    
                }
            }
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // SQL Server'dan gelen mesajları al ve işle
            MessageBox.Show($"{e.Message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eyatak_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eyatak.Text))
            {
                eyatak.Text = 0.ToString();
            }
        }

        private void kisi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kisi.Text))
            {
                MessageBox.Show("Kişi Sayısı girmek zorunludur.");
                e.Cancel = true;
            }
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
  

