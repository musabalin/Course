using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arraylist();

            List<string> cities = new List<string>();
            cities.Add("Ankara");
            Console.ReadLine();

        }

        private static void Arraylist()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("Uşak");
            cities.Add("Ankara");
            cities.Add("İzmir");
            cities.Add("İstanbul");
            cities.Add(10);
            cities.Add('A');
            cities.Add(1.470);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
