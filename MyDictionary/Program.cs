using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> il = new Dictionary<int, string>();
            //il.Add(1, "Adana");
            //il.Add(42, "Konya");
            //il.Add(43, "Kütahya");
            //il.Add(46, "KahramanMaraş");
            //il.Add(65, "Van");

            //Console.WriteLine("Plaka Giriniz:");
            //int plaka = int.Parse(Console.ReadLine());
            //try
            //{
            //    Console.WriteLine(il[plaka]);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Girilen Plakaya Ait Bir Şehir Bulunamadı");
            //}

            mydictionary<int, string> ogrenci = new mydictionary<int, string>();
            ogrenci.Add(12, "Yasin");
            ogrenci.Add(18, "Yaman");
            ogrenci.Add(25, "Çınar");
            Console.WriteLine(ogrenci.Length);
            
           



        }
    }
}
