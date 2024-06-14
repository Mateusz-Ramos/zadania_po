using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Wektor
    {
        private double[] wspolrzedne;

        public Wektor(byte wymiar)
        {
            wspolrzedne = new double[wymiar];
        }

        public Wektor(params double[] wspolrzedne)
        {
            this.wspolrzedne = wspolrzedne;
        }

        public double Dlugosc
        {
            get
            {
                return Math.Sqrt((double)IloczynSkalarny(this, this));
            }
        }

        public byte Wymiar
        {
            get
            {
                return (byte)wspolrzedne.Length;
            }
        }

        public double this[byte index]
        {
            get
            {
                return wspolrzedne[index];
            }
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory musza byc tego samego wymiaru.");
            }

            double iloczyn = 0;
            for (byte i = 0; i < V.Wymiar; i++)
            {
                iloczyn += V[i] * W[i];
            }
            return iloczyn;
        }

        public static Wektor Suma(params Wektor[] Wektory)
        {
            byte wymiar = Wektory[0].Wymiar;
            foreach (var wektor in Wektory)
            {
                if (wektor.Wymiar != wymiar)
                {
                    throw new ArgumentException("Wektory musza byc tego samego wymiaru.");
                }
            }

            Wektor suma = new Wektor(wymiar);
            for (byte i = 0; i < wymiar; i++)
            {
                double sum = 0;
                foreach (var wektor in Wektory)
                {
                    sum += wektor[i];
                }
                suma.wspolrzedne[i] = sum;
            }

            return suma;
        }

        public static Wektor operator +(Wektor v1, Wektor v2)
        {
            if (v1.Wymiar != v2.Wymiar)
            {
                throw new ArgumentException("Wektory musza byc tego samego wymiaru.");
            }

            Wektor suma = new Wektor(v1.Wymiar);
            for (byte i = 0; i < v1.Wymiar; i++)
            {
                suma.wspolrzedne[i] = v1[i] + v2[i];
            }
            return suma;
        }

        public static Wektor operator -(Wektor v1, Wektor v2)
        {
            if (v1.Wymiar != v2.Wymiar)
            {
                throw new ArgumentException("Wektory musza byc tego samego wymiaru.");
            }

            Wektor roznica = new Wektor(v1.Wymiar);
            for (byte i = 0; i < v1.Wymiar; i++)
            {
                roznica.wspolrzedne[i] = v1[i] - v2[i];
            }
            return roznica;
        }

        public static Wektor operator *(Wektor v, double skalar)
        {
            Wektor wynik = new Wektor(v.Wymiar);
            for (byte i = 0; i < v.Wymiar; i++)
            {
                wynik.wspolrzedne[i] = v[i] * skalar;
            }
            return wynik;
        }

        public static Wektor operator *(double skalar, Wektor v)
        {
            return v * skalar;
        }

        public static Wektor operator /(Wektor v, double skalar)
        {
            if (skalar == 0)
            {
                throw new DivideByZeroException("Nie mozna dzielic przez zero.");
            }

            Wektor wynik = new Wektor(v.Wymiar);
            for (byte i = 0; i < v.Wymiar; i++)
            {
                wynik.wspolrzedne[i] = v[i] / skalar;
            }
            return wynik;
        }

        public override string ToString()
        {
            return "(" + string.Join(", ", wspolrzedne) + ")";
        }
    }
}
