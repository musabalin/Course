using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[2] { "Musa", "Hakkı" };
                students[3] = "Kazım";

            }
            catch (Exception e)
            {
                Console.WriteLine("Hata var");
                //Bu kısım kullanıcıya gösterilmez
                //Sebebi bu tür hatalar programın çözülmesini sağlar
                //bunu loglarız ve sistemin nerelerde ne zaman hata verdiğini görüp problemi çözeriz
                Console.WriteLine(e.Message);
                //Daha detaylo bilgi için
                Console.WriteLine(e.InnerException);
            }
            Console.ReadKey();
        }
    }
}
