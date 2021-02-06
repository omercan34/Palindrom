using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ö.d_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 1;                                  //  sonuc diye bir değişken tanımladık.
            int sayi;                                      //  sayi diye bir değişken tanımladık.
            Console.Write("Birinci sayı giriniz:");        // girilen veriyi ekrana yazdırır.
            sayi = int.Parse(Console.ReadLine());         //  girilen değeri int çevirir sayı değişkene atar.

            if (sayi > 0)                                 // sayının büyük olup olmadığını kontrol eder.
            {
                for (int i = 1; i <= sayi; i++)           // for döngüsü belirli bir başlangıç, adım ve bitiş değeri(şart) ile işlemleri gerçekleştirmek için kullanılan bir döngüdür.
                {
                    sonuc = sonuc * i;                    //  çarpma  komotu yaztık.
                    Console.Write("çarpım" + i + "*");      // girilen veriyi ekrana yazdırır.
                }
                Console.WriteLine("Sonuc:" + sonuc);     // girilen veriyi ekrana yazdırır.
            }

            Console.ReadKey();
        }
    }
}
