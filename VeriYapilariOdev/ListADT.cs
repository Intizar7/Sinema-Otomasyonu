using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
   public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertPos(int position, Bilet value);
        public abstract void DeletePos(int position);
        public abstract Node GetElement(int position);
    }
}
