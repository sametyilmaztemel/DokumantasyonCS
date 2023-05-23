using System;
using System.Collections;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackSayıİşlemi();
            StackİşlemleriÖrnek();
            StackÖrneği();
        }

        private static void StackSayıİşlemi()
        {
            // Stack Yardımıyla Girilen Sayı Üzerinden İşlem Yapan Fonksiyon

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            // Girilen sayıdaki basamakların tek tek yığına eklemek.

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            // Girilen sayı yığınının basamak sayısının hesaplamak.
            int i = 0;
            int n = sayiYigini.Count - 1;

            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10, n - i),7}\t= " +
                    $"{s * Math.Pow(10, n - i),7}");
                i++;
            }

            Console.ReadKey();
        }
        private static void StackİşlemleriÖrnek()
        {
            // Stack ASCII Kod Tanımlama Örneği

            // Stack Tanımlama
            var karakterYigini = new Stack<char>();

            // For Döngüsü İle ASCII Karakterleri Yığına Ekleme
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
            Console.ReadKey();
            Console.WriteLine();

            // Ek Bilgi

            var dizi = karakterYigini.ToArray();
            // Yığınımızı diziye aktarmak için kullanılabilir.

            // Yığından Çıkartma İşlemi

            while (karakterYigini.Count > 0) // Yığında bir veri olduğu sürece işlem devam eder.
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkartıldı.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }

            Console.ReadKey();
        }
        private static void StackÖrneği()
        {
            // Stack Tanımlama
            var karakterYigini = new Stack<char>();

            // Stack Ekleme

            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());

            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek()); // Ekleme işlemini görmemizi sağlar.

            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            // 3 Karakter Sırasıyla Eklenmiştir En Üstte C İfadesi Bulunur.
            // Ekleme sırasının tersine göre çıkarma işlemi yapılır.


            // Stack Çıkarma

            // Pop ifadesi çıkartma işlemini gerçekleştirirken çıkartılan karakteri çıktı olarak döndürür.
            // Bu sayede cw yardımıyla çıkartılan karakteri ekrana yazdırabiliriz.

            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");


            Console.ReadKey();
        }
    }
}