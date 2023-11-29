using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_AsalSayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Console.Write("değer gir:");
            int deger=Convert.ToInt32(Console.ReadLine());
            for (int i = deger-1; i>1; i--)
            {
                if (deger % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }
            if (kontrol == true)
            {
                Console.WriteLine(deger+" asal sayıdır.");
            }
            else
            {
                Console.WriteLine(deger+ " asal sayı değildir.");
            }
            Console.ReadLine();
        }
    }
}
