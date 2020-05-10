using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formlar_Arasi_Veri_Tasima_2
{
    public class Ogrenci
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public float vize { get; set; }
        public float final { get; set; }
        public float ortalama
        {
            get
            {
                return vize * 0.3f + final * 0.7f;
            }
        }
    }
}
// Özellikleri ad, soyad, vize, final ortalama. Ortalama dışarıdan değiştirilmemelidir.       Sadece çağırıldığında kişinin vize ve final ortalamasını vermelidir. 
// Vize * 0.3f + final * 0.7f;