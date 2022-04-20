using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramı
{
    internal class Urun
    {
        public int ID { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyatı { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }
        public string Renk { get; set; }
        public string Beden { get; set; }
        public string Marka { get; set; }

    }
}
