using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_otomasyon
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRez rez = new FrmRez();
            this.Hide();
            rez.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUyeOl uye = new FrmUyeOl();
            this.Hide();
            uye.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeGiris giris = new UyeGiris();
            this.Hide();
            giris.ShowDialog();
            this.Show();
        }
    }
}
