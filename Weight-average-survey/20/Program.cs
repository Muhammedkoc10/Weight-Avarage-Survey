using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {

            double kilo, kizortalama=0, erkekOrtalama=0, kizToplam=0, erkekToplam=0;
            int kizSayi = 0, erkekSayi = 0;

            kiloalma:
            Console.WriteLine("Cinsiyetini (e,k) olarak giriniz");
            string cinsiyet = Console.ReadLine();

            if (cinsiyet == "e")
            {
                erkekSayi++;
                Console.WriteLine("Kilonuzu giriniz");
                kilo = Convert.ToDouble(Console.ReadLine());
                erkekToplam = erkekToplam + kilo;
                erkekOrtalama = kilo / erkekSayi;
                goto kiloalma;
                

            }
            else if (cinsiyet == "k")
            {
                kizSayi = kizSayi + 1;
                Console.WriteLine("Kilonuzu giriniz");
                kilo = Convert.ToDouble(Console.ReadLine());
                kizToplam = kizToplam + kilo;
                kizortalama = kizToplam / kizSayi;
                goto kiloalma;
                
            }
            
            else
            {
                Console.WriteLine("e yada k girin");
                


            }
            Console.WriteLine("Erkeklerin kilo ortalaması = " + erkekOrtalama);
            Console.WriteLine("Kızların kilo ortalaması = " + kizortalama);
        }

    }
}
