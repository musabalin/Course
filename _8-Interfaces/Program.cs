using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfacesIntermediate();



            //Interfaceden bir nesne dizisi türettik ve içine veritabanlarını ekledik bu sayede 
            //her iki veritabanına birden tek kod ile ekleme ve diğer işlemleri yapabiliriz.
            ICustomerDAL[] customer = new ICustomerDAL[2]{
               new SqlServerCustomer(),
               new OracleServerCustomer()
            };


            foreach (var customerDAL in customer)
            {
                customerDAL.Add();
            }

            Console.ReadLine();



        }

        private static void InterfacesIntermediate()
        {
            CustomerManager customerManager = new CustomerManager();
            //Oracle veritabanına göre ekleme
            customerManager.Add(new OracleServerCustomer());
            //Sql Veritabanına göre ekleme
            customerManager.Add(new SqlServerCustomer());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer { FirstName = "Musa", LastName = "Balın", Id = 1, Adress = "İzmir" };
            Student student = new Student { FirstName = "Ahmet", LastName = "Yurt", Id = 1, Department = "Marketing" };

            PersonManager manager = new PersonManager();
            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

            //Bu şekilde sadece customer kullanılabilirken
            //Interface ile beraber türetildiği zaman interfacenin alt 
            //kümesi olan customer ve student de kullanılabilir yukarıdaki gibi
            //Aşağıdaki metodu sadece customer kullanır.
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
