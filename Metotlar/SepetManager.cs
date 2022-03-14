using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            if (urun.StokAdeti == 0)
            {
                Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi +
                " + " + urun.Fiyati + " TL  " + " Stok yok yada değer girilmemiş");
            }
            else
            {
                Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi +
                " + " + urun.Fiyati + " TL  " +"Stok = " + urun.StokAdeti);
            }
        }

        public void Ekle2( string urunAdi, string aciklama , double fiyati)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi + " + " + fiyati + " TL  ");

        }

       
    }
}
