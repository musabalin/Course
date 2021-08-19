using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Musa", "Fatih", "Murat" };
            string[] students2 = new string[3];
            students2[0] = "Musa";
            students2[1] = "Fatih";
            students2[2] = "Murat";
            foreach (var s in students)
            {
                Console.WriteLine(s);

            }

            //Çok boyutlu diziler
            string[,] regions = new string[3, 3]
            {
            {"İstanbul","İzmit","Tekirdağ" },
             {"Ankara","Eskişehir","Konya" },
              {"İzmir","Muğla","Denizli" }
            };
            //Get upper bound 0 x ekseninin alabileceği en yüksek değer olarak kullanılan bir metotdur.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                    
                }
                Console.WriteLine("*****************");

            }





            Console.ReadKey();
        }
    }
}
