using System;
using System.Collections;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Hashset

            // Tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e','b','ı','i','u','ü','o','ö'
            };

            KoleksiyonYazdir(sesliHarf);
            // Ekleme

            sesliHarf.Add('a');
            KoleksiyonYazdir(sesliHarf);

            // Çıkarma

            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
                alfabe.Add((char)i);
            KoleksiyonYazdir(alfabe);

            // Türkçe'de kullanılan sesli harfler
            sesliHarf.ExceptWith(alfabe);
            KoleksiyonYazdir(sesliHarf);

            Console.ReadKey();
        }
        static void KoleksiyonYazdir(IEnumerable koleksiyon)
        {
            // Dolaşım
            Console.WriteLine();
            int i = 0;
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine(" Eleman sayısı {0}",i);
            Console.ReadKey();
        }
    }
}