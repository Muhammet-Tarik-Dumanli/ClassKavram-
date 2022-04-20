using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYönetimi
{
    internal class Yönetici
    {
        //İsim, soyisim, meslek, unvan, maaş, departman

        //SetYöneticiBilgileri()
        //isim, soyisim, departman
        //departman "İnsan Kaynakları" ise  Unvan = "İnsan Kaynakları Müdürü", Maaş = 10000;
        //departman "Bilgi İşlem" ise  Unvan = "Bilgi İşlem Müdürü", Maaş = 11000;
        //departman "Muhasebe" ise Unvan = "Muhasebe Müdürü", Maaş = 10500;
        //GetYöneticiBilgileri
        //Yönetici bilgisi oluşturuldu.
        //İsim: 
        //soyisim: 
        //Mesle:
        //Unvan:
        //Maaş
        //Departman

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Meslek { get; set; }
        public string Unvan { get; set; }
        public decimal Maas { get; set; }
        public string Departman { get; set; }

        public void SetYoneticiBilgileri(string isim, string soyisim, string departman)
        {
            if (isim.Length > 0 && soyisim.Length > 0)
            {
                if (departman == "İnsan Kaynakları")
                {
                    this.Isim = isim;
                    this.Soyisim = soyisim;
                    this.Meslek = "Yönetim Bilişim Sistemleri";
                    this.Maas = 10000;
                    this.Unvan = departman + " Müdürü";
                    this.Departman = departman;
                }
                if (departman == "Bilgi İşlem")
                {
                    this.Isim = isim;
                    this.Soyisim = soyisim;
                    this.Meslek = "Bilgisayar Mühendisi";
                    this.Maas = 11000;
                    this.Unvan = departman + " Müdürü";
                    this.Departman = departman;
                }
                if (departman == "Muhasebe")
                {
                    this.Isim = isim;
                    this.Soyisim = soyisim;
                    this.Meslek = "İktisat";
                    this.Maas = 10500;
                    this.Unvan = departman + " Müdürü";
                    this.Departman = departman;
                }
            }


            else
            {
                Console.WriteLine("Yönetici oluşturulabilmek için isim ve soyisim bilgisi boş bırakılamaz!!!");
            }
        }

        public string GetYoneticiBilgileri()
        {
            if (Departman != null)
            {
                return "Yönetici bilgileri oluşturuldu." +
                    "\nYönetici ismi: " + Isim +
                    "\nYönetici Soyismi: " + Soyisim +
                    "\nYönetici meslek: " + Meslek +
                    "\nYönetici maaş: " + Maas +
                    "\nYönetici Unvan: " + Unvan +
                    "\nYönetici departman: " + Departman;
            }
            else
            {
                return "Yönetici Bilgileriniz Bulunamadı!";
            }
        }
    }
}

