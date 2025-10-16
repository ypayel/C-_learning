using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Uses ordered generic dynamic array
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            OrderedDynamicArray<int> tablica = new OrderedDynamicArray<int>();
            tablica.Add(3);
            tablica.Add(1);
            tablica.Add(2);
            Console.WriteLine(tablica);

            Prostokat prostokat1 = new Prostokat(4, 3);
            Prostokat prostokat2 = new Prostokat(5, 2);
            Prostokat prostokat3 = new Prostokat(1, 11);

            OrderedDynamicArray<Prostokat> tab2 = new OrderedDynamicArray<Prostokat>();

            tab2.Add(prostokat1);
            tab2.Add(prostokat2);
            tab2.Add(prostokat3);

            Console.WriteLine(tab2);
            
            Console.WriteLine();


        }
    }
}
