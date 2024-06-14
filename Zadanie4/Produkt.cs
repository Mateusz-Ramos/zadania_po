using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public abstract class Produkt
    {
        private static readonly Dictionary<string, decimal> StawkiVAT = new Dictionary<string, decimal>
    {
        {"A", 0.23m},
        {"B", 0.08m},
        {"C", 0.05m},
        {"D", 0.00m}
    };

        private static readonly HashSet<string> KrajePochodzenia = new HashSet<string>
    {
        "Polska", "Niemcy", "Francja", "USA"
    };

        private string _kategoriaVAT;
        private decimal _cenaNetto;

        public string Nazwa { get; set; }
        public decimal CenaNetto
        {
            get => _cenaNetto;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena netto nie moze być ujemna");
                _cenaNetto = value;
            }
        }

        public string KategoriaVAT
        {
            get => _kategoriaVAT;
            set
            {
                if (!StawkiVAT.ContainsKey(value))
                    throw new ArgumentException("Niepoprawna kategoria VAT");
                _kategoriaVAT = value;
            }
        }

        public virtual decimal CenaBrutto => CenaNetto * (1 + StawkiVAT[KategoriaVAT]);

        private string _krajPochodzenia;
        public virtual string KrajPochodzenia
        {
            get => _krajPochodzenia;
            set
            {
                if (!KrajePochodzenia.Contains(value))
                    throw new ArgumentException("Niepoprawny kraj pochodzenia");
                _krajPochodzenia = value;
            }
        }
    }
}
