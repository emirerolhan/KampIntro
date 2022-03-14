using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety - tip güvenliği
            // Do not repeat yourself! - kendini tekarlama! 
            string kategorietiketi = "Kategori";

            Console.WriteLine(kategorietiketi);
            int ogrenciSayisi = 32000;
            double faizoranı = 1.45;
            bool sistemeGirisYapmismi = false ; // True yada False kullanılır.
            double DolarDün =7.0;
            double DolarBugün =7.30;
            if (DolarDün>DolarBugün)
            {
                double degisim = ((DolarDün-DolarBugün) * 100) / DolarDün;
                Console.WriteLine("-"+degisim+"%");
            }
            else if (DolarDün<DolarBugün)
            {
                double degisim = ((DolarBugün - DolarDün)*100)/DolarDün;
                Console.WriteLine("+"+degisim+"%");
            }
            else
            {
                double degisim = ((DolarBugün - DolarDün) * 100) / DolarDün;
                Console.WriteLine("="+degisim+"%");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("[Ayarlar]");
            }
            else
            {
                Console.WriteLine("[Giriş Yap]");
            }
                                             

            
            Console.ReadLine();

        }
    }
}
