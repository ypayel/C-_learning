namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            



            // ZADANIE 1

            //A

            
            int rozmiarTablicy = 10;
            int[] liczby = new int[rozmiarTablicy];
            Console.WriteLine("Podaj 10 liczb:", rozmiarTablicy);
            Console.WriteLine("Wprowadz liczbe k");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rozmiarTablicy; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    liczby[i] = num;
                }
                Console.WriteLine("Wprowadzone liczby:" + num);


                int sum = 0;
                for(int j = 1; j < liczby.Length; j++)
                {
                    sum += liczby[j];
                }
                Console.WriteLine("Suma:" + sum);




                //B 

                int dodatnieSum = 0;
                foreach(int liczba in liczby)
                {
                    if (liczba > 0)
                    {
                        dodatnieSum += liczba;
                    }
                }
                Console.WriteLine("Suma dodatnich:" + dodatnieSum);



                //C 

                int ujemneSum = 0;
                foreach (int liczba in liczby)
                {
                    if(liczba < 0)
                    {
                        ujemneSum += liczba;
                    }
                    
                }
                Console.WriteLine("Sume ujemnych:" + ujemneSum);

                //D
         
                int sumaOdK = 0;
                if (liczby[i] > k)
                {
                    sumaOdK += liczby[i];
                }
                Console.WriteLine("Suma liczby k: " +sumaOdK);
                //E + F
                int sumaNieparzystych = 0;
                int sumaParzystych = 0;
                if (i % 2 == 0)
                {
                    sumaParzystych += liczby[i];
                }
              
                else
                {
                    sumaNieparzystych += liczby[i];
                }
                Console.WriteLine("Suma parzystych: " + sumaParzystych);
                Console.WriteLine("Suma nieparzystych: " + sumaNieparzystych);

                
            }
            //ZADANIE 2

            int min = liczby[0];
            for (int i = 1; i < liczby.Length; i++)
            {
                if(liczby[i] < min)
                {
                    min = liczby[i];
                }
            }
            Console.WriteLine("Wartosc minimalna: " + min);


            int max = liczby[0];
            for (int i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] > max)
                {
                    max = liczby[i];
                }
            }
            Console.WriteLine("Wartosc maksymalna: " + max);

            //ZADANIE 3

            int elementToCount = 2;

            int count = CountOccurrences(liczby, elementToCount);
            Console.WriteLine($"Element {elementToCount} występuje {count} razy w tablicy.");

            static int CountOccurrences(int[] array, int element)
            {
                return Array.FindAll(array, x => x == element).Length;
            }

            //ZADANIE 4 
            //A

            int n = liczby.Length;
            int countN = IlePrzez3(liczby, n);
            Console.WriteLine($"Liczby podzielne przez 3 występują {count} razy w tablicy.");

            static int IlePrzez3(int[] t1, int n)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t1[i] % 3 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            //B 

            int X = 3;
            int countX = IlePrzezX(liczby, n, X);
            Console.WriteLine($"Liczby podzielne przez {X} występują {count} razy w tablicy.");

            static int IlePrzezX(int[] t1, int n, int X)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t1[i] % X == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }






    }
}
