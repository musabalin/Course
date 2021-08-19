using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Update();
            customerManager.Add();
            ProductManager productManager = new ProductManager();



            //Customer classındaki propertylere ekleme  1
            Customer customer = new Customer();
            customer.FirstName = "Musa";
            customer.LastName = "Balın";
            customer.Id = 1;
            customer.City = "İzmir";
            //Customer classındaki propertylere ekleme 2
            Customer customer1 = new Customer() { FirstName = "Kadir", LastName = "Baş", City = "Antalya", Id = 2 };



            Console.ReadKey();
        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added..");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated..");
            }
        }

    }
}
