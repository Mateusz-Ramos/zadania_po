namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj format arkusza papieru (np. A0, B1, C2):");
                string format = Console.ReadLine();

                Prostokat prostokąt = Prostokat.ArkuszPapieru(format);
                Console.WriteLine($"Wymiary arkusza papieru {format}: {prostokąt.BokA}mm x {prostokąt.BokB}mm");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
