using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.Console.Models.Users;

namespace UserManagment.Console.Brokers.Storages
{
    internal interface IStorageBroker
    {
        User AddUser(User user);
    }
}
