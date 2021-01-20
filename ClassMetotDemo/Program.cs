using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var musteriler = new List<Musteri>()
            {
                new Musteri()
                {
                    Ad="Engin",
                    Soyad="Demiroğ",
                    DogumTarihi = "22.01.1986"
                },
                new Musteri()
                {
                    Ad="Salih",
                    Soyad="Demiroğ",
                    DogumTarihi = "11.12.1987"
                },
                new Musteri()
                {
                    Ad="Doğukan",
                    Soyad="Bilgin",
                    DogumTarihi="01.01.1987"
                }
            };

            MusteriManager musteriManager = new MusteriManager();

            foreach (var musteri in musteriler)
            {
                musteriManager.Add(musteri);
            }

            Console.WriteLine("\n\n---------------MÜŞTERİ LİSTESİ------------------\n\n");

            musteriManager.List(musteriler);

        }
    }
}
