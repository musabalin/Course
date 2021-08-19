using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is ten");
            }
            else
            {
                Console.WriteLine("Number is not ten");
            }


            // Single Line if
            var number2 = 11;
            Console.WriteLine(number2 == 10 ? "Number2 is ten" : "Number2 is not ten");

            //Switch/Case
            var number3 = 11;
            switch (number3)
            {
                case 10:
                    Console.WriteLine("Number is ten");
                    break;
                case 11:
                    Console.WriteLine("Number is eleven");
                    break;
                default:
                    Console.WriteLine("Number is not ten or eleven");
                    break;
            }


            var number4 = 12;

            if (number4 >= 0 && number4 <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number4 > 100 && number4 <= 200)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else
            {
                Console.WriteLine("Number is no between 0-200");
            }
            Console.ReadKey();

        }
    }
}
