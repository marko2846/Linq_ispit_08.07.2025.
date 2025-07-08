using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola__Ispit_
{
    public class Program
    {

        static void Main(string[] args)
        {
            Podaci podaci = new Podaci();

            // Grupiraj prema Banci 

            var GrupirajPremaBanci = podaci.ListaKlijenata
                .Where(p => p.Stanje >= 1000000)
                .GroupBy(k => k.Banka)
                .Select(g => new GrupiraniMilijunasi
                {
                    Banka = g.Key,
                    Milijunasi = g.Select(k => k.ImePrezime).OrderBy(n => n).ToList()
                })
                .ToList();

            foreach (var grupa in GrupirajPremaBanci)
            {
                string linija = string.Join(" i ", grupa.Milijunasi);

                Console.WriteLine($"{grupa.Banka}: {linija}");

            }
            Console.WriteLine("--------------------------------------------------");

            // Svi klijenti Milijunaši

            var IzvještajMilijunaša = podaci.ListaKlijenata
                .Where(k => k.Stanje >= 1000000)
                .Select(k => new
                {
                    k.ImePrezime,
                    k.Stanje,
                    k.Banka
                })
                .ToList();

            foreach (var klijent in IzvještajMilijunaša)
            {
                Console.WriteLine($"{klijent.ImePrezime} je u {klijent.Banka}");
            }




        }
    }
}
