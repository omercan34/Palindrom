using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ö.d_Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            string cevir;
            Console.Write("kelime giriniz (q çıkış):");
            kelime = Console.ReadLine();
            while (kelime != "q")
            {

                cevir = ceviri(kelime);
                if (kelime == cevir)
                {
                    Console.WriteLine("Girdiğiniz kelime palindromdur.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kelime palindrom değildir.");
                }
                Console.Write("kelime giriniz (q çıkış):");
                kelime = Console.ReadLine();

            }






        }
        static string ceviri(string kelime)
        {

            char[] metindizi = kelime.ToCharArray();                // char tipinde bir array tanımladık girilen kelimeyi harflerine ayırdık
            Array.Reverse(metindizi);                              // metin dizisini tersten sıraladık
            string donenmetin = new string(metindizi);            //metin dizisini stringe çevirdik yeni bir değişkene atadık
            return donenmetin;                                   //atadığımız değişkeni fonksiyonun çıktsı

        }
    }
}
