using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ürün fiyatı, stok adedi, adı, kodu, açıklama, renk

            string urunAdi = "Gömlek";
            decimal urunFiyatı = 300m;
            int stokAdedi = 100;
            string urunKodu = "GMLK01";
            string aciklama = "%100 Pamuklu Gömlek";
            string renk = "Beyaz";
            string beden = "M";

            string[] gomlekler = new string[] { };

            string urunAdi2 = "Pantolon";
            decimal urunFiyatı2 = 400m;
            int stokAdedi2 = 150;
            string urunKodu2 = "PNTL01";
            string aciklama2 = "%100 Keten Pantolon";
            string renk2 = "Siyah";
            string beden2 = "L";

            Urun urun1 = new Urun();
            urun1.ID = 1;
            urun1.UrunKodu = "GMLK01";
            urun1.UrunFiyatı = 300m;
            urun1.Marka = "Mavi";
            urun1.UrunAdi = "Beyaz Gömlek";

            Urun urun2 = new Urun();
            urun2.ID = 2;
            urun2.UrunKodu = "PNTL01";
            urun2.UrunFiyatı = 400m;
            urun2.Marka = "Levi's";
            urun2.UrunAdi = "Siyah Pantolon";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ID);
                Console.WriteLine(urun.UrunKodu);
                Console.WriteLine(urun.UrunFiyatı);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Marka);
                Console.WriteLine
                ("-----------------");

            }

            SepetManager sepet = new SepetManager();
            sepet.Ekle();
            sepet.Cikart();
            sepet.Ekle(urun1); //Beyaz Gömlek sepete eklendi
            sepet.Ekle(urun2); //Siyah Pantolon sepete eklendi
            decimal hesap = sepet.IkiUrun(urun1);
            Console.WriteLine(urun1.UrunAdi + " * 2 = " + hesap);
            Console.ReadLine();
        }
    }
}
