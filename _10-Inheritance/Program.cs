using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
               new customer{ FirstName="Musa"},
               new student{FirstName="Bilal" },
               new Person{ FirstName="İsmail"},
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();

        }

        //Kalıtım(Inhertance) arabirim(interface)den farklı yanı arabirim tek başına bir anlam ifade etmezken
        //kalıtım tek başına kullanılabilir.
        //Nesnelere birden fazla interface verilebilir fakat kalıtımlar verilmez
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class customer:Person
        {
            public string Adress { get; set; }
        }
        class student : Person
        {
            public string Department { get; set; }
        }
        
    }
}
