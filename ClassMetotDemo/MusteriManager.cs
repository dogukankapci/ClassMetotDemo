using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        // Müşteri eklendiğinde bilgi verecek olan metot.
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı müşteri eklendi.");
        }

        // Müşterileri listeleyecek olan metot.
        public void List(List<Musteri> musteri)
        {
            Console.WriteLine("Müşteri Adı\t" + "Müşteri Soyadı\t" + "Müşteri Doğum Tarihi");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var person in musteri)
            {
                Console.WriteLine(person.Ad + "\t\t" + person.Soyad + "\t\t" + person.DogumTarihi);
            }
        }

    }
}
