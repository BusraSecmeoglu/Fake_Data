using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahteVeri.Gruplar;

namespace SahteVeriUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdresUretim a = new AdresUretim();
        IsimUretim i = new IsimUretim();
        SayiUretim s = new SayiUretim();
        TarihUretim t = new TarihUretim();
        List<SahteVeriler> sv = new List<SahteVeriler>();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sv;

            for (int k = 0; k < 100; k++)
            {
                SahteVeriler sht = new SahteVeriler();
                sht.Ad = i.IsimGonder();
                sht.Soyad = i.SoyisimGonder();
                sht.RastgeleSayi = s.RastgeleSayi(500, 300);
                sht.Tarih = t.DTarihi();
                sht.Ulke = a.UlkeGonder();
                sht.Sehir = a.SehirGonder(sht.Ulke);
                sv.Add(sht);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
