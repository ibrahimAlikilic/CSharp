using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEthods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            int say1 = Convert.ToInt32(Console.ReadLine());
            int say2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = mat(say1);
            int sonuc2 = mat(say1, say2, 10);
            Console.WriteLine(sonuc2 + " bu");
            Console.WriteLine(sonuc);

            int number1 = 30;
            int number2 = 25;
            var sonucOgren = RefOgren(ref number1, number2);
            Console.WriteLine(number1);

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("First Add");
        }
        static int mat(int a, int b=30)//b verilmezse 30 kullan demek.
        {
            //return a + b; böyle de gösterilir
            var result = a + b;
            return result ;
        }
        static int mat(int a, int b , int c=1)// aynı isimde verip bir şey daha ekleyebilirsin ders 26 ( https://www.youtube.com/watch?v=S8WBMvV7ngc&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=27 )
        {
            //return a + b; böyle de gösterilir
            var result = a * b * c;
            return result;
        }

        static int RefOgren(ref int number1, int number2)//ref kullanınca buradaki değeri kullanır yoksa nerede tanımlarsan orası (ders 24 (https://www.youtube.com/watch?v=rSsrJu5dWec&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=26))
       //ref olunca yukarıda number1=? bir değer atamalısın out yazarsan sadece int number1; desen yeter. 
        {
           // number1 = 45;açarsan bunu alır açmazsan yukarıda tamamladın zaten if bloklarında faydalı olur
            return number1+ number2;
        }
    }
}
