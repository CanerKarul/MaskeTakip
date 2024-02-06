using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad = "Caner";
            //string soyad = "Karul";
            //int dogumYili = 2001;
            //long tcNo = 1234567890;

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Caner");
            SelamVer(isim: "Ahmet");
            SelamVer("Mehmet");
            SelamVer();

            int sonuc = Topla();

            // Diziler / Arrays
            //string ogrenci1 = "Caner";
            //string ogrenci2 = "Engin";
            //string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Malatya", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Caner";
            person1.LastName = "Karul";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 1;

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            //PttManager pttManager = new PttManager(new ForeignerManager());
            //pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        // Resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +  sonuc);
            return sonuc;
        }
    }

  

    // Pascal casing 
    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
