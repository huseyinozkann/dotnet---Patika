﻿using System;

namespace array{
    class Program{
        static void Main(){
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değere atama
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Conosle.WriteLine("Lütfen dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for(int i=0;i<diziUzunlugu;i++){
                Console.Write("Lütfen {0}. sayıyı giriniz :", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayıDizisi)
            toplam+=sayi;
            Console.WriteLine("Ortalama :"+toplam / diziUzunlugu);
        }
    }
}
