using System.Collections.Generic;
using static ConsoleApp29.Program;
using System;

namespace ConsoleApp29
{
    internal class Program
    {


        public interface IUserRegistration
        {

            void Register(string username, string password);


            bool Login(string username, string password);


            void Logout();


            bool ChangePassword(string username, string oldPassword, string newPassword);
        }


        public class User
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            public User(string username, string password)
            {
                UserName = username;
                Password = password;
            }
            public class UserRegistrationSystem : IUserRegistration


            {
                private List<User> users;
                private User loggedInUser;

                public UserRegistrationSystem()
                {
                    users = new List<User>();
                    loggedInUser = null;
                }

                // Rejestracja nowego użytkownika
                public void Register(string username, string password)
                {
                    if (users.Exists(u => u.UserName == username))
                    {
                        Console.WriteLine("Użytkownik o tej nazwie już istnieje.");
                    }
                    else
                    {
                        users.Add(new User(username, password));
                        Console.WriteLine($"Użytkownik {username} został zarejestrowany.");
                    }
                }

                // Logowanie użytkownika
                public bool Login(string username, string password)
                {
                    var user = users.Find(u => u.UserName == username && u.Password == password);
                    if (user != null)
                    {
                        loggedInUser = user;
                        Console.WriteLine($"Zalogowano jako {username}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Błędna nazwa użytkownika lub hasło.");
                        return false;
                    }
                }

                // Wylogowanie użytkownika
                public void Logout()
                {
                    if (loggedInUser != null)
                    {
                        Console.WriteLine($"Użytkownik {loggedInUser.UserName} został wylogowany.");
                        loggedInUser = null;
                    }
                    else
                    {
                        Console.WriteLine("Nie jesteś zalogowany.");
                    }
                }

                // Zmiana hasła użytkownika
                public bool ChangePassword(string username, string oldPassword, string newPassword)
                {
                    var user = users.Find(u => u.UserName == username && u.Password == oldPassword);
                    if (user != null)
                    {
                        user.Password = newPassword;
                        Console.WriteLine($"Hasło dla użytkownika {username} zostało zmienione.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Błędna nazwa użytkownika lub stare hasło.");
                        return false;
                    }
                }
            }


       
            static void Main(string[] args)
            {
                // Tworzymy system rejestracji użytkowników
                IUserRegistration registrationSystem = new UserRegistrationSystem();

                // Rejestracja nowych użytkowników
                registrationSystem.Register("user1", "password123");
                registrationSystem.Register("user2", "password456");

                Console.WriteLine();

                // Próba logowania
                registrationSystem.Login("user1", "password123");

                Console.WriteLine();

                // Próba zmiany hasła
                registrationSystem.ChangePassword("user1", "password123", "newpassword123");

                // Próba logowania po zmianie hasła
                registrationSystem.Login("user1", "newpassword123");

                Console.WriteLine();

                // Wylogowanie
                registrationSystem.Logout();

                // Próba wylogowania, gdy użytkownik nie jest zalogowany
                registrationSystem.Logout();
            }
        }
    }
}
