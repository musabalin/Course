using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(15, 10);
            Console.WriteLine("Result=" + result);

            Console.WriteLine(multiply(2, 4));
            Console.WriteLine(multiply(2, 4,2));
            Console.WriteLine(Add4(2, 4, 7, 9, 11));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1 = 0, int number2 = 0)
        {
            var result = number2 + number1;
            return result;
        }
        static int Add3(int n1, int n2)
        {
            return n1 + n2;
        }

        //Method Overloading
        static int  multiply(int n1,int n2)
        {
            return n1 * n2;

        }
        static int multiply(int n1,int n2,int n3)
        {
            return n1 * n2 * n3;
        }

        //Params
        static int Add4(params int[] number)
        {
            return number.Sum();
        }
    }
}
