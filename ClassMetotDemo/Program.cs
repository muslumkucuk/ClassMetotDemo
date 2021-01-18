using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteri = new Musteri[] { };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle("Müslüm" , "Küçük" , 123231); 
        }
    }
}
