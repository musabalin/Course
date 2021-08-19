using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Logger = new SmsLogger();
            customer.Add();
            Console.ReadLine();
        }
    }
    class Customer
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added.!");
        }
    }


    class DatabaseLogger : ILogger
    {
        void ILogger.Log()
        {
            Console.WriteLine("Logged to database!!");
        }
    }

    class FileLogger : ILogger
    {
        void ILogger.Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    interface ILogger
    {
        void Log();

    }
    class SmsLogger : ILogger
    {
        void ILogger.Log()
        {
            Console.WriteLine("Logged to database!!");
        }
    }
}
