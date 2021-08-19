using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Forloops();
            whileloops();
            ForEachLoops();
            Console.WriteLine("Sayı asal mı=" + isPrimeNumber(7));


            Console.ReadKey();
        }

        private static void ForEachLoops()
        {
            string[] students = { "Musa", "Fatih", "Murat" };
            foreach (var s in students)
            {
                Console.WriteLine(s);

            }

        }

        private static void whileloops()
        {
            int k = 0;
            while (k <= 100)
            {
                Console.WriteLine(k);
                k++;

            }
        }

        private static void Forloops()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

        //asal sayı bulan metod
        private static bool isPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    return result = false;
                    i = number;
                }

            }
            return result;
        }
    }
}
