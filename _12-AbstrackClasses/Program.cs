using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AbstrackClasses
{
    class Program
    {

        //Abstrack classlar interface ile virtual metodların birleşimi diyebiliriz
        static void Main(string[] args)
        {
            Database database = new Sql();
            database.Add();
            database.Delete();
            Database database1 = new MySql();
            database1.Add();
            database1.Delete();

            Console.ReadKey();

        }
        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by Defult");
            }
            public abstract void Delete();
        }

        private class Sql : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Added by Abstrack");
            }
        }
        private class MySql : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Added by Abstrack");
            }
        }

    }
}
