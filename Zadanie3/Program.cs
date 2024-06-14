namespace Zadanie3
{
    class Program
    {
        static void Main()
        {
            byte wymiar = WczytajLiczbe("Podaj wymiar wektora:");

            Wektor v1 = StworzWektor(wymiar, "v1");
            Wektor v2 = StworzWektor(wymiar, "v2");

            Console.WriteLine($"Dlugosc v1: {v1.Dlugosc}");
            Console.WriteLine($"Dlugosc v2: {v2.Dlugosc}");

            double iloczynSkalarny = Wektor.IloczynSkalarny(v1, v2);
            if (!double.IsNaN(iloczynSkalarny))
            {
                Console.WriteLine($"Iloczyn skalarny v1 i v2: {iloczynSkalarny}");
            }
            else
            {
                Console.WriteLine("Wektory musza byc tego samego wymiaru.");
            }

            Wektor suma = v1 + v2;
            Console.WriteLine($"Suma v1 i v2: {suma}");

            Wektor roznica = v1 - v2;
            Console.WriteLine($"Roznica v1 i v2: {roznica}");

            Console.WriteLine("Podaj skalar:");
            double skalar = Convert.ToDouble(Console.ReadLine());
            Wektor v1Mnozone = v1 * skalar;
            Console.WriteLine($"v1 pomnozony przez {skalar}: {v1Mnozone}");

            Console.WriteLine("Podaj dzielnik:");
            double dzielnik = Convert.ToDouble(Console.ReadLine());
            Wektor v2Podzielone = v2 / dzielnik;
            Console.WriteLine($"v2 podzielony przez {dzielnik}: {v2Podzielone}");

            Console.ReadKey();
        }

        static byte WczytajLiczbe(string komunikat)
        {
            Console.WriteLine(komunikat);
            return Convert.ToByte(Console.ReadLine());
        }

        static Wektor StworzWektor(byte wymiar, string nazwaWektora)
        {
            Console.WriteLine($"Podaj wspolrzedne wektora {nazwaWektora}:");
            double[] wspolrzedne = new double[wymiar];
            for (int i = 0; i < wymiar; i++)
            {
                Console.Write($"Wspolrzedna {i + 1}: ");
                wspolrzedne[i] = Convert.ToDouble(Console.ReadLine());
            }
            return new Wektor(wspolrzedne);
        }
    }
}
