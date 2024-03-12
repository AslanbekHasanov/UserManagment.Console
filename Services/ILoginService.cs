using UserManagment.Console.Models.Users;

namespace UserManagment.Console.Services
{
    internal interface ILoginService
    {
        User AddUserInformation(User user);
    }
}
