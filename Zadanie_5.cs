//Zadanie 5

using System;
using System.Reflection;
using System.Text.Json;

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

class Program
{
    public static void PrintProperties(object obj)
    {
        Type type = obj.GetType();
        Console.WriteLine($"Typ obiektu: {type.Name}");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        foreach (var field in fields)
        {
            string name = field.Name;
            object value = field.GetValue(obj);
            Console.WriteLine($"{name} = {value}");
        }
    }

    static void Main(string[] args)
    {
       
        Person person = new Person("Jan", "Kowalski", 30);

        Console.WriteLine("Refleksja: Pola i wartości ");
        PrintProperties(person);

       
        string json = JsonSerializer.Serialize(person);
        Console.WriteLine("Serializacja JSON");
        Console.WriteLine(json);

        Person deserialized = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine("Obiekt po deserializacji");
        PrintProperties(deserialized);
    }
}
