using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public class Wielopak
    {
        public Produkt Produkt { get; set; }
        public ushort Ilość { get; set; }
        public decimal CenaNetto { get; set; }

        public decimal CenaBrutto => CenaNetto * (1 + Produkt.CenaBrutto / Produkt.CenaNetto);

        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;
    }

}
