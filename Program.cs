

using UserManagment.Console.Brokers.Storages;
using UserManagment.Console.Models.Users;

IStorageBroker broker = new FileStorageBroker();
broker.AddUser(new User() { Name = "Aslanbek", Password = "Aslan1220"});