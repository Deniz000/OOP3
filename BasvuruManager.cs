using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> ILoggerService ) 
        {
            //Başvuran bilgileri değerlendirme

            creditManager.Hesapla();
            foreach (var loggerService in ILoggerService)
            {
                loggerService.Log();
            }


        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler) // bana liste ver-kaç kullanımın olacak-
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }

    }
}
