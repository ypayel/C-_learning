using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    using System;

    class Program

    {
        static void Main()
        {
            int n = 9;
            Console.WriteLine($"{n}-ta liczba ciągu Fibonacciego to: {Fibonacci(n)}");
            Console.WriteLine($"{n}-ta liczba ciagu to: {Sequence(n)}");
            Console.WriteLine($"{n}-ta liczba drugiego ciagu to: {SequenceSecond(n)}");
        }
        //Zadanie 1
        static int Fibonacci(int n)
        {
            
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        //Zadanie 4
        static double Sequence(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 0.5;
            else
                return -Sequence(n - 1) * Sequence(n - 2);
        }
        //Zadanie 5

        static double SequenceSecond(int n)
        {
            if (n == 1)
                return -1;
            else
                return -SequenceSecond(n - 1) * (n - 3);
        }

    }

}
