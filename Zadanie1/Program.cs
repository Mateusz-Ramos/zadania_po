namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imie i nazwisko:");
            string imieNazwisko = Console.ReadLine();
            Osoba osoba = new Osoba(imieNazwisko);

            Console.WriteLine("Podaj date urodzenia (RRRR-MM-DD):");
            string dataUrodzeniaInput = Console.ReadLine();
            if (DateTime.TryParse(dataUrodzeniaInput, out DateTime dataUrodzenia))
            {
                osoba.DataUrodzenia = dataUrodzenia;
            }

            Console.WriteLine("Podaj date smierci (RRRR-MM-DD) lub pozostaw puste:");
            string dataSmierciInput = Console.ReadLine();
            if (DateTime.TryParse(dataSmierciInput, out DateTime dataSmierci))
            {
                osoba.DataSmierci = dataSmierci;
            }

            Console.WriteLine("Imie i nazwisko: " + osoba.ImieNazwisko);

            if (osoba.Wiek.HasValue)
            {
                Console.WriteLine("Wiek w dniach: " + osoba.Wiek.Value.Days);
            }
            else
            {
                Console.WriteLine("Wiek: nieznany");
            }

     
        }
    }
}
