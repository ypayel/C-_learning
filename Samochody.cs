using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp28
{
    internal class Program
    {
        //Zadanie 1
        public abstract class Pojazd {
            public string NumerIdentyfikacyjny {  get; set; } 
            public string Marka {  get; set; }

            public string RokProdukcji { get; set; }

            public Pojazd( string numerIndetyfikacyjny, string marka, string rokProdukcji)
            {
                NumerIdentyfikacyjny = numerIndetyfikacyjny;
                Marka = marka;
                RokProdukcji = rokProdukcji;
            }
            public abstract void ShowInfo();

            public abstract void Service();
        }

        public class Samochod : Pojazd
        {
            public string TypSilnika { get; set; }

            public Samochod(string numerIdentyfikacyjny, string marka, string rokProdukcji, string typSilnika) : base(numerIdentyfikacyjny, marka, rokProdukcji)
            {
                TypSilnika = typSilnika;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Samochod {Marka}, Rok Produkcji: {RokProdukcji}, Numer ID: {NumerIdentyfikacyjny}, Typ silnika: {TypSilnika}");
            }

            public override void Service()
            {
                Console.WriteLine($"Samochod {Marka} ({NumerIdentyfikacyjny}) przeszedl servis");
            }
        }
        public class Motocykl : Pojazd
        {
            public bool CzyZTurbo { get; set; }

            public Motocykl(string numerIdentyfikacyjny, string marka, string rokProdukcji, bool czyZTurbo)
                : base(numerIdentyfikacyjny, marka, rokProdukcji)
            {
                CzyZTurbo = czyZTurbo;
            }

            public override void ShowInfo()
            {
                string turboInfo = CzyZTurbo ? "z turbo" : "bez turbo";
                Console.WriteLine($"Motocykl {Marka}, Rok produkcji: {RokProdukcji}, Numer ID: {NumerIdentyfikacyjny}, Wersja: {turboInfo}");
            }

            public override void Service()
            {
                Console.WriteLine($"Motocykl {Marka} ({NumerIdentyfikacyjny}) przeszedł serwis.");
            }
        }
        
        
            static void Main(string[] args)
            {
                // Tworzenie obiektów różnych typów pojazdów
                Pojazd samochod = new Samochod("123ABC", "Toyota", "2020", "Benzyna");
                Pojazd motocykl = new Motocykl("456DEF", "Yamaha", "2021", true);
               

               
                samochod.ShowInfo();
                motocykl.ShowInfo();
                

                Console.WriteLine();

                
                samochod.Service();
                motocykl.Service();
              
            }
        

    }
}
