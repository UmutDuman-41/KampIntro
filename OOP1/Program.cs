 using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId = 5,UnitsInStock = 5,ProductName = "Kalem",UnitPrice = 35 }; // yukarıdaki yazım ile aynı şey.
            //PascalCase     //camelCase    , productManager'a instıns deniyor.
            ProductManager productManager = new ProductManager();//'ProductManager' türünde bir productManager tanımladık. referans tiplerin 'Heap'te oluşabilmesi için onu new'lememiz gerekiyor.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product2);


            productManager.Topla2(3, 6); // burada işlem yapılır ve biter. geri dönüş olmaz.


            int toplamSonucu = productManager.Topla(3, 6); // 3 ve 6 'ProductManager'daki Topla metoduna gitti ve iki sayı toplandı. Sonra sonuç return ile geri çağrıldı ve 'toplamaSonucu'na verildi.
            Console.WriteLine(toplamSonucu*2); // burada sonucu geri çağırıp 2 ile çarptık.

        }
    }
}
