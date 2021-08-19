using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    class Program
    {
        enum days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday

        }


        static void Main(string[] args)
        {
            //Value Types

            //16 bitlik yer kaplar
            short number1 = 32767;
            Console.WriteLine("Number1 is=" + number1);
            //32 bitlik yer kaplar 
            int number2 = 2147483647;
            Console.WriteLine("Number2 is="+ number2);

            //64 bitlik yer kaplar
            long number3 = 9223372036854775807;
            Console.WriteLine("Number3 is=" + number3);

            //8 bitlik yer kaplar
            byte number4 = 255;
            Console.WriteLine("Number4 is=" + number4);

            //Ondalıklı sayılar için kullanılan veri tipi 64 bitlik yer tutar
            double number5 = 9223372036854775807;
            Console.WriteLine("Number5 is=" + number5);

            //Double veri tipi virgülden sonra 15 tane yer tutabilir
            //Decimal 29 tane değer tutabilir 
            //sonuna m harfi koymak gerekir
            decimal number6 = 922337203685477580.8888888345m;
            Console.WriteLine("Number5 is=" + number5);

            // şart bloklarında kullanılan veri tipi doğru veya yanlış olarak tutulur
            bool condition = false;

            //karakter tutmak için kullanılan değişken tipi
            char character = 'A';




            Console.ReadKey();

        }
    }
}
