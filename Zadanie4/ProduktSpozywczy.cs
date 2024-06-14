using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public abstract class ProduktSpozywczy : Produkt
    {
        private static readonly HashSet<string> KategorieVATSpożywcze = new HashSet<string>
    {
        "B", "C", "D"
    };

        private uint _kalorie;

        public string KategoriaVAT
        {
            get => base.KategoriaVAT;
            set
            {
                if (!KategorieVATSpożywcze.Contains(value))
                    throw new ArgumentException("Niepoprawna kategoria VAT dla produktu spozywczego");
                base.KategoriaVAT = value;
            }
        }

        public uint Kalorie
        {
            get => _kalorie;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Kalorie nie moga byc ujemne");
                _kalorie = value;
            }
        }

        private HashSet<string> _alergeny;
        public virtual HashSet<string> Alergeny
        {
            get => _alergeny;
            set => _alergeny = value;
        }
    }
}
