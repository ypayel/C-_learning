using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int swapCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby oddzielone spacją:");
            string[] input = Console.ReadLine().Split(' ');

            int[] a = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                a[i] = int.Parse(input[i]);

            quick_sort(a, 0, a.Length - 1);
        }

        static void quick_sort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = partition(a, p, r);
                quick_sort(a, p, q);
                quick_sort(a, q + 1, r);
            }
        }

      
        static int partition(int[] a, int p, int r)
        {
            int x = a[p];    
            int i = p - 1;
            int j = r + 1;

            while (true)
            {
                while (a[--j] > x) ;
                while (a[++i] < x) ;

                if (i < j)
                {
                    if (swapCount < 3)
                    {
                        Console.WriteLine($"Swap nr: {swapCount} a[{i}] <-> a[{j}]");
                        swapCount++;
                    }

                   
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
                else
                {
                    return j;
                }
            }
        }
    }
}
