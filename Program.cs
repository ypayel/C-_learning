/*W języku C#, tablice są jednym z podstawowych rodzajów kolekcji danych, które pozwalają na przechowywanie wielu elementów o tym samym typie w jednym obiekcie. Poniżej opisuję tworzenie tablic, 
    tablice wielowymiarowe, inicjalizację tablic, właściwości tablic oraz użycie tablicy z pętlą foreach.

Tworzenie tablic:
Aby utworzyć tablicę w C#, musisz określić jej typ i rozmiar. Oto ogólny sposób tworzenia tablicy:
typ[] nazwaTablicy;

*/
int[] liczby;
string[] teksty;
/*Tablice wielowymiarowe:
Tablice w C# mogą być jednowymiarowe, dwuwymiarowe lub wielowymiarowe. Oto kilka przykładów:

Jednowymiarowa tablica:*/
int[] jednowymiarowaTablica = new int[5]; // Tworzy jednowymiarową tablicę o rozmiarze 5.
int[,] dwuwymiarowaTablica = new int[3, 4]; // Tworzy dwuwymiarową tablicę 3x4.
int[,,] wielowymiarowaTablica = new int[2, 3, 4]; // Tworzy trójwymiarową tablicę 2x3x4.
/*Inicjalizacja tablic:
Tablice można zainicjować podczas ich deklaracji lub później. Oto przykłady:

Inicjalizacja podczas deklaracji (jednowymiarowa tablica):*/
int[] liczby = { 1, 2, 3, 4, 5 };

int[,] dwuwymiarowaTablica = new int[3, 2];
dwuwymiarowaTablica[0, 0] = 1;
dwuwymiarowaTablica[0, 1] = 2;
// itd.

/*Właściwości tablic:
Tablice w C# mają kilka przydatnych właściwości, takich jak Length, która zwraca liczbę elementów w tablicy. Przykład:*/
int[] liczby = { 1, 2, 3, 4, 5 };
int iloscElementow = liczby.Length; // iloscElementow będzie wynosić 5.
/*Rank: Właściwość Rank zwraca liczbę wymiarów tablicy. Jest to przydatne, gdy pracujesz z wielowymiarowymi tablicami.*/
int[,] dwuwymiarowaTablica = new int[3, 4];
int liczbaWymiarow = dwuwymiarowaTablica.Rank; // liczbaWymiarow będzie wynosić 2.
/*IsFixedSize: Właściwość IsFixedSize określa, czy tablica ma stały rozmiar (true) czy może być zmieniana (false). Stałe rozmiary mają tablice jednowymiarowe, dwuwymiarowe itp., które mają określone rozmiary podczas deklaracji.*/
int[] jednowymiarowaTablica = new int[5];
bool czyStalaTablica = jednowymiarowaTablica.IsFixedSize; // czyStalaTablica będzie wynosić true.
/*IsReadOnly: Właściwość IsReadOnly określa, czy tablica jest tylko do odczytu (true) czy można ją modyfikować (false).*/
int[] jednowymiarowaTablica = { 1, 2, 3 };
bool czyTylkoDoOdczytu = Array.IsReadOnly(jednowymiarowaTablica); // czyTylkoDoOdczytu będzie wynosić false.


/*Użycie tablicy z pętlą foreach:
Pętla foreach jest często używana do iteracji przez elementy w tablicy. Oto jak ją używać:*/
// 1 przykład
int[] liczby = { 1, 2, 3, 4, 5 };
foreach (int liczba in liczby)
{
    Console.WriteLine(liczba);
}

// 2 przykład
using System;

class Program
{
    static void Main()
    {
        int rozmiarTablicy = 5;
        int[] liczby = new int[rozmiarTablicy];

        Console.WriteLine("Podaj {0} liczb:", rozmiarTablicy);
        for (int i = 0; i < rozmiarTablicy; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int wprowadzonaLiczba))
            {
                liczby[i] = wprowadzonaLiczba;
            }
            else
            {
                Console.WriteLine("Niepoprawny format liczby. Spróbuj ponownie.");
                i--; // Powtarzamy tę iterację, aby użytkownik wprowadził poprawną liczbę.
            }
        }

        Console.WriteLine("Wprowadzone liczby:");
        foreach (int liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }
}
// 3 przykład
using System;

