using System;

namespace Metotlar
{
    // Don t  repeat yourself !- DRY !  
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi ="Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama ="Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi ="Karpuz";
            urun2.Fiyati =80;
            urun2.Aciklama ="Diyarbakır karpuzu";

            Urun urun3 = new Urun();

            Urun[] urunler = new Urun[] { urun1 , urun2 , urun3 };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }
            Console.WriteLine("------------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();

            urun2.StokAdeti = 20;
           // urun1.StokAdeti = 5;
            sepetManager.Ekle(urun2);

            sepetManager.Ekle(urun1);
          
            



        }
    }
}
