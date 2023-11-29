using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Coklu(10,20,30,30,30));
            Console.ReadLine();
        }
        static int Coklu(/*buraya başka bir şey de yazabilirsin*/ params int[] numbers)
        {
            return numbers.Sum();//toplama işlemi parametre sınırlı değil istediğin kadar yazabiliyorsun.
        }
    }
}