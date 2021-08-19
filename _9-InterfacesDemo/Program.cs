using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Robots(),
                new Manager()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            //Yemek yeme yönetici ve işçilere özel bir durum olduğu için robotlar dahil edilmedi
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadKey();



        }
        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }

        class Worker : IEat, ISalary, IWorker
        {
            public void Eat()
            {
                Console.WriteLine("Yemek Ye");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {

                Console.WriteLine("Çalış");
            }
        }
        class Manager : IEat, ISalary, IWorker
        {
            public void Eat()
            {
                Console.WriteLine("Yemek Ye");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                
                Console.WriteLine("Çalış");
            }
        }
        class Robots : IWorker
        {
           
            public void Work()
            {
                Console.WriteLine("Çalış");
            }
        }
    }
}
