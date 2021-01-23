using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
            //Method injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Basvuran bilgilerini degerlendirme..
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); Butun basvurulari konut kredisi uzerinden hesaplamis olursun, dogru degil!!!
          
            krediManager.Hesapla(); //IKrediManager hepsini kapsadigi icin
                                    //senin gonderdigin kredi turune gore
                                    //hesaplama yapar.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
