# RecapProjectDemo
<h2>Rent A Car Proje Ödevi - Yazılım Geliştirme Kampı</h2>

# Araba kiralama sistemi yazıyoruz.
<b>  Yepyeni bir proje oluşturunuz. 
* Adı ReCapProject olacak. (Tekrar ve geliştirme projesi) 

* Entities, DataAccess, Business ve Console katmanlarını oluşturunuz. 

* Bir araba nesnesi oluşturunuz. "Car"

* Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

* InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız. 

* Consolda test ediniz. 

 <h3>10/09/2021</h3> 
 
</b>
 
# Güncelleme ( Yazılım Kampı 8. Gün Ödevi )

<b> Car nesnesine ek olarak;

* Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

* Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz.

* Sisteme Generic IEntityRepository altyapısı yazınız.

* Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

* GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

* Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

 <h3>13.09.2021</h3> 
</b>
 
# Güncelleme ( Yazılım Kampı 9. Gün Ödevi )
<b> 
 
* CarRental Projenizde Core katmanı oluşturunuz
 
* IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
 
* Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
 
* Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
 
* Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
 
 <h3>16.09.2021</h3>
</b>

# Güncelleme ( Yazılım Kampı 10. Gün 1. Ödevi )
<b> 
Car Rental Projenizde;

* Core katmanında Results yapılandırması yapınız.
 
* Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.
 
 <h3>19.09.2021</h3>
</b>
