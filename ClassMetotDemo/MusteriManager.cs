using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri bilgileri eklendi.\n");
        }
        public void Sil (Musteri musteri)
        {

            Console.WriteLine("Müşteri bilgileri silindi.\n");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ "\n" +musteri.Isım+   "\n" + musteri.Soyad);

        }

    }
}
