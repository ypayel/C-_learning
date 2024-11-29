using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {


        static void Main(string[] args)
        {


            // Zadanie 1
            int x = 5;
            int z = 10;
            int y = 15;
            int wynik = Maks(x, z, y);
            Console.WriteLine(wynik);
            //Zadanie 3
            int min = 1;
            int max = 50;
            Console.WriteLine($"Suma wszystkich liczb w przedzile <{min}, {max}>: {Suma(min, max)}");
            Console.WriteLine($"Suma liczb parzystych w przedziale <{min}, {max}>: {SumaEven(min, max)}");
            Console.WriteLine($"Suma liczb podzielnych przez 3 w przedziale <{min}, {max}>: {SumBy3(min, max)}");
            // Zadanie 4 
            Console.WriteLine($"Najwieksza liczba calkowita {WartoscMaks(granica:4)}");
            //Zadanie 5 
            Console.WriteLine($"Suma szeregu {SumaN(5)}");
            //Zadanie 2
            Console.WriteLine(ktoraCwiartka(3, 4));   
            Console.WriteLine(ktoraCwiartka(-2, 5));  
            Console.WriteLine(ktoraCwiartka(0, 4));   
            Console.WriteLine(ktoraCwiartka(1, -3));  
            Console.WriteLine(ktoraCwiartka(0, 0));   
        }

       

        public static int Maks(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        // zadanie 2



        //zadanie 3

        public static long Suma(int min, int max)
        {
            long sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static long SumaEven(int min, int max)
        {
            long sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static long SumBy3(int min, int max)
        {
            long sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 3 == 0)  
                {
                    sum += i;
                }
            }
            return sum;
        }
        // Zadanie 4 

        public static long WartoscMaks(int granica)
        {
            long n = 0;
            long sum = 0;
            while ( sum + (n + 1 ) < granica )
            {
                n++;
                sum += n;
                
            }
            return n;
        }

        //Zadanie 5 

        public static long SumaN(int n)
        {
            long sum = 0;
            for(int i = 0; i <= n;i++)
            {
                sum+=i;
            }
            return sum;
        }


        //Zadanie 2 
        public static int ktoraCwiartka(float x, float y)
        {
            
            if (x == 0 || y == 0)
            {
                return 0;
            }

            
            if (x > 0 && y > 0)
            {
                return 1;
            }

           
            if (x < 0 && y > 0)
            {
                return 2;
            }

            
            if (x < 0 && y < 0)
            {
                return 3;
            }

            if (x > 0 && y < 0)
            {
                return 4;
            }

           
            return 0;
        }
    }
}
