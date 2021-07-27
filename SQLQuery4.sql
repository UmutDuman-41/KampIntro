--Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers : burada diyoruzki mesela bana city'yi Sehir diye getir.Buna alyas denir.
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers --Select : Yani datayı seç , * demek tüm kolonlar demek, from : nreden hangi tablodan.Select ContactName,CompanyName,City from Customers (Bu şekilde yazınca bize seçtiğimiz nameler ne city gibi ibareleri gösterir.)


Select * from Customers where City = 'London' --Şehiri London olanları getirir.
Select * from Products --Product tablosunu her şeyi ile çağırır.
select * from Products where CategoryID = 1 or CategoryID=3

select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by UnitPrice desc  --order by : sırala demek.Burada diyoruz ki Bütün ürünleri seç ama fiyatına göre sırala. asc:ascending ten geliyor.artan demek. desc  ise azalan demek

select * from Products  where CategoryID=1 order by UnitPrice desc 

Select COUNT(*) Adet from Products  --count tüm satırları say ve sayısını ver demek.
Select COUNT(*) from Products where CategoryID=2 -- CategoryID si 2 olan kaç ürün var.

select CategoryID ,count(*) from Products group by CategoryID --Bütün kategorileri bana tekrar etmeyecek şekilde listele.
select CategoryID ,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 -- birim fiyatı 20'den fazla olan ürünleri categoryID'ye göre grupla her bir grupta 10'dan az olanları.


select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories           -- hem product hem de categories'ın bir araya getirilmiş hali.
on Products.CategoryID = Categories.CategoryID   --on Products tablosundaki CategoryID ile Categories tablosundaki CategoryID'ye göre .Onlar eşit ise onları yan yana getir demek.
where Products.UnitPrice>10   -- ürünlerden fiyatı 10'dan büyük olanlar için onu kategoriler ile join et bize getir.

--DTO = Data Transformation object

select * from Products p left join [Order Details] od   -- p:Products , od: Order Details, inner join sadece eşleşen kayıtları birleştirir. left join : solda olup sağda olmayanları da getir demek.
on p.ProductID = od.ProductID  
inner join Orders o 
on o.OrderID = od.OrderID -- bir üstteki ve buradaki satır ile (yani bu 4 satır ile) bir tabloyu daha ekliyoruz,birleştiriyoruz.

select *  from  Customers c left join Orders o -- buradaki ibare hem inner join olanları hemde müşterilerde olmayanları da getir demek.
on c.CustomerID = o.CustomerID
where o.CustomerID is null  -- burada yani 3 satırda da yapılan şey: biz sisteme kayıt olupta ürün almayanları bulmak.