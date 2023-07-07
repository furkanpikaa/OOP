using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri() {Id = 1, MusteriNo = "123",
                Adi = "Engin", 
                Soyadi = "Demiroğ", 
                TcNo = "12345678910"
            };


            TuzelMusteri musteri2 = new TuzelMusteri() { Id = 2,
                MusteriNo = "1234", 
                SirketAdi = "Kodlama.io" ,
                VergiNo = "1234567890"
            };


            // Gerçek müşteri - Tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
