using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,double,bool,float -> deger tipi
            //array,class,interface -> referans tipi

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999

            int[] sayilar3 = { 10, 20, 30 };
            int[] sayilar4 = { 100, 200, 300 };
            sayilar3 = sayilar4;
            sayilar4[0] = 999;
            Console.WriteLine(sayilar3[0]); //999

        }
    }
}
