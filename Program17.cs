using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        private static int zmiennaWspoldzielona = 10;

        static void Main(string[] args)
        {
            //int wynik = Dodaj(3, 5);
            //Console.WriteLine(wynik);

            //Metoda1();
            //Metoda2();
            //Console.WriteLine("Kod przed metodą");
            //int wynik = Podziel(30, 0);
            //Console.WriteLine(wynik);
            //Console.WriteLine("Dalszy kod");

            // Operacje na tekście
            //string napis = "Hello";
            //Console.WriteLine(napis.Length);
            //Console.WriteLine(napis.Substring(1, 2));
            //Console.WriteLine(string.Concat(napis, napis));

            //Operacje matematyczne
            //Console.WriteLine(Math.Pow(10.0, 4.0));

            //Operacje na datach
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);

            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next());
            //Console.WriteLine(rnd.Next(1, 101)); //[1 : 100)
            //Console.WriteLine(rnd.NextDouble());

            //Console.WriteLine(MetodaP(1));
            //MetodaP();
            //Console.WriteLine(MetodaP(1.0));

            // 6
            //Console.WriteLine(Suma(4, 2.0f));

            //7

            Console.WriteLine("Podaj początek przedziału:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Liczby pierwsze w przedziale od {start} do {end}: \n");
            List<int> list = FindPrimesInRange(start, end);
            Console.WriteLine(string.Join(", ", list));




        }
        static List<int> FindPrimesInRange(int start, int end)
        {
            if (start < 2) start = 2;
            bool[] isPrime = new bool[end + 1];
            for (int i = start; i <= end; i++)
            {
                isPrime[i] = true;
            }
            for (int i = start; i*i <= end; i++)
            {
                if (isPrime[i])
                {
                    for(int j = i*i;  j <= end; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }
            return primes;
        }


        // Zadanie 6
        public static float Suma(int n, float x)
        {
            float wynik = 0;

            for (int i = 1; i <= n; i++)
            {
                wynik += (float)Math.Pow(x, i) + i;
            }
            return wynik;
        }





        public static int MetodaP (int x)
        {
            return x * x;
        }

        public static void MetodaP()
        {
            Console.WriteLine("Inne dzianie");
        }
        public static double MetodaP(double r)
        {
            return r*r * Math.PI;
        }











        public static int Dodaj(int a,  int b)
        {
            return a + b;
        }

        public static void Metoda()
        {
            int a = 50;
            int b = 20;
            Console.WriteLine(a + b);
        }

        public static void Metoda1() {
            // Zmienna lokalna
            int zmiennaLokalna = 5;

            int suma = zmiennaLokalna + zmiennaWspoldzielona;
            zmiennaWspoldzielona += zmiennaLokalna;
            Console.WriteLine(suma);
        }
        public static void Metoda2()
        {
            Console.WriteLine(zmiennaWspoldzielona * zmiennaWspoldzielona);

        }

        public static int Podziel(int dzielna, int dzielnik)
        {
            if(dzielnik == 0)
            {
                throw new ArgumentException("Dzielnik nie może być zerem");
            }
            return dzielna/dzielnik;
        }
    }
}
