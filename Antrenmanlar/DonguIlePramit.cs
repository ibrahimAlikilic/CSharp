using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i =10; i > 0 ; i--)
            {
                for (int j=1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < a; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

                a = a + 2;
            }
            Console.WriteLine("20.06");
            Console.WriteLine("07.07.2022");
            Console.WriteLine("İALK tarafından yapıldı.");
            Console.ReadLine();
            
        }
    }
}
