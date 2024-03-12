

using System;
using UserManagment.Console.Brokers.Storages;
using UserManagment.Console.Models.Users;
using UserManagment.Console.Services;

ILogInService loginService = new LogInService();
bool res = loginService.LogInCheck(new User() { Name = "Aslann", Password = "Aslan1220"});
Console.WriteLine(res);