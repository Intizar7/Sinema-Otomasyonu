using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
  public  class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Musteri()
        {
            
        }

        public Musteri(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
    }
}
