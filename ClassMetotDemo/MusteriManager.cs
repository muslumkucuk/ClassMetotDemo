using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Belirttiğiniz Tckn,Ad ve Soyad'ı taşıyan müşteri sisteme başarıyla eklenmiştir: ");
            Console.WriteLine("-------------------------------------------------------------------------------");
        }

    }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Belirttiğiniz Tckn,Ad ve Soyad'ı taşıyan müşteri sistemden başarıyla silinmiştir.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        public void MusterileriListele()
        {
            foreach (Musteri aaa in Musteri)
            {
                Console.WriteLine(aaa.Tckn);
            }
        }
    }
