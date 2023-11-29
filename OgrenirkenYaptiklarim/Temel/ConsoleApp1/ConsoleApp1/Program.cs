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
            char karakter = 'a';
            Console.WriteLine("a nın klavyedeki sayısal değeri : " + (int)karakter);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine((int)Days.Tuesday);
            //var her veri tipini kapsar hepsi için kullanabiliyon
            Console.ReadLine();
        }
        enum Days
        {
            Monday=2,Tuesday
        }
    }
}
