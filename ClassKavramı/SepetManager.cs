using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramı
{
    internal class SepetManager
    {
        public void Ekle()
        {
            Console.WriteLine("Sepete eklendi.");
        }

        public void Cikart()
        {
            Console.WriteLine("Ürün sepetten çıkarıldı.");
        }

        public void Ekle(Urun urun)
        {
            Console.WriteLine($"{urun.UrunAdi} Sepete eklendi.");
        }

        public decimal IkiUrun(Urun urun)
        {
            decimal toplam = urun.UrunFiyatı * 2;
            return toplam;
        }
    }
}
