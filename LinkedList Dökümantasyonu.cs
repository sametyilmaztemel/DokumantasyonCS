using System;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListÖrnekleri();
        }

        private static void LinkedListÖrnekleri()
        {
            // LinkedList<T> Temelleri

            // Linkedlist yardımıyla yolculuk güzergahı örneği

            // Tanımlama

            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun"); // AddAfter komutu ile kendisinden sonrasına ekleme yapabiliriz.
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); // Next/Previous komutları ile belirli key değerler arasında gezebiliriz.
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak"); // Find parametresi ile istediğimiz key değeri bulup after/before parametreleri ile veri eklemesi yapabiliriz.

            // Mevcut güzergahı gidiş dönüş olarak ayarlamak

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");

            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }

            Console.ReadKey();
        }
    }
}