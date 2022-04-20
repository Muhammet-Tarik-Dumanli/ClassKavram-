using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Personel
            //Personel personel1 = new Personel();
            //Personel personel2 = new Personel();


            ////string personel1Bilgileri = personel1.GetPersonelBilgileri();
            ////Console.WriteLine(personel1Bilgileri);

            //personel1.SetPersonelBilgileri("Tarık", "DUMANLI", 6000m);
            //personel2.SetPersonelBilgileri("Burçin", "İlker", 5000m);

            //Console.WriteLine(personel1.GetPersonelBilgileri());
            //Console.WriteLine();
            //Console.WriteLine(personel2.GetPersonelBilgileri()); 
            #endregion

            #region Yonetici

            Yönetici yönetici1 = new Yönetici();
            Yönetici yönetici2 = new Yönetici();
            Yönetici yönetici3 = new Yönetici();

            yönetici1.SetYoneticiBilgileri("Tarık", "DUMANLI", "İnsan Kaynakları");
            yönetici2.SetYoneticiBilgileri("Burçin", "İlker", "Bilgi İşlem");
            yönetici3.SetYoneticiBilgileri("Harun", "Kolçak", "Muhasebe");

            Console.WriteLine(yönetici1.GetYoneticiBilgileri());
            Console.WriteLine();
            Console.WriteLine(yönetici2.GetYoneticiBilgileri());
            Console.WriteLine();
            Console.WriteLine(yönetici3.GetYoneticiBilgileri());
            #endregion
            Console.ReadKey();
        }
    }
}
