using System;

// Interfejs dla systemu zarządzania bankiem
public interface IBankAccount
{
    void Deposit(decimal amount);
    bool Withdraw(decimal amount);
    decimal GetBalance();
}

// Implementacja interfejsu w klasie konta bankowego
public class BankAccount : IBankAccount
{
    private decimal _balance;
    private readonly string _accountNumber;

    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        _accountNumber = accountNumber;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Kwota wpłaty musi być większa od zera.");
            return;
        }
        _balance += amount;
        Console.WriteLine($"Wpłacono: {amount:C}. Nowe saldo: {_balance:C}");
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Kwota wypłaty musi być większa od zera.");
            return false;
        }
        if (amount > _balance)
        {
            Console.WriteLine("Niewystarczające środki na koncie.");
            return false;
        }
        _balance -= amount;
        Console.WriteLine($"Wypłacono: {amount:C}. Nowe saldo: {_balance:C}");
        return true;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}

// Przykładowe użycie klasy BankAccount
class Program
{
    static void Main()
    {
        IBankAccount account = new BankAccount("1234567890", 1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Aktualne saldo: {account.GetBalance():C}");
    }
}