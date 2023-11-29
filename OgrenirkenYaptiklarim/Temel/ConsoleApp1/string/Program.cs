using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a praktice sentence";
            
            var result = sentence.Length;//uzunluğunu verir
            
            var result2 = sentence.Clone();//yukarıda yazdığım cümlenin klonunu oluşturdu bu sayede aşşağıda cümleyi değiştirsem dahi gene üstteki cumleyi yazacak.
            sentence = "I'm chancing the sentence.";
            Console.WriteLine(result2);

            bool result3=sentence.EndsWith("ğ");//ğ ile mi mitiyor diye kontrol ettim.//onunla mı bitiyo diye kontrol ettiriyor.
            bool result4 = sentence.StartsWith("ı");//I ile başlıyor mu?//büyk harf küçük harf önemli .
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("chancing");//chancing kelimesinin kaçıncı indexten başladığını verir.//yoksa -1 döner//ilk bulduğunu döndürür.
            var result6 = sentence.IndexOf(" ");//ilk bulduğunu döndürür.
            var result7 = sentence.LastIndexOf(" ");//sondan aramaya başlar.

            var result8 = sentence.Insert(1, " where");//yazdığın indexteki yere ekliyor.
            Console.WriteLine(result8);

            var result9 = sentence.Substring(2,5);//2. indexten itibaren al demek // 2 dahil. //2. indexten itibaren 5 tane al.
            Console.WriteLine(result9);

            var result10 = sentence.ToLower();//tüm karakterler küçüldü
            var result11 = sentence.ToUpper();//tüm karakterler büyüdü.

            var result12 = sentence.Replace(" ", "-");//bunun yerine bunu kullan demek.
            var result13 = sentence.Remove(3,4);////belirttiğin index değerinden sonrasını sil demek.//, sonrası kaç tane sileyim manasında.
            Console.WriteLine(result13);
            FormatKullanımı();//alttaki kısım için.
            Console.ReadLine();
        }
        static void FormatKullanımı()
        {
            string a = "ali";
            string b = "veli";
            Console.WriteLine(string.Format("isimleri {0} ve {1} olan kişiler ayağa kalksın.", a, b));
        }
    }
}
