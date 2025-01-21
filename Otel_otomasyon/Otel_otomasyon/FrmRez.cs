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
        private int n = 1;
        private int i = 1;
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
            //------------------------!!!!!!!!!!!!
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.MUSAITODA(@Filter)", baglanti);
            //dataAdapter.SelectCommand.Parameters.AddWithValue("@Filter", filter);  // Filter parametresi ekleniyor

            //// DataTable oluşturulup, veriler alınıyor
            //DataTable dt = new DataTable();
            //dataAdapter.Fill(dt);

            //// DataGridView'e DataTable'ı set etme
            //dataGridView1.DataSource = dt;

        }
                               
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Rezervasyon Yap")
            {
                isim += ad.Text + ",";
                soyisim += soyad.Text + ",";
                tece += tc.Text + ",";
                dtarih += doğum.Value + ",";
                telefon += tel.Text + ",";
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
                    rezsp.Parameters.AddWithValue("@TELEFON", telefon);
                    //rezsp.Parameters.AddWithValue("@DOGUM_TARIH", dtarih);
                    var dogumTarihiValues = string.Join(",", dtarih.Split(',')
                    .Where(d => DateTime.TryParse(d, out _)) // Sadece geçerli tarihleri alır
                    .Select(d => DateTime.Parse(d).ToString("yyyy-MM-dd")));
                    rezsp.Parameters.AddWithValue("@DOGUM_TARIH", dogumTarihiValues);
                    rezsp.Parameters.AddWithValue("@CINSIYET", cins);
                    rezsp.Parameters.AddWithValue("@MAIL", mail.Text);
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
                // önce tüm isimleri toplayacak
                isim += ad.Text + ",";
                soyisim += soyad.Text + ",";
                tece += tc.Text + ",";
                dtarih += doğum.Value + ",";
                telefon += tel.Text + ","; 

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

                MessageBox.Show(isim+soyisim+tece+dtarih+cins,telefon);
                i++;
                
                if (i > 1)
                {
                    // ilk kayıttan sonra tekrardan alınması gerkmeyen alanlara erişim kısıtlanır
                    kisi.Enabled = false;
                    baslangic.Enabled = false;
                    bitis.Enabled = false;
                    oda.Enabled = false;
                    mail.Enabled = false;
                    eyatak.Enabled = false;
                    btnara.Enabled = false;
                    // ilk kayıttan sonra giriş yapılan alanlar temizlenir
                    tc.Text = string.Empty;
                    ad.Text = string.Empty;
                    soyad.Text = string.Empty;
                    doğum.Value = DateTime.Today;
                }
            }
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // SQL Server'dan gelen mesajları al ve işle
            MessageBox.Show($"SQL Server Mesajı: {e.Message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
  

