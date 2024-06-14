using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public class ProduktSpozywczyPaczka : ProduktSpozywczy
    {
        private decimal _waga;

        public decimal Waga
        {
            get => _waga;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Waga nie moze byc ujemna");
                _waga = value;
            }
        }
    }
}
