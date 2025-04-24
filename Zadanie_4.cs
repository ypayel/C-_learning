//Zadanie 4


using System;
using System.Globalization;

class Punkt
{
    public double x;
    public double y;

    public Punkt(double x = 0, double y = 0)
    {
        this.x = x;
        this.y = y;
    }

   
    public double Dystans(Punkt p)
    {
        return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
    }

    
    public double Dystans()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public override string ToString()
    {
        return $"Punkt ({x}, {y})";
    }
}

class Linia
{
    private int ile;
    private Punkt[] punkty;

    
    public Linia(int ile)
    {
        this.ile = ile;
        punkty = new Punkt[ile];
        for (int i = 0; i < ile; i++)
        {
            punkty[i] = new Punkt();
        }
    }


    public Linia(Linia inna)
    {
        this.ile = inna.ile;
        punkty = new Punkt[ile];
        for (int i = 0; i < ile; i++)
        {
            punkty[i] = new Punkt(inna.punkty[i].x, inna.punkty[i].y);
        }
    }

    public void Wczytaj()
    {
        for (int i = 0; i < ile; i++)
        {
            Console.Write($"Wsp (x, y) punktu {i + 1} : ");
            string input = Console.ReadLine();
            string[] parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double x = double.Parse(parts[0], CultureInfo.InvariantCulture);
            double y = double.Parse(parts[1], CultureInfo.InvariantCulture);

            punkty[i] = new Punkt(x, y);
        }
    }

   
    public double Dlugosc()
    {
        double suma = 0;
        for (int i = 0; i < ile - 1; i++)
        {
            suma += punkty[i].Dystans(punkty[i + 1]);
        }
        return suma;
    }

    
    public void Wyswietl()
    {
        Console.WriteLine($"Linia Ilosc punktow {ile}");
        for (int i = 0; i < ile; i++)
        {
            Console.WriteLine($"{i + 1}: {punkty[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile punktów ? ");
        int ile = int.Parse(Console.ReadLine());

        Linia linia = new Linia(ile);

        linia.Wczytaj();

        double dl = linia.Dlugosc();
        Console.WriteLine($"Dlugosc linii {dl:F4}");

        linia.Wyswietl();
    }
}
