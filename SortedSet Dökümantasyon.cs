using System;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSetTemelleri();
            SortedSetDetayUygulama();
            DetaylıSortedSetUygulama();
        }

        private static void DetaylıSortedSetUygulama()
        {
            // Sorted Set Küme Uygulaması

            // Küme Tanımlama

            var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var B = new SortedSet<int>() { 1, 2, 5, 6 };
            // var A = new SortedSet<int>(RastgeleSayiUret(100));
            // var B = new SortedSet<int>(RastgeleSayiUret(100));


            #region Yazdırma
            // Ekrana Yazdırma
            Console.WriteLine();
            Console.WriteLine("A Kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("B Kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // Intersect (Kümelerin Kesişimleri)
            A.IntersectWith(B);
            Console.WriteLine();
            Console.WriteLine("\nA ve B Kümesinin Kesişimi:");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            // Union (Kümelerin Birleşimleri)

            A.UnionWith(B);
            Console.WriteLine();
            Console.WriteLine("A ve B Kümelerinin Birleşimi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("\nToplam Eleman Sayısı: {0}", A.Count());

            // Kesişim Dışı Elemanlar
            A.SymmetricExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\nKesişim Dışındaki Elemanlar:");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.ReadKey();
        }

        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 1000));
            return list;
        }

        private static void SortedSetDetayUygulama()
        {
            // Sorted Set Detaylı Uygulama
            var sayilar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10));
                Console.Write($"{sayilar[i],-3}");
            }

            /* Bu fonksiyon random değerler ile oluşturulan bir listedeki
               verilerden benzersiz olanlarıyla bir veri seti oluşturur.
             */

            // Listedeki Benzersiz Elemanları Bulma
            var benzersizSayiListesi =
                new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayıların listesi:\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine("Benzersiz {0} sayi var.",
                benzersizSayiListesi.Count());
            Console.ReadKey();
        }
        private static void SortedSetTemelleri()
        {
            // Sorted Set

            // Tanımlama
            var list = new SortedSet<string>();

            // Veri Ekleme

            if (list.Add("Mehmet")) // if döngüsü ile kontrollü veri ekleme
            {
                Console.WriteLine("Mehmet Eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız.");
            }
            Console.WriteLine("{0}", // Üçlü koşul ifadesi ile kontrollü veri ekleme
                list.Add("Ahmet") == true ?
                "Ahmet eklendi" : "Ekleme başarısız.");

            list.Add("Şule"); // Standart veri ekleme
            list.Add("Neslihan");
            list.Add("Abdullah");
            list.Add("Fatih");

            // Setten Veri Kaldırma

            list.Remove("Şule");

            // Where ifadesi
            list.RemoveWhere(deger => deger.Contains("A")); // Bir değere göre listeden eleman kaldırmak

            // Ekrana Yazdırma

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}