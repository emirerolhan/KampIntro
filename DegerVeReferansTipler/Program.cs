using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int sayi1 = 10;
            int sayi2 = 30;
            sayi2 = 65;
            sayi1 = sayi2;
           
            Console.WriteLine(sayi1);

            // int,decimal,floot,double,bool = değer tiplerdir.
            // array " [] " , class interface = referans tiplerdir.

            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            sayilar2[0] = 666;
            Console.WriteLine(sayilar2[0]+ " " +sayilar1[0]);

        }
    }
}
