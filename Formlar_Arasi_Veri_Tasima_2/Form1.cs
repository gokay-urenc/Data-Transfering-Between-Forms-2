using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arasi_Veri_Tasima_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogrenci[] ogrenciler;
        private void diziyiolusturButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int eleman_sayisi = Convert.ToInt32(mevcutText.Text);
                ogrenciler = new Ogrenci[eleman_sayisi];
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                MessageBox.Show("Mevcut belirlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ogrSiraNo = 0;
        private void diziyiolusturButton2_Click(object sender, EventArgs e)
        {
            if (ogrSiraNo == ogrenciler.Length)
            {
                MessageBox.Show("Kontenjan dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Ogrenci ogr = new Ogrenci();
            ogr.adi = adText.Text;
            ogr.soyadi = soyadText.Text;
            ogr.vize = Convert.ToSingle(vizeText.Text);
            ogr.final = Convert.ToSingle(finalText.Text);
            ogrenciler[ogrSiraNo] = ogr;
            ogrSiraNo++;
            Temizle();
        }

        void Temizle()
        {
            adText.Clear();
            soyadText.Clear();
            vizeText.Clear();
            finalText.Clear();
        }

        private void ogrencilerigosterButton_Click(object sender, EventArgs e)
        {
            if (ogrenciler == null)
            {
                MessageBox.Show("Gösterilecek öğrenci yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Form2 kayitlar = new Form2();
            kayitlar.listelenecek_ogrenciler = ogrenciler;
            kayitlar.ShowDialog(); 
        } 
    }
}
// Show() ile ShowDialog() arasındaki fark; üst üste tekrar form 2 nin açılmasını             engellemesidir. Yani form2 açıkken form1'e erişim sağlanmaz. Sadece gözükür.