class Program
{
    static void Main()
    {
        string[] imiona = { "Anna", "Jan", "Katarzyna", "Marek" };

        Console.WriteLine("Długość imion:");
        foreach (string imie in imiona)
        {
            Console.WriteLine($"Długość {imie}: {imie.Length} znaków");
        }
    }
}


/*Operacje na tablicach to ważny aspekt programowania w języku C#. Pozwalają one na manipulację danymi w tablicach. Oto przykłady różnych operacji na tablicach:

Ustawianie elementów na daną wartość:
Aby ustawić wszystkie elementy w tablicy na określoną wartość, możesz użyć pętli for lub foreach. Oto przykład ustawiania wszystkich elementów w tablicy na zerową wartość:*/
int[] tablicaLiczb = new int[5];
for (int i = 0; i < tablicaLiczb.Length; i++)
{
    tablicaLiczb[i] = 0;
}

/*Kopiowanie tablic:
Możesz skopiować zawartość jednej tablicy do innej za pomocą metody Array.Copy lub poprzez użycie konstruktora kopiującego. Przykłady:*/

int[] tablica1 = { 1, 2, 3, 4, 5 };
int[] tablica2 = new int[tablica1.Length];

// Kopiowanie za pomocą Array.Copy
Array.Copy(tablica1, tablica2, tablica1.Length);

// Kopiowanie za pomocą konstruktora kopiującego
int[] tablica3 = new int[tablica1.Length];
Array.Copy(tablica1, tablica3, tablica1.Length);


/*Odwracanie tablicy:
Możesz odwrócić kolejność elementów w tablicy, używając pętli for lub metody Array.Reverse:*/
int[] tablicaLiczb = { 1, 2, 3, 4, 5 };
Array.Reverse(tablicaLiczb);

/*Sortowanie tablicy:
Aby posortować tablicę, użyj metody Array.Sort lub OrderBy w połączeniu z LINQ. Przykłady:*/
int[] tablicaLiczb = { 5, 2, 8, 1, 3 };
Array.Sort(tablicaLiczb); // Sortowanie rosnąco


int[] tablicaLiczb = { 5, 2, 8, 1, 3 };
Array.Sort(tablicaLiczb, (a, b) => a.CompareTo(b)); // Sortowanie rosnąco
Array.Sort(tablicaLiczb, (a, b) => b.CompareTo(a)); // Sortowanie malejąco


// Sortowanie za pomocą LINQ
int[] posortowanaTablica = tablicaLiczb.OrderBy(x => x).ToArray(); // Sortowanie rosnąco

int[] tablicaLiczb = { 5, 2, 8, 1, 3 };
var posortowanaTablica = tablicaLiczb.OrderBy(x => x).ToArray(); // Sortowanie rosnąco
var posortowanaTablicaMalejaco = tablicaLiczb.OrderByDescending(x => x).ToArray(); // Sortowanie malejąco


/*
Wyszukiwanie elementu w tablicy:
Aby znaleźć indeks określonego elementu w tablicy, możesz użyć metody Array.IndexOf. Przykład:*/

string[] imiona = { "Anna", "Jan", "Katarzyna", "Marek" };
int indeks = Array.IndexOf(imiona, "Katarzyna");
if (indeks >= 0)
{
    Console.WriteLine("Znaleziono Katarzynę na indeksie " + indeks);
}
else
{
    Console.WriteLine("Katarzyna nie została znaleziona w tablicy.");
}








//sortowanie

int[] tablicaLiczb = { 5, 2, 8, 1, 3 };

Console.WriteLine("Tablica przed sortowaniem:");
foreach (int liczba in tablicaLiczb)
{
    Console.Write(liczba + " ");
}
Console.WriteLine();

int n = tablicaLiczb.Length;
bool zamiana;
do
{
    zamiana = false;
    for (int i = 0; i < n - 1; i++)
    {
        if (tablicaLiczb[i] > tablicaLiczb[i + 1])
        {
            // Zamiana miejscami
            int temp = tablicaLiczb[i];
            tablicaLiczb[i] = tablicaLiczb[i + 1];
            tablicaLiczb[i + 1] = temp;
            zamiana = true;
        }
    }
} while (zamiana);

Console.WriteLine("Tablica po sortowaniu:");
foreach (int liczba in tablicaLiczb)
{
    Console.Write(liczba + " ");
}
Console.WriteLine();

