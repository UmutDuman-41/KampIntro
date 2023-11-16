using System;
using System.Collections.Generic; // list yazdıktan sonra ampule sağ tıkla ve üstüne tıkla.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin","Murat","Kerem","Halil"}; // Bir string array(dizi) oluşturduk.
            //Console.WriteLine(isimler[0]); // 'isimler'in 0.elemanını yazdırdık.
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new demek yeni referans adresi demek. new diyerek burada 5 elemanlı boş bir array oluşturduk.
            //isimler[4] = "İlker"; // burada 5 elemanlı array'i oluşturduktan sonra 'ilker'i atadık ama diğer isimleri atamadığımız için diğer isimleri okumaz.
            //Console.WriteLine(isimler[4]);// arraylerde sabitlik var.Yani bir arrayi 4 elemanlı tanımladığımızda onu 5 elemanlı yapsak bile 'new' demek gerektiği için yeni elemanı eklesek bile eski elemanları kaybediyoruz.
            //Console.WriteLine(isimler[0]);// yukarıdaki kusurdan dolayı 'List'i kullanıyoruz.

            List<string> isimler2 = new List<string>{"Engin", "Murat", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); // isimler2.Add komutu ile 'İlker'i listeye ekledik.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
