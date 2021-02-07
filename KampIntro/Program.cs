using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler"; // Metinsel ifadeleri string veri tipinde yazıyoruz.Metinsel ifadeler tek tırnak ile değil çift tırnak ile yazılır.
            int ogrenciSayisi = 32000; // int veri tipi tam sayıları yazarken kullandığımız veri tipidir.
            double faizOrani = 1.45; //Ondalıklı sayıları gösterirken bu veri tipini kullanıyoruz.
            bool sistemeGirisYapmisMi = true; // bool veri tipi sadece true ve false değerlerini alabilir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        
        }
    }
}
