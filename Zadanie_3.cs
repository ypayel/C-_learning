// Zadanie 3
using System;
using System.Collections.Generic;

interface IPaymentMethod
{
    string MethodName { get; }
    void Pay(decimal amount);
}

class CreditCardPayment : IPaymentMethod
{
    public string MethodName => "Karta kredytowa";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Zapłacono {amount} PLN kartą kredytową.");
    }
}

class BlikPayment : IPaymentMethod
{
    public string MethodName => "BLIK";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Zapłacono {amount} PLN za pomocą BLIKa.");
    }
}

class CashPayment : IPaymentMethod
{
    public string MethodName => "Gotówka";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Zapłacono {amount} PLN gotówką.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        List<IPaymentMethod> methods = new List<IPaymentMethod>
        {
            new CreditCardPayment(),
            new BlikPayment(),
            new CashPayment()
        };

        Random rand = new Random();

        
        foreach (var method in methods)
        {
            decimal randomAmount = rand.Next(10, 500); 
            Console.WriteLine($"Metoda płatności: {method.MethodName}");
            method.Pay(randomAmount);
            Console.WriteLine();
        }
    }
}
