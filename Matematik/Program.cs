using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

           
            while (true)
            {


                Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz: ");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Cikarma");
                Console.WriteLine("3-Carpma");
                Console.WriteLine("4-Bolme");
                Console.WriteLine("5-Kapat");

                int secim;
                secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("İki sayi giriniz: ");
                        Console.WriteLine("Sayi 1: ");
                        double s1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sayi 2: ");
                        double s2 = Convert.ToDouble(Console.ReadLine());
                        dortIslem.Topla(s1, s2);
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("İki sayi giriniz: ");
                        Console.WriteLine("Sayi 1: ");
                        double s3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sayi 2: ");
                        double s4 = Convert.ToDouble(Console.ReadLine());
                        dortIslem.Cikar(s3, s4);
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 3:
                        Console.WriteLine("İki sayi giriniz: ");
                        Console.WriteLine("Sayi 1: ");
                        double s5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sayi 2: ");
                        double s6 = Convert.ToDouble(Console.ReadLine());
                        dortIslem.Carp(s5, s6);
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 4:
                        Console.WriteLine("İki sayi giriniz: ");
                        Console.WriteLine("Sayi 1: ");
                        double s7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sayi 2: ");
                        double s8 = Convert.ToDouble(Console.ReadLine());
                        dortIslem.Bol(s7, s8);
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("Cikis yaptiniz..");
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Hatali tuslama yaptiniz!..");
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                }
               
            }

        }
    }
}
