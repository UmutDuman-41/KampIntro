using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManger ihtiyacKrediManager = new IhtiyacKrediManger();// Buradaki IhtiyacKrediManager yerine IKrediManager da desek olurdu.Aşağıdakiler içinde aynı şey söz konusu.
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService(); // 
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService); // burada BasvuruYap diyorki ben burada bu işi loglama yapacam o yüzden hangi loglama işini yapacağımı söyle diyor.


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
