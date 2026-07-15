using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Burada biz aşağıda yani, method injection yapıyoruz.Yani bu metodun kullanacağı kredi managerın ne olacağını
        //DEVAMI: yani hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        //LOGLAMA:Kim ne zaman hangi operasyonu çağırdıdır.Yani birnevi o sistemde olan hareketleri döktüğümüz bir dökümdür.
        //Method Injection: Yani bu aşağıdaki metodun krediManager ve loggerService' in hangisi olacağını belirliyoruz.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)// Buraya hangi krediyi yollarsak
                                                                                       //DEVAMI: (yani IhtiyacKrediManager,KonutKrediManager...) onun bellekteki
                                                                                       //DEVAMI: Hesapla' sı çalışır.
        {                                                                              //Biz burada diyoruzki. Bu metodu aynı zamanda loglamak istiyorum
                                                                                       //DEVAMI:(ILoggerService loggerService diyerek) 
            
            krediManager.Hesapla();
            loggerService.Log();//Hesaplamayı yaptıktan sonra başvurunun sonunda  hangi loggerService gönderilmişse onu logla(loggerService.Log diyerek)
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> kredilerimiz) //Burada diyoruzki,Bana bir krediler listesi ver.Veri türü IKrediManager.
        {
            foreach (var kredi in kredilerimiz)
            {
                kredi.Hesapla();  // 'kredilerimiz'deki her bir 'kredi'nin bir operasyonunu yap.Hesapla'sını yani.
            }
        }
    }
}
