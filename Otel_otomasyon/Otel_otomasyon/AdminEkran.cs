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
    public partial class AdminEkran : Form
    {
        public AdminEkran()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");

        private void AdminEkran_Load(object sender, EventArgs e)
        {
            // butonlara tıklanınca aynı işlem yapılacağı için tıklama eylemini fonksiyona atıyor
            btnoda1.Click += Button_Click;
            btnoda2.Click += Button_Click;
            btnoda3.Click += Button_Click;
            btnoda4.Click += Button_Click;
            btnoda5.Click += Button_Click;
            btnoda6.Click += Button_Click;
            btnoda7.Click += Button_Click;
            Veri_guncelle();
            
        }
        public void Veri_guncelle()
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            

            for (int i = 1; i <= 7; i++)
            {
                SqlCommand kmt2 = new SqlCommand("SELECT dbo.BUTONRENK(@p1)", baglanti);
                kmt2.Parameters.AddWithValue("@p1", i);
                SqlDataReader dr2 = kmt2.ExecuteReader();
                while (dr2.Read())
                {
                    Button btnoda = this.Controls["btnoda" + i] as Button;
                    
                    if (dr2[0].ToString() == "0")
                    {
                        btnoda.BackColor = Color.Yellow;
                    }
                    else if (dr2[0].ToString() == "1")
                    {
                        btnoda.BackColor = Color.Green;
                    }
                    else
                    {
                        btnoda.BackColor = Color.Red;
                        //btnoda.Enabled = false;
                    }
                    if (btnoda.BackColor == Color.Green)
                    {
                        
                        btnoda.Enabled = false;
                    }
                }
                dr2.Close();
                // 30 güne kadar herhangi bir randevu varsa oda butonunun altında gösterir
                SqlCommand kmt1 = new SqlCommand("SELECT dbo.ENYAKINREZ(@p1)", baglanti);
                kmt1.Parameters.AddWithValue("@p1", i);
                SqlDataReader dr1 = kmt1.ExecuteReader();
                while (dr1.Read())
                {
                    Label lblOda = this.Controls["lbloda" + i] as Label;
                    Button bo = this.Controls["btnoda" + i] as Button;
                    if(bo.BackColor == Color.Green)
                    {
                        if (dr1[0].ToString() == "0")
                        {
                            lblOda.Text = $"Bir sonraki rezervasyon \nBUGÜN.";

                            bo.Enabled = true;
                        }
                        else if (dr1[0].ToString() == "31")
                        {
                            lblOda.Text = string.Empty;
                        }
                        else
                        {
                            lblOda.Text = $"Bir sonraki rezervasyona\r\n{dr1[0]} gün var.";
                        }
                    }
                    else if (bo.BackColor == Color.Red)
                    {
                        lblOda.Text = string.Empty;
                    }
                    else { lblOda.Text = "Odaya kişi bekleniyor."; }
                    
                }
                dr1.Close();

            }

           

            // combo box ile filtrelemeye göre ayrı tablo getir
            if (comboBox1.SelectedIndex == 1)
            {
                
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT Oda_No, Isim, Soyisim, IIF(Cinsiyet=1,'Erkek','Kadın') AS Cinsiyet, Giris_Tarihi " +
                    "FROM Musteri " +
                    "WHERE Aktif = 1 AND Giris_Tarihi IS NOT NULL " +
                    "ORDER BY Oda_No", baglanti);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgeski.DataSource = dt2;
            }
            else if (comboBox1.SelectedIndex == 0) 
            {
                comboBox1.SelectedIndex = 0;
                SqlDataAdapter da1 =
                new SqlDataAdapter("SELECT Rez_Id AS Rez_No,Rez_baslangic AS Başlangıç,Rez_bitis AS Bitiş,Oda_No,Kisi_Sayisi AS Kişi " +
                "FROM Rezervasyonlar " +
                "WHERE MONTH(Rez_baslangic) = MONTH(GETDATE())", baglanti);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgeski.DataSource = dt1;

            }
            baglanti.Close();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            
            if (tiklanan.BackColor == Color.Red)
            {
                Check_out check_Out = new Check_out(tiklanan.Text.Split(' ')[1]);
                this.Hide();
                check_Out.ShowDialog();
                this.Veri_guncelle();
                this.Show();
                
            }
            else if (tiklanan.BackColor == Color.Yellow || tiklanan.BackColor == Color.Green)
            {
                Check_in check_İn = new Check_in(tiklanan.Text.Split(' ')[1], eyatak.Text, kisi.Text);
                this.Hide();
                check_İn.ShowDialog();
                this.Veri_guncelle();
                this.btnTemizle_Click(null, null);
                this.Show();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // arama butonunun aktif pasifliği
            if (string.IsNullOrWhiteSpace(eyatak.Text) || string.IsNullOrWhiteSpace(kisi.Text))
            {
                MessageBox.Show("Lütfen Arama butonuna basmadan önce kişi ve ek yatak alanlarını doldurun.");
                kisi.Focus();
                return;
            }
            comboBox1.Text = "Oda Bilgi";
            comboBox1.Enabled = false;
            baglanti.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT Oda_No,Kat,Gecelik_Ucret FROM Odalar WHERE Oda_No IN (SELECT ODANO FROM dbo.MUSAITODA(@P1,GETDATE(),DEFAULT,@P2) )", baglanti);
            da3.SelectCommand.Parameters.AddWithValue("@P1", kisi.Text);
            da3.SelectCommand.Parameters.AddWithValue("@P2", eyatak.Text);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgeski.DataSource = dt3;
            for (int i = 1; i <= 7; i++)
            {
                Button dugme = this.Controls["btnoda" + i] as Button;
                dugme.Enabled = false;
                foreach (DataGridViewRow dr in dgeski.Rows)
                {                    
                    if (Convert.ToInt16(dugme.Text.Split(' ')[1]) == Convert.ToInt16(dr.Cells["Oda_No"].Value) && dugme.BackColor==Color.Green)
                    {
                        dugme.Enabled = true;
                       
                    }
                }
            }
            baglanti.Close();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // alanlar temizleniyor ve veriler tekrardan çekiliyor
            eyatak.Text = string.Empty;
            kisi.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox1.Enabled = true;
            btnoda1.Enabled = true;
            btnoda2.Enabled = true;
            btnoda3.Enabled = true;
            btnoda4.Enabled = true;
            btnoda5.Enabled = true;
            btnoda6.Enabled = true;
            btnoda7.Enabled = true;
            dgeski.DataSource = null;

            Veri_guncelle();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_out check_Out = new Check_out(null);
            this.Hide();
            check_Out.ShowDialog();
            this.Veri_guncelle();
            this.Show();
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_in ci = new Check_in(null, null, null);
            this.Hide();
            ci.ShowDialog();
            this.Veri_guncelle();
            this.Show();
        }
    }
}
