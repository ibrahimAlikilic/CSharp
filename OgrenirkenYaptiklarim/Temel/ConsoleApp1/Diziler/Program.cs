using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            names[0] = "ali";
            names[1] = "veli";

            foreach (var isimler in names)
            {
                Console.WriteLine(isimler);
            }
            Console.WriteLine("***************************");

            string[] values = new[] { "böyle", "de", "olur" }; //new[] kısmı olmadan da olur
            Console.WriteLine(values[1]);//kaçıncı index yazdırmak istediğin böyle.

            foreach (var değerler in values)
            {
                Console.WriteLine(değerler);
            }

            string[,] regions = new string[7, 3]// 7 bölge her bölgede 3 şehir var 7 satır 3 sütun diye de düşünebilirsin.
            {
                {"İstanbul","sakarya","Kocaeli"},
                {"a","b","c"},
                {"a","b","c" },
                {"a","b","c" },
                {"a","b","c" },
                {"a","b","c" },
                {"a","b","c" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)//her satırı gezdirme anlamında kullanılıyor.//ilk boyuttaki son dizin// 0 virgül öncesi
            {//index olarak düşünürler o yüzden <= kullanıyoruz.
                for (int j = 0; j <= regions.GetUpperBound(1); j++)//bu da tütunlar için.//1 virgül sonrası
                {
                    Console.WriteLine(regions[i,j]);
                    Console.WriteLine("**********************");
                }

            }



            Console.ReadLine();
        }
    }
}
