using System;
using System.Collections.Generic;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProduktSpozywczyNapoj cola = new ProduktSpozywczyNapoj
                {
                    Nazwa = "Cola",
                    CenaNetto = 3.50m,
                    KategoriaVAT = "B",
                    Kalorie = 45,
                    Waga = 1.0m,
                    Objetosc = 500,
                    KrajPochodzenia = "Polska",
                    Alergeny = new HashSet<string> { "Cukier" }
                };

                ProduktSpozywczyPaczka chleb = new ProduktSpozywczyPaczka
                {
                    Nazwa = "Chleb",
                    CenaNetto = 2.00m,
                    KategoriaVAT = "C",
                    Kalorie = 250,
                    Waga = 0.5m,
                    KrajPochodzenia = "Niemcy",
                    Alergeny = new HashSet<string> { "Gluten" }
                };

                ProduktSpozywczyNaWage jablka = new ProduktSpozywczyNaWage
                {
                    Nazwa = "Jablka",
                    CenaNetto = 5.00m,
                    KategoriaVAT = "C",
                    Kalorie = 52,
                    KrajPochodzenia = "Polska",
                    Alergeny = new HashSet<string> { "Brak" }
                };

                DisplayProductInfo(cola);
                DisplayProductInfo(chleb);
                DisplayProductInfo(jablka);

                Wielopak wielopakCola = new Wielopak
                {
                    Produkt = cola,
                    Ilość = 6,
                    CenaNetto = 20.00m
                };

                DisplayWielopakInfo(wielopakCola);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void DisplayProductInfo(Produkt produkt)
        {
            Console.WriteLine($"Nazwa: {produkt.Nazwa}");
            Console.WriteLine($"Cena netto: {produkt.CenaNetto} PLN");
            Console.WriteLine($"Cena brutto: {produkt.CenaBrutto} PLN");
            Console.WriteLine($"Kategoria VAT: {produkt.KategoriaVAT}");
            Console.WriteLine($"Kraj pochodzenia: {produkt.KrajPochodzenia}");
            if (produkt is ProduktSpozywczy produktSpozywczy)
            {
                Console.WriteLine($"Kalorie: {produktSpozywczy.Kalorie} kcal");
                Console.WriteLine($"Alergeny: {string.Join(", ", produktSpozywczy.Alergeny)}");
            }
            if (produkt is ProduktSpozywczyPaczka produktPaczka)
            {
                Console.WriteLine($"Waga: {produktPaczka.Waga} kg");
            }
            if (produkt is ProduktSpozywczyNapoj produktNapój)
            {
                Console.WriteLine($"Objętość: {produktNapój.Objetosc} ml");
            }
            Console.WriteLine();
        }

        private static void DisplayWielopakInfo(Wielopak wielopak)
        {
            Console.WriteLine("Wielopak:");
            Console.WriteLine($"Produkt: {wielopak.Produkt.Nazwa}");
            Console.WriteLine($"Ilość: {wielopak.Ilość}");
            Console.WriteLine($"Cena netto: {wielopak.CenaNetto} PLN");
            Console.WriteLine($"Cena brutto: {wielopak.CenaBrutto} PLN");
            Console.WriteLine($"Kategoria VAT: {wielopak.KategoriaVAT}");
            Console.WriteLine($"Kraj pochodzenia: {wielopak.KrajPochodzenia}");
            Console.WriteLine();
        }
    }
}