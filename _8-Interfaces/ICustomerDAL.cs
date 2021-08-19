using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interfaces
{

    //Interface tanımlayıp burda ekleme silme ve güncelleme işlemi yaptık daha sonra aşağıda interfaceden sınıflar türeterek
    //farklı database(sql/oracle)'e göre sınıflar türettik bu sayede birden fazla database destekliyor.
    interface ICustomerDAL
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomer : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Added");
        }
    }
    class OracleServerCustomer : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Added");
        }
    }
    class CustomerManager
    {
        //parametre olarak IcustomerDal verdik bu sayede iki veritabanına göre de ekleme yapabiliyoruz.
        public void Add(ICustomerDAL customer)
        {
            customer.Add();
        }
    }
}
