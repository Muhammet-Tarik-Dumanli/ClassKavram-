using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYönetimi
{
    public class Personel
    {
        //İsim, soyisim, unvan, maas, izin günü
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Unvan { get; set; }
        public decimal Maas { get; set; }
        public byte IzinGunu { get; set; }


        //setPersonelBilgileri metot
        //isim,soyisim,maas cağrılıyor
        //Eğer maaş<2500 Personel izinGunu=14
        //Eğer maaş 3000 ile 4000 arasındaysa Kıdemli Personel izinGunu=20
        //Eğer maaş 4001 ile 5500 arasındaysa Uzman Personel izinGunu=24
        //Eğer maaş 5500 büyükse Kıdemli Uzman Personel izinGunu=30


        public void SetPersonelBilgileri(string isim, string soyisim, decimal maas)
        {
            if (isim.Length > 0 && soyisim.Length > 0)
            {
                if (maas >= 2500)
                {
                    this.Isim = isim;
                    this.Soyisim = soyisim;
                    this.Maas = maas;
                    this.Unvan = "Personel";
                    this.IzinGunu = 14;
                    if (3000 < maas && maas < 4000)
                    {
                        this.Unvan = "Kıdemli Personel";
                        this.IzinGunu = 20;
                    }
                    else if (4001 < maas && maas < 5500)
                    {
                        this.Unvan = "Uzman Personel";
                        this.IzinGunu = 24;
                    }
                    else
                    {
                        this.Unvan = "Kıdemli Uzman Personel";
                        this.IzinGunu = 30;
                    }
                }
                else
                {
                    Console.WriteLine("Personel maaşı en az 2500 TL olmalı!");
                }
            }
            else
            {
                Console.WriteLine("Personel oluşturulabilmek için isim ve soyisim bilgisi boş bırakılamaz!!!");
            }
        }

        public string GetPersonelBilgileri()
        {
            if (Unvan != null)
            {
                return "Personel bilgileri oluşturuldu." +
                    "\nPersonel ismi: " + Isim +
                    "\nPersonel Soyismi: " + Soyisim +
                    "\nPersonel maaş: " + Maas +
                    "\nPersonel Unvan: " + Unvan +
                    "\nPersonel izin günü: " + IzinGunu;
            }
            else
            {
                return "Personel Bilgileriniz Bulunamadı!";
            }
        }
    }
}
