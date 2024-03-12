using System;
using UserManagment.Console.Models.Users;
using UserManagment.Console.Services;

ILogInService logInService = new LogInService();
bool isContinue = true;

do
{
    Console.Clear();
    Console.WriteLine("=== Welcome to,my project ===");
    Console.WriteLine("1. Add user");
    Console.WriteLine("2. Log In");

    Console.Write("Enter your command(i: 1 or 2):");
    string command = Console.ReadLine();

    if (command.Contains("1") is true)
    {
        Console.Clear();
        Console.WriteLine("=== Add user ===");

        User user = new User();
        Console.Write("Enter your name: ");
        user.Name = Console.ReadLine();
        Console.Write("Enter your password: ");
        user.Password = Console.ReadLine();

        logInService.AddUserInformation(user);
    }
    else if (command.Contains("2"))
    {
        Console.Clear();
        Console.WriteLine("=== Log In ===");

        User user = new User();
        Console.Write("Enter your name: ");
        user.Name = Console.ReadLine();
        Console.Write("Enter your password: ");
        user.Password = Console.ReadLine();

        logInService.LogInCheck(user);
    }

    Console.Write("Is continue(i: yes/no): ");
    string messageContinue = Console.ReadLine();

    if (messageContinue.ToLower().Contains("no") is true)
    {
        isContinue = false;
    }  
} while (isContinue is true);