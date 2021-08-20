using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            
            customerManager.Add();
            Console.ReadLine();

            // customerManager.Logger = new FileLogger();
            // SMS customerManager.Logger = new SMSLogger();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
             Console.WriteLine("Customer added!");
        }
    }


    class DatabaseLogger : ILogger    // bir basesi olmalı?
    {
        public void Log()
        {
            Console.WriteLine("Logged to Databe");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.Write("Logged to file! ");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.Write("Sms Logged ");
        }
    }
    interface ILogger
    {
        void Log();
    }

}
