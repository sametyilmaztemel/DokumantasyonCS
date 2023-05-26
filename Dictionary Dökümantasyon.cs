using System;
using System.Collections.Generic;

namespace AkademikBirikim
{
    public class Personel // Kullanıcı taraflı personel verimiz.
    {
        public Personel(string adi, string soyadi, decimal maas) 
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi,-10} {Soyadi,-15} {Maas,-10}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            PersonelVerisiDictionaryÖrneği();
            DictionaryTemelleri();
        }

        private static void PersonelVerisiDictionaryÖrneği()
        {
            // Kullanıcı Girişi İle İşlem Yapan Dictonary Örrneği

            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsoz",7500)},
                {120, new Personel("Ahmet","Can",9000)},
            };
            personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }



            Console.ReadKey();
        }
        private static void DictionaryTemelleri()
        {
            // Dictionary
            // Telefon Kodları İçeren Sözlük Tanımı


            // Tanımlama ve Tanımlama Esnasında Ekleme
            var telefonKodlari = new Dictionary<int, string>()
            {
                {322, "Konya" },
                {424, "Elazığ" },
                {466, "Art" }, // Bilerek eksik tanımlanmıştır.
                {422, "Malatya" }
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");
            telefonKodlari.Add(212, "İstanbul");

            // Erişme ve Düzenleme 
            telefonKodlari[466] = "Artvin";

            // ContainKey (Key yardımıyla varlık kontrol etmek
            // if ifadesi olumlu sonuç aldıüı takdirde çalışmaktadır
            // bu sebepler '!' karakteri ile gelen olumsuz sonuç olan '0' '1' formatına çevrilir.
            // Böylece işlem tetiklenerek çalıştırılır.
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değildir.");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }

            // ContainsValue (Değer yardımıyla varlık kontrol etmek)
            if (!telefonKodlari.ContainsValue("Malatya")) ;
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil.");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }

            // Silme İşlemi
            telefonKodlari.Remove(322);


            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}