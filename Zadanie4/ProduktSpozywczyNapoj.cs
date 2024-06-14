using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public class ProduktSpozywczyNapoj : ProduktSpozywczyPaczka
    {
        private uint _objetosc;

        public uint Objetosc
        {
            get => _objetosc;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Objetosc nie moze byc ujemna.");
                _objetosc = value;
            }
        }
    }
}
