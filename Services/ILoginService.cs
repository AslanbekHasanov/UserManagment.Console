using UserManagment.Console.Models.Users;

namespace UserManagment.Console.Services
{
    internal interface ILogInService
    {
        User AddUserInformation(User user);
        bool LogInCheck(User user);
    }
}
