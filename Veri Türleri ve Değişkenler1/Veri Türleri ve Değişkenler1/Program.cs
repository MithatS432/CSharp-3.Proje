using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Türleri_ve_Değişkenler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tam sayılar
            int sayi1 = 100;
            long sayi2 = 1234567890123;
            short sayi3 = 32000;
            byte sayi4 = 255;

            // Ondalıklı sayılar
            float oran1 = 3.14f;
            double oran2 = 2.718281828;
            decimal oran3 = 10.75m;

            // Metin ve karakter
            string mesaj = "Merhaba C#";
            char harf = 'M';

            // Mantıksal değer
            bool durum = false;

            // Yazdırma işlemleri
            Console.WriteLine("int: " + sayi1);
            Console.WriteLine("long: " + sayi2);
            Console.WriteLine("short: " + sayi3);
            Console.WriteLine("byte: " + sayi4);
            Console.WriteLine("float: " + oran1);
            Console.WriteLine("double: " + oran2);
            Console.WriteLine("decimal: " + oran3);
            Console.WriteLine("string: " + mesaj);
            Console.WriteLine("char: " + harf);
            Console.WriteLine("bool: " + durum);
            Console.ReadLine();
        }
    }
}
