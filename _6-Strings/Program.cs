using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringler bir char dizisidir.

            Intro();
            string sentence = "My name is musa";
            var result = sentence.Length;//metnin sayısını bulur
            var result2 = sentence.Clone();//metnin klonunu oluşturur.
            var result3 = sentence.EndsWith("a");//metin a ile mi bitiyor
            var result4 = sentence.StartsWith("My");//metin my ile mi başlıyor
            var result5 = sentence.Insert(0, "Hello");//0dan başla ve tırnak içindekini ekle
            var result6 = sentence.Substring(0, 6);//0dan başla 6 karakter al demektir
            var result7 = sentence.ToLower();//hepsini küçültür
            var result8 = sentence.ToUpper();//hepsini büyütür
            var result9 = sentence.Replace(" ", "-");//ilk parametrede olanı ikinci parametre ile değiştir


            Console.ReadKey();
        }

        private static void Intro()
        {
            string city = "Ankara";
            foreach (var i in city)
            {
                Console.WriteLine(i);
            }
        }
    }
}
