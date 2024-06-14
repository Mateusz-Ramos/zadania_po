using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Prostokat
    {
        private double bokA;
        private double bokB;

        public Prostokat(double bokA, double bokB)
        {
            BokA = bokA;
            BokB = bokB;
        }

        public double BokA
        {
            get { return bokA; }
            set
            {
                if (value >= 0 && !double.IsNaN(value))
                    bokA = value;
                else
                    throw new ArgumentException("Bok A musi byc skonczona nieujemna liczba.");
            }
        }

        public double BokB
        {
            get { return bokB; }
            set
            {
                if (value >= 0 && !double.IsNaN(value))
                    bokB = value;
                else
                    throw new ArgumentException("Bok B musi byc skonczona nieujemna liczba.");
            }
        }

        private static readonly Dictionary<char, decimal> wysokoscArkusza0 = new Dictionary<char, decimal>
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };

        public static Prostokat ArkuszPapieru(string format)
        {
            char litera = format[0];
            int indeks = int.Parse(format.Substring(1));

            if (!wysokoscArkusza0.ContainsKey(litera))
                throw new ArgumentException("Nieznany format arkusza papieru.");

            decimal bazowaWysokosc = wysokoscArkusza0[litera];
            double pierwiastekZDwoch = Math.Sqrt(2);

            double wysokosc = (double)bazowaWysokosc / Math.Pow(pierwiastekZDwoch, indeks);
            double szerokosc = wysokosc / pierwiastekZDwoch;

            return new Prostokat(wysokosc, szerokosc);
        }
        }
    }
