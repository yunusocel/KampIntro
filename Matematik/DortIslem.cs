﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuc: " + sonuc);
        }

        public void Cikar(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuc: " + sonuc);
        }

        public void Carp(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuc: " + sonuc);
        }

        public void Bol(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuc: " + sonuc);
        }
    }
}
