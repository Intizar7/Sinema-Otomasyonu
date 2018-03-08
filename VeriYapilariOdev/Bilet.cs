using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
    public class Bilet
    {
        public Musteri musteri { get; set; }

        public int SecilenKoltuk { get; set; }
        public Bilet()
        {
            SecilenKoltuk = 0;
        }
    }
}
