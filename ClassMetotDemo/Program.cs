using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1254;
            musteri1.Isım = "Ece";
            musteri1.Soyad = "Kaya";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 5687;
            musteri2.Isım = "Isıl";
            musteri2.Soyad = "Aslan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID= " + musteri.Id);
                Console.WriteLine("ID= " + musteri.Isım);
                Console.WriteLine("ID= " + musteri.Soyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listeleme(musteri1);



            

        }
       
	

	}

    
}
