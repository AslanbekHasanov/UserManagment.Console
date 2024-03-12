using System;
using UserManagment.Console.Brokers.Loggings;
using UserManagment.Console.Brokers.Storages;
using UserManagment.Console.Models.Users;

namespace UserManagment.Console.Services
{
    internal class LoginService : ILoginService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStorageBroker storageBroker;

        public LoginService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storageBroker = new FileStorageBroker();
        }

        public User AddUserInformation(User user)
        {
            try
            {
                return user is null
                    ? CreateAndLogInvalidUser()
                    : ValidateAndAddUserInformation(user);
            }
            catch (Exception exception)
            {
                this.loggingBroker.LogError(exception);
                return new User();
            }
        }

        private User CreateAndLogInvalidUser()
        {
            this.loggingBroker.LogError("User is invalid!");
            return new User();
        }

        private User ValidateAndAddUserInformation(User user)
        {
            if (String.IsNullOrWhiteSpace(user.Name)
                || String.IsNullOrWhiteSpace(user.Password))
            {
                this.loggingBroker.LogError("User details are missing.");
                return new User();
            }
            else
            {
                User addUser = this.storageBroker.AddUser(user);

                if ( addUser is null)
                {
                    this.loggingBroker.LogInformation("The information is available in the file.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Information has been added to the file.");
                }

                return addUser;
            }
        }
    }
}
