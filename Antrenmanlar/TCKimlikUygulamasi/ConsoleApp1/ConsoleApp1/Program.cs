using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            istek personel = new istek();
            Console.Write("tc gir");

            personel.ab = true;
            personel.tckimlikno = Console.ReadLine();

            while (true)
            {
                if (personel.ab == true)
                {
                    Console.WriteLine("tc kimlik numaranız : " + personel.tckimlikno + "******");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("tc yanlış 11 haneli ve tamamı rakamlardan oluşan değer giriniz:");

                    personel.tckimlikno=Console.ReadLine(); 
                }
            }
        }
    }
}
