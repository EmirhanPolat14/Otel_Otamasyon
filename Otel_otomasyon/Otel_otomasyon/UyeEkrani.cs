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
using System.Data.Common;

namespace Otel_otomasyon
{
    public partial class UyeEkrani : Form
    {
        private string mail;

        public UyeEkrani(string Email)
        {
            mail = Email;
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-L63PR14S\\MSSQLSERVER1;Initial Catalog=Otel;Integrated Security=True");

        private void UyeEkrani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            // giriş erkan yazısı
            SqlCommand kmt1 = new SqlCommand("SELECT Isim, Soyisim FROM Uyeler WHERE E_mail = @p1", baglanti);
            kmt1.Parameters.AddWithValue("@p1", mail);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                label1.Text = $"Hoşgeldiniz {dr1[0]} {dr1[1]},";
            }
            dr1.Close();

            // geçmiş rezervasyonları gösterme
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT M.Isim AS AD, M.Soyisim AS SOYAD ,R.Rez_baslangic AS [Başlangıç Tarihi], " +
                "R.Rez_bitis AS [Bitiş Tarihi], M.Oda_No AS [Kalınan Oda], " +
                "DATEDIFF(DAY, M.Giris_Tarihi, M.Cikis_Tarihi) AS [Kalınan Gün],O.TUTAR AS [Ödenen Ücret]  " +
                "FROM Rezervasyonlar R " +
                "JOIN Musteri M ON M.Musterı_Id = R.Musterı_Id " +
                "JOIN Uyeler U ON U.Tc_No = M.Tc_No " +
                "JOIN ODEMELER O ON O.MUSTERI_ID = M.Musterı_Id " +
                "WHERE M.E_mail = @P1 " +
                "ORDER BY M.Musterı_Id DESC", baglanti);
            da1.SelectCommand.Parameters.AddWithValue("@P1", mail);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgeski.DataSource = dt1;

            gbgecmis.Width = dgeski.Width;
            gbgecmis.Height = dgeski.Height;


            
            // Rezervasyon groupbox doldurma
            FrmRez frmRez = new FrmRez
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None, // Kenarlık kaldırılır
                Dock = DockStyle.Fill                  // Alanı tamamen doldurur
               
            };
            frmRez.BackColor = Color.White;
            gbrezyap.Controls.Clear();
            gbrezyap.Controls.Add(frmRez);
            frmRez.Show();

            SqlCommand kmt2 = new SqlCommand("SELECT [Tc_No], [Isim], [Soyisim], " +
                " [Dogum_Tarihi], [Cinsiyet], [Telefon] " +
                "FROM Uyeler WHERE E_mail = @p1", baglanti);
            kmt2.Parameters.AddWithValue("@p1", mail);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            if (frmRez.i == 1)
            {
                while (dr2.Read())
                {
                    frmRez.tc.Text = dr2[0].ToString();
                    frmRez.ad.Text = dr2[1].ToString();
                    frmRez.soyad.Text = dr2[2].ToString();
                    frmRez.doğum.Text = dr2[3].ToString();
                    if (dr2[4].ToString() == "1") { frmRez.erkek.Checked = true; }
                    else if (dr2[4].ToString() == "0") { frmRez.kadın.Checked = true; }
                    frmRez.tel.Text = dr2[5].ToString();
                    frmRez.mail.Text = mail;

                }
                
            }
            dr2.Close();
            

            baglanti.Close();


            


            
        }

    }
}
