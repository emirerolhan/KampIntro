using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yeitştirmek Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Yeitştirmek Kampı" ,
                "Programlamaya Başlangıç için temel kurs" ,
                 "Java" , "Pyhton" ,"C++" }; 

            for (int i = 0; i < kurslar.Length ; i++)// i+=2 şeklinde de yazılabilir
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--For bitti-- ");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            } 
            Console.WriteLine("Sayfa sonu - footer ");

            Console.ReadLine();
            
        }
    }
}
