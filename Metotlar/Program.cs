using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();  // Urun tipinde urun1'i tanımladık.urun1 yerine başka bir isimde verebilirdik.
            urun1.Adi = "Elma";  // Bizim bir manavda bir tip 'Urun'ümüz var ve bu 'Urun'ümüzün urun1.Bu urun.1'imizin adı "Elma" 
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Kandıra Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2}; // urun1 ve urun2 yi urunler takma adına aktardık.
                                                        // array: Bir veri tipinde istediğin kadar datayı tutan yapıdır.

            foreach (Urun urun in urunler) //'urun'bir takma ad.'Urun' veri tipi.'urunler' takma adının içindeki ürünleri 'urun'ün içine attık ve aşağıda bu 'urun'un adını,fiyatını ve açıklamasını yazdırdık. 
            // foreach dizilere uygulanır.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".................");
            }

            Console.WriteLine(".........Metotlar.........");

            SepetManager sepetManager = new SepetManager(); // Burada 'SepetManager' classını çağırıyoruz ve bir örneğini oluşturuyoruz.
            sepetManager.Ekle(urun1);  // Burada Ekle metodunu çağırıyoruz.
            sepetManager.Ekle(urun2); // buradaki urun1 ve urun2 sepetManager daki Ekle de 'Adi' kısmına gider adı yazılır.

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,9);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 7,11);
            sepetManager.Ekle2("Muz", "Sarı", 15,13);

        }
    }
}
