using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Add ,yani ekleme operasyonu yapacağız.
       //DEVAMI: Burada Product türünde bir 'product' istiyoruz. Parantez içine (string ad) yazmak gibi. 
       //DEVAMI: Biz buraya 'Product' türünde bir şey yollayacağız ve burada 'product' isminde tutulacak.
        {
            Console.WriteLine(product.ProductName + " eklendi."); 
        }

        public void Update(Product product)   // void,bir işlemi yapar ve bitirir.
        {
            Console.WriteLine(product.ProductName + " " + "güncellendi.");
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2; // return: işlemi döndürüp çıkan değeri tekrar kullanmamızı sağlar.
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }
}
