using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //    CustomerManager customerManager = new CustomerManager(30);
            //    customerManager.List();
            //    EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            //    employeeManager.Add();

            Person p = new Person("Product");
            p.Add();
           


            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {

            Console.WriteLine("{0} item listed.", _count);
        }
    }
    class Product
    {
        private string _name;
        private int _Id;
        public Product(int Id, string name)
        {
            _Id = Id;
            _name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class EmployeeManager
    {

        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
            
        }

        public void Add()
        {
            _logger.log();
            Console.WriteLine("Added");
        }
    }

    interface ILogger
    {
        void log();

    }
    class DatabaseLogger : ILogger
    {
        void ILogger.log()
        {
            Console.WriteLine("Logged To database");
        }
    }
    class FileLogger : ILogger
    {
        void ILogger.log()
        {
            Console.WriteLine("Logged To File");
        }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }

    }
    class Person : BaseClass
    {
        public Person(string entity) :base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
            
        }

    }

}
