using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.Console.Models.Users;

namespace UserManagment.Console.Brokers.Storages
{
    internal class FileStorageBroker : IStorageBroker
    {
        private const string FilePath = "../../../Assets/Users.txt";

        public FileStorageBroker()
        {
            EnsureFileExists();
        }

        public User AddUser(User user)
        {
            string[] userLines = File.ReadAllLines(FilePath);

            for (int itaration = 0; itaration < userLines.Length; itaration++)
            {
                string userLine = userLines[itaration];
                string[] userInfo = userLine.Split('|');

                if (userInfo[0].Contains(user.Name)
                    && userInfo[1].Contains(user.Password))
                {
                    return new User();
                }
            }

            string userNewLine = $"{user.Name}|{user.Password}\n";
            File.AppendAllText(FilePath,userNewLine);
            return user;
        }

        private void EnsureFileExists()
        {
            bool fileExists = File.Exists(FilePath);

            if (fileExists is false) 
            {
                File.Create(FilePath).Close();
            }
        }
    }
}
