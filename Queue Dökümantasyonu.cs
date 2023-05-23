using System;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            QueueHarfÖrneği();
            QueueTemelÖrnek();
        }

        private static void QueueHarfÖrneği()
        {
            // Sesli Harfleri Sırasıyla Kuyruğa Ekleyen İnteraktif Otomasyon Örneği

            // Listenin tanımlanması

            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            // Listedeki verilerin kuyruğa aktarılması

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($" Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
            }

            // Kuyruktan eleman çıkartılması

            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için 'Esc' tuşuna basınız.");
            secim = Console.ReadKey();
            Console.WriteLine();

            if (secim.Key == ConsoleKey.Escape)
            {

                Console.WriteLine();

                while (kuyruk.Count > 0)
                {
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                    Console.WriteLine($" Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
                Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı.");
            }

            Console.WriteLine("Program bitti.");

            Console.ReadKey();
        }
        private static void QueueTemelÖrnek()
        {
            // Queue

            // Tanımlama

            var karakterKuyrugu = new Queue<char>(); // Sesli harfleri tutan bir kuyruk yapısı

            // Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            karakterKuyrugu.Enqueue('i');
            karakterKuyrugu.Enqueue('ı');
            karakterKuyrugu.Enqueue('u');
            karakterKuyrugu.Enqueue('ü');
            karakterKuyrugu.Enqueue('o');
            karakterKuyrugu.Enqueue('ö');
            Console.WriteLine($"Eleman sayısı {karakterKuyrugu.Count()}");

            // Ek Bilgi

            var dizi = karakterKuyrugu.ToArray();

            // Kuyruktaki veriler doğrudan bir diziye aktarılır.

            // Çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı.");
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count()}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");


            Console.ReadKey();
        }
    }
}