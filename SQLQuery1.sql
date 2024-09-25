﻿
select * from Customers   --select;seç demek , *;tüm kolonları seç , from Customers; Customers tablosundan.
select ContactName,CompanyName,City from Customers --Bu üç bilginin yer aldığı kolonu bize getirir.
select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers --Mesela companyName'i SirketAdi olarak getir diyoruz.
Select * from Customers where City = 'London' --Tüm müşterileri tüm kolonlar ile getir ama şehri London olanları.

Select * from Products --Ürünler tablosunu tüm kolonları ile getir.
Select * from Products where CategoryID = 1 
Select * from Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products order by ProductName --Bütün ürün kolonlarını getir ama ürün ismine(ProductName) göre sırala.
Select * from Products order by UnitPrice   --asc:ascending(az çoğa doğru), desc:descending(çoktan aza doğru)

Select * from Products where CategoryID = 1 order by UnitPrice desc --CategoryID = 1 olanları filtrele onları UnitPrice'a göre azalan olarak getir.

Select COUNT(*) from Products--Bütün Produts tablosunda kaç data var onu verir.
Select COUNT(*) from Products where CategoryID  = 2

Select categoryID from Products group by CategoryID --dataların içine bak ve bütün kategorileri tekrar etmeyecek şekilde listele demek bu satır.
Select categoryID,count(*) from Products group by CategoryID --Herbir kategoride kaç ürün olduğunu bize verir.

Select categoryID,count(*) from Products group by CategoryID having count(*)<10 --Bana içerisinde 10 taneden az ürün çeşidi olan kategorileri ver. 
Select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --Not:Önce her zaman 'where' çalışır.
-- Birim fiyatı 20'den fazla olan ürünleri CategoryID' ye göre grupla ve herbir grupta sayısı 10 dan az olanları bize ver demek bu kod.


select  Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories-- on; durumunda şartında demek
on Products.CategoryID = Categories.CategoryID --inner join kullanarak Products tablosundan bilgiler ile Categories tablosundan bir bilgiyi 
                                               --tek bir tabloda birleştirdik.


select  Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10--Ürünlerden(Products) fiyatı 10'dan büyük olanlar için onu kategoriler ile join et(inner join Categories) ve bana getir.

-- inner join; sadece 2 tabloda da eşleşenleri bir araya getirir.
--DTO: DATA TRANSFORMATION OBJECT

select * from Products p left join [Order Details] od --left join ile dedikki; solda olup(Products) sağda olmayanlarıda getir([Order Details]).
on p.ProductID = od.ProductID --Devamı: Bu da ürünler tablosunda var ama hiç satış yok demek.

select * from Customers c left join orders o 
on c.CustomerID = o.CustomerID -- Buranın açıklaması: orders'da olup Customers'da olmayanları da getir demek.


select * from Customers c left join orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null --null demek o data yok demek.orders da null olanları getirir.


select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID --orders'daki orderID ile Order Details'daki orderID yi bu şekilde join edebiliriz. 

