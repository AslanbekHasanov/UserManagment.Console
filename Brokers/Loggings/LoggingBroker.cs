using System;

namespace UserManagment.Console.Brokers.Loggings
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogInformation(string message)=>
            System.Console.WriteLine(message);

        public void LogError(string userMessage)=>
            System.Console.WriteLine(userMessage);

        public void LogError(Exception exaption)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(exaption.Message);
        }
    }
}
