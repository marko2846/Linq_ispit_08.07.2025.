using System.Collections;

namespace linq_zadaci
{
    // 
    public class Proizvod
    {
        public int Barkod { get; set; }
        public int ID { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }

    }

    public class Skladiste
    {
        public string Lokacija { get; set; }
        public int KapacitetSkladista { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Prvi zadatak

            var proizvodi = new List<Proizvod>
            {
                new Proizvod {ID = 19345 ,Barkod = 112233, Naziv = "Digitron", Cijena = 26.50m },
                new Proizvod {ID = 12344 ,Barkod = 116722, Naziv = "Telefon", Cijena = 1100.00m },
                new Proizvod {ID = 78665 ,Barkod = 900383, Naziv = "Laptop", Cijena = 2350.75m },
                new Proizvod {ID = 34557 ,Barkod = 237694, Naziv = "Monitor", Cijena = 300.00m }
            };

            var najskupljiProizvod = proizvodi
                .OrderByDescending(proizvodi => proizvodi.Cijena);

            foreach (var proizvod in najskupljiProizvod)
            {
                Console.WriteLine($"Naziv: {proizvod.Naziv}, Cijena: {proizvod.Cijena}\n");
            }



            // Drugi zadatak
            Console.WriteLine("---------------Drugi zadatak-----------------------------------\n");


            ArrayList svastara = new ArrayList
            {
                "Knjiga",
                3.14,
                true,
                'A',
                new Proizvod { Naziv = "Olovka", Cijena = 1.50m },
                new Skladiste { Lokacija = "Zagreb", KapacitetSkladista = 100 },
                new Skladiste { Lokacija = "Split", KapacitetSkladista = 200 }
            };

            var skladista = svastara.OfType<Skladiste>();

            foreach (var skladiste in skladista)
            {
                Console.WriteLine($"Lokacija: {skladiste.Lokacija}, Kapacitet: {skladiste.KapacitetSkladista}\n");
            }


            // Treći zadatak
            Console.WriteLine("---------------Treći zadatak-----------------------------------\n");

            var sortiranje = (from p in proizvodi
                              orderby p.ID, p.Barkod
                              select p).ToList();

            var sortiranj = proizvodi
                .OrderBy(p => p.ID)
                .ThenBy(p => p.Naziv);
                


            Console.WriteLine("Sortirani proizvodi po ID-u, pa po Barkodu su:\n");
            foreach (var p in sortiranje)
            {
                Console.WriteLine($"ID: {p.ID}, Barkod: {p.Barkod}, Naziv: {p.Naziv}\n");
            }


            // 4. Zadatak
            Console.WriteLine("---------------Četvrti zadatak---------------------------------\n");

            string[] rijeci =
                {
                  "Bio je ",
                  "onda je",
                  "pa je "
                };


            var rijecJe = rijeci
            .Where(a => a.Contains("je"))
            .Count();

            var jeRijec = (from r in rijeci
                           where r.Contains("je")
                           select r).Count();


            Console.WriteLine(rijecJe);
            Console.WriteLine($"{jeRijec}\n");

            // Peti zadatak
            Console.WriteLine("---------------Peti zadatak---------------------------------\n");








        }
    }
}
