namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Macierz<int> macierz1 = new Macierz<int>(2, 2);
            macierz1[0, 0] = 1;
            macierz1[0, 1] = 2;
            macierz1[1, 0] = 3;
            macierz1[1, 1] = 4;

            Macierz<int> macierz2 = new Macierz<int>(2, 2);
            macierz2[0, 0] = 1;
            macierz2[0, 1] = 2;
            macierz2[1, 0] = 3;
            macierz2[1, 1] = 4;

            Macierz<int> macierz3 = new Macierz<int>(2, 2);
            macierz3[0, 0] = 1;
            macierz3[0, 1] = 2;
            macierz3[1, 0] = 3;
            macierz3[1, 1] = 5;

            Macierz<int> macierz4 = new Macierz<int>(3, 3);
            macierz4[0, 0] = 1;
            macierz4[0, 1] = 2;
            macierz4[0, 2] = 2;
            macierz4[1, 0] = 3;
            macierz4[1, 1] = 5;
            macierz4[1, 2] = 6;

            Macierz<int> macierz5 = new Macierz<int>(3, 3);
            macierz5[0, 0] = 1;
            macierz5[0, 1] = 2;
            macierz5[0, 2] = 2;
            macierz5[1, 0] = 3;
            macierz5[1, 1] = 5;
            macierz5[1, 2] = 6;

            Console.WriteLine(macierz1 == macierz2); 
            Console.WriteLine(macierz1 == macierz3);
            Console.WriteLine(macierz4 == macierz5);
            Console.WriteLine(macierz1 != macierz5);
        }
    }
}
