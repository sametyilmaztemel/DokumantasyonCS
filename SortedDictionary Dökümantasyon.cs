using System;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedDictionaryÖrneği(); 
        }

        private static void SortedDictionaryÖrneği()
        {
            // Sorted Dictionary
            // Kitap İndeksi Örneği

            // Tanımlama

            var kitapIndeks =
                new SortedDictionary<string, List<int>>()
                {
                    {"HTML", new List<int>() {8,10,12} },
                    {"CSS", new List<int>() {70,80,90} },
                    {"JQuery", new List<int>() {3,5,15} },
                    {"SQL", new List<int>() {70,80} }
                };

            // Kayıt Eklemek
            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });

            // Dolaşım ve Yazdırma

            foreach (var kavramlar in kitapIndeks)
            {
                Console.WriteLine(kavramlar.Key);
                foreach (var s in kavramlar.Value)
                {
                    Console.WriteLine($"\t > {s} pp");
                }
                /*
                 Alternatif olarak 33. Satıra kavram.Value.ForEach(s => Console.WriteLine("\t  >" + s));
                 Kullanılabilir.
                 */

            }
            Console.ReadKey();
        }
    }
}