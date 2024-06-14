using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;

        public DateTime? DataUrodzenia { get; set; } = null;
        public DateTime? DataSmierci { get; set; } = null;

        public Osoba(string imieNazwisko)
        {
            ImieNazwisko = imieNazwisko;
        }

        public string Imie
        {
            get => imie;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Imie), "Imie nie moze byc puste.");
                }
                imie = value;
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                nazwisko = value;
            }
        }

        public string ImieNazwisko
        {
            get => $"{Imie} {Nazwisko}".Trim();
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(ImieNazwisko), "Imie i nazwisko nie moga byc puste.");
                }

                var podzial = value.Split(' ');
                Imie = podzial[0];
                Nazwisko = podzial.Length > 1 ? podzial[podzial.Length - 1] : string.Empty;
            }
        }

        public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                {
                    return null;
                }

                DateTime dataKoncowa = DataSmierci ?? DateTime.Now;
                return dataKoncowa - DataUrodzenia;
            }
        }
    }

    
}
