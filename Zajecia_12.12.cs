using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 15;

            Console.WriteLine($"NwD ({a}, {b}) = {Euklides(a, b)}");

            Console.WriteLine(Silnia(5));

            ConvertToBinary(13564);
            Console.WriteLine();

            //int liczbaKrazkow = 3;
            //Hanoi(liczbaKrazkow, 'A', 'B', 'C');

            Console.WriteLine(CalculateTerm(4));

            NeverEndingStory();
        }

        static int CalculateTerm(int n)
        {
            if (n == 1)
                return -2;
            return n * CalculateTerm(n - 1) + 4;
        }



        static void NeverEndingStory()
        {
            Console.WriteLine("Na na na");
            NeverEndingStory();
        }

        static void Hanoi(int n, char zrodlo, char pomoc, char cel)
        {
            if (n > 0)
            {
                Hanoi(n - 1, zrodlo, cel, pomoc);
                Console.WriteLine($"Przenieś krążek {n} z {zrodlo} na {cel}");
                Hanoi(n - 1, pomoc, zrodlo, cel);
            }
        }

        static void ConvertToBinary(int n)
        {
            if (n == 0) return;

            ConvertToBinary(n / 2);
            Console.Write(n % 2);
        }

        //5! = 1*2*3*4*5
        static int Silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Silnia(n - 1);
        }

        static int Euklides(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Euklides(b, a % b);
        }
    }
}
