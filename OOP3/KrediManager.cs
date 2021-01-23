using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interfaceleri birbirinin alternatifi olan fakat kodlari farkli olan (farkli kredi turleri icin
        //farkli geri odeme hesaplamalarinin yapilmasi gibi) durumlar icin kullanilir

        void Hesapla();
        void BiseyYap();
    }
}
