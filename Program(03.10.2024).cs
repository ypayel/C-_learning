// See https://aka.ms/new-console-template for more information



namespace ConosoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");


            /*
                        bool c = false;

                        string napis = "Napis";

                        char znak = 'A';

                        var d = Console.ReadLine();
                        Console.WriteLine(d);
                        Console.WriteLine(d.GetType());

                        int e = Convert.ToInt32(Console.ReadLine());*/


            //Zadanie 1 

            //int a = Convert.ToInt32(Console.ReadLine());

            //int b = Convert.ToInt32(Console.ReadLine());

            //var sum = a + b;

            //var multi = a * b;

            //var deletion = a % b;

            //Console.WriteLine("Wynnik summy:" + sum);
            //Console.WriteLine("Wynik iloczyn:" + multi);
            //Console.WriteLine("Wynik iloraz:" + deletion);



            ////Zadanie 2




            double userTemp = Convert.ToDouble(Console.ReadLine());

            var tempFahren = (userTemp * 1.8) + 32;

            Console.WriteLine("Temperatura w stopniach Fahrenheila:" + tempFahren);



            ////Zadanie 3


            double firstLine = Convert.ToDouble(Console.ReadLine());
            double secondLine = Convert.ToDouble(Console.ReadLine());
            double thirdLine = Convert.ToDouble(Console.ReadLine());

            var v = firstLine * secondLine * thirdLine;

            var p = 2 * firstLine * secondLine + 2 * firstLine * thirdLine + 2 * secondLine * thirdLine;


            Console.WriteLine("Objetnosc prostopadlosciaunu:" + v);
            Console.WriteLine("Powierzchnie boczne:" + p);



            ////Zadanie 4


            string userName = "Karol";
            string nameKurs = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Witaj," + " " + userName + "!" + " " + "Witamy na kursie" + " " + nameKurs + "!");


            //Zadanie 5

            int kg = Convert.ToInt32(Console.ReadLine());
            int heigth = Convert.ToInt32(Console.ReadLine());

            double bmi = kg / Math.Pow(heigth / 100.0, 2);

            Console.WriteLine("Wynik BMI:" + bmi);
        }
    }
}


//operatory W C#
/*
 * Mnozenie - *
 * Suma - +
 * Zmiejszenie elementa to --
 * Powiekszenie elementa - ++
 * Odejmowanie to -
 * Dzielenie - %
 * Porownannie - ==
 * Porownane rozne - !=
 * Alternatywy (lub) = || musi byc spelniony mininum jeden warunek zeby byla prawda inaczej bedzie falsz
 * Koniunkcja (razem) = && musza byc spelniony dwa warunka zeby byla prawda inaczej bedzie falsz
*/

//Literaly

/*
 *(/n) pozwala przyjsc do nowej linii
 * (/a) dodaje dzwienk windowsa 
 */


