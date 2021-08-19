using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            sql.Add();

            MySql mySql = new MySql();
            mySql.Delete();


            Console.ReadLine();
        }
    }

    //sanal metodlar ezilebilir bu sayede değişiklik yapmak istenilen metodları sanal yapıp üzerine kod yazılabilir
    //sanal metodu kullanmak içinse override yazmak gerekir
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
    class Sql : Database
    {
        public void Add()
        {
            Console.WriteLine("Added by sql");
        }


    }
    class MySql : Database
    {
        public override void Delete()
        {

            base.Delete();
        }
    }
}
