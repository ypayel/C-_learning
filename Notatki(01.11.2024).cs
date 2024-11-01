//int[] tab = new int[5];

//int[] tab2 = { 1, 5, 4, 7, 4, 2 };



//Przejscie po tablice 

//for (int i = 0; i < tab.Length; i++)
//{
//    tab[i] = i * i;
//}
//foreach (int num in tab2)
//{
//    Console.WriteLine(num * num );
//}


//int[] tab3 = new int[5];
//Console.WriteLine("Podaj 5 liczb");
//for (int i = 0; i < tab.Length; i++)
//{
//    int.TryParse(Console.ReadLine(), out int num2);
//    tab2[i] = num2;
//}
//Console.WriteLine("Wpisane liczby");
//foreach (int i in tab)
//{
//    Console.WriteLine(i);
//}


//Przejscie po stringach

//string[] imiona = { "Anna", "Marta", "Ola", "Patryk" };
//foreach(string imie in imiona)
//{
//    Console.WriteLine($"Dlugosc {imie}: {imie.Length} znakow")
//}





//KOPIOWANIE

//int[] t1 = { 11, 33, 15, 27, 39 };
//int[] t2 = new int[t1.Length];
//Array.Copy(t1, t2, t1.Length);      // Kopuje tablice 
//Array.Reverse(t1);                  // Odwraca tablice 
//Array.Sort(t1, (a,b) => b.CompareTo(a));  // Sortuje malejaco
////Array.Sort(t1, (a, b) => a.CompareTo(b)); Sortuje rosnance 
//foreach (int i in t1)
//{
//    Console.WriteLine(i);
//}


//SORTOWANIE BOMBELKOWE

//int[] TAB = { 11, 33, 15, 27, 39, 22, 21, 20, 46, 88, 23 };
//Console.WriteLine("Tablica przed sortowaniem");
//foreach (int i in tab)
//{
//    Console.WriteLine(i);
//}

//bool zmiana;
//do
//{
//    zmiana = false;
//    for (int i = 0; i < tab.Length - 1; i++)
//    {
//        if (TAB[I] >= TAB[ i + 1])
//        {
//            int temp = TAB[i];
//            TAB[i] =TAB[i + 1];
//            TAB[i + 1] =temp;
//            zmiana = true;
//        }
//    }
//} while (zmiana);
//Console.WriteLine("Tablica po posortowaniu");
//foreach (int i  in TAB)
//{
//    Console.WriteLine(i);
//}

//string[] imiona = { "Anna", "Marta", "Ola", "Patryk" };
//int index = Array.IndexOf(imiona, "fgdfgdg");
//Console.WriteLine(index);



//SUMA 

//int[] TAB = { 11, 33, 15, 27, 39, 22, 21, 20, 46, 88, 23 };

//int sum = 0;
//foreach (int i in TAB)
//{
//    sum += tab[i];
//}
//Console.WriteLine(sum);



//for (int i = 0; i < TAB.Length; i++)
//    if (TAB[i] != 23)
//{
//    sum++;
//}


//LICZBA MINIMALNA 

//int[] TAB = { 11, 33, 15, 27, 39, 22, 21, 20, 46, 88, 23 };

//int min = TAB[0];

//for (int i = 1; i < TAB.Length; i++)
//{
//    if (TAB[i] < min)
//    {
//        min = TAB[i];
//    }
//}
//Console.WriteLine(min);