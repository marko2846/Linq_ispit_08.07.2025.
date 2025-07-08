using Ispit.Model.Klase;

namespace Ispit.Model
{
    public class Podaci
    {

        public List<Banka> ListaBanki { get; set; } = new List<Banka>
        {
                new Banka { Simbol = "ZABA", Naziv = "Zagrebačka banka" },
                new Banka { Simbol = "PBZ", Naziv = "Privredna banka Zagreb" },
                new Banka { Simbol = "OTP", Naziv = "OTP banka" }
        }
       

        public  List<Klijent> ListaKlijenata { get; set; } = new List<Klijent>
        {
            new Klijent { ImePrezime = "Ivan Ivanić", Stanje = 1500000, Banka = "ZABA" },
            new Klijent { ImePrezime = "Ana Anić", Stanje = 2000000, Banka = "PBZ" },
            new Klijent { ImePrezime = "Marko Markić", Stanje = 3400000, Banka = "OTP" },
            new Klijent { ImePrezime = "Petra Marić", Stanje = 5007600, Banka = "ZABA" },
            new Klijent { ImePrezime = "Luka Lukić", Stanje = 100500, Banka = "OTP" },
            new Klijent { ImePrezime = "Sara Sarić", Stanje = 250000,Banka = "OTP" },
            new Klijent { ImePrezime = "Tomislav Tomić", Stanje = 4050000, Banka = "ZABA" },
            new Klijent { ImePrezime = "Marija Marić", Stanje = 6030700, Banka = "PBZ" },
            new Klijent { ImePrezime = "Ante Antić", Stanje = 702000, Banka = "ZABA" },
            new Klijent { ImePrezime = "Klara Klarić", Stanje = 800300, Banka = "ZABA" },
            new Klijent { ImePrezime = "Dino Dinić", Stanje = 900100, Banka = "PBZ" }
        };
    }
}
