using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //burada biz aşağıda yani, method injection yapıyoruz.Yani bu metodun kullanacağı kredi managerın ne olacağını yani hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        //LOGLAMA:Kim ne zaman hangi operasyonu çağırdıdır.Yani birnevi o sistemde olan hareketleri döktüğümüz bir dökümdür.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)// buraya hangi krediyi yollarsak(yani IhtiyacKrediManager,KonutKrediManager...)onun bellekteki Hesapla' sı çalışır.
        {                                                                               //biz burada diyoruzki.Bu metodu aynı zamanda loglamak istiyorum(ILoggerService loggerService diyerek) 
            
            krediManager.Hesapla();
            loggerService.Log();// hesaplamayı yaptıktan sonra başvurunun sonunda  hangi loggerService gönderilmişse onu logla(loggerService.Log diyerek)
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Burada diyoruzki,Bana bir krediler listesi ver.Veri türü IKrediManager.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();  // 'krediler'deki her bir 'kredi'nin bir operasyonunu yap.Hesapla'sını yani.
            }
        }
    }
}
