using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin demiroğ";
            kurs1.IzlenmeOrani =68;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Pyhton";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);
            //Console.WriteLine(kurs1.IzlenmeOrani + " " +kurs2.IzlenmeOrani );

            Kurs[] kurslar = new Kurs[]
            {kurs1 , kurs2 , kurs3};

            foreach (Kurs kurss in kurslar)
            {
                Console.WriteLine(("Kurs Adı "+kurss.KursAdi) + " " 
                    + "Kurs Eğitmen Adı " + (kurss.KursunEgitmeni) + " " 
                    + "Tamamlanan Kısım " + (kurss.IzlenmeOrani + "%"));
            }
            
            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        //prop yazıp çift TAB basarak public string yazabiliriz

        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }

}
