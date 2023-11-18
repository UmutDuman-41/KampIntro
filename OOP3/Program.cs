using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManger ihtiyacKrediManager = new IhtiyacKrediManger();// Buradaki IhtiyacKrediManager yerine IKrediManager da desek olurdu.Aşağıdakiler içinde aynı şey söz konusu.
           // ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();//Buradan anlıyoruzki:İnterfacelerde (interfaceden kastımız IKrediManager) o interface'i implemente eden classın referans numarasını tutabilir.
           // tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
           //konutKrediManager.Hesapla();



            ILoggerService databaseLoggerService = new DatabaseLoggerService();  
            ILoggerService fileLoggerService = new FileLoggerService();//Elimizde 2 tane loglayıcı var.Biri üstteki,biri de buradaki.Aşağıda biz databaseLoggerService'i seçtik.

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());//Alttaki ile aynı kullanım.
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService); // burada BasvuruYap diyorki ben burada bu işi loglama yapacam o yüzden hangi loglama işini yapacağımı söyle diyor.
            //BasvuruYap fonk.una konutKrediManager yollanınca onun için işlem yapılacak.
            //Yukarıdaki kodun açıklaması:BasvuruYap , konutKredisine göre ve loglamayı veri tabanına yapacak şekilde.
            basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager }; //Buraya istediğin kadar kredi gönderebilirsin.BasvuruManager'daki foreach hepsini dolaşacaktır.

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
