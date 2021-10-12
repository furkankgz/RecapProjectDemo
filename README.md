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

# Güncelleme ( Yazılım Kampı 10. Gün 4. Ödevi )
<b> 
CarRental projenizde;

* Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
 
* Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName (Kullanıcılar ve müşteriler ilişkilidir).
 
* Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
 
* Projenizde bu entity'leri oluşturunuz.
 
* CRUD operasyonlarını yazınız.
 
* Yeni müşteriler ekleyiniz.
 
* Arabayı kiralama imkanını kodlayınız. Rental-->Add
 
* Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

 <h3>21.09.2021</h3>
</b>

# Güncelleme ( Yazılım Kampı 11. Gün 1. Ödevi )
<b> 
Car Rental Projenizde;

* WebAPI katmanını kurunuz.
 
* Business katmanındaki tüm servislerin Api karşılığını yazınız.
 
* Postman'de test ediniz.
 
 <h3>22.09.2021</h3>
</b>

# Güncelleme ( Yazılım Kampı 12. Gün Ödevi )
<b> 
Car Rental Projenizde; 
 
* Car Rental Projenize Autofac desteği ekleyiniz.
 
* FluentValidation desteği ekleyiniz.
 
* AOP desteği ekleyiniz.
 
* ValidationAspect ekleyiniz.
 
 <h3>25.09.2021</h3>
</b>

# Güncelleme ( Yazılım Kampı 13. Gün Ödevi )
<b> 
Car Rental Projenizde; 
 
* CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
 
* Api üzerinden arabaya resim ekleyecek sistemi yazınız.
 
* Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
 
* Resim silme, güncelleme yetenekleri ekleyiniz.
 
* Bir arabanın en fazla 5 resmi olabilir.
 
* Resmin eklendiği tarih sistem tarafından atanacaktır.
 
* Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
 
* Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)
 
 <h3>28.09.2021</h3>
</b>

# Güncelleme ( Yazılım Kampı 13. Gün Ödevi )
<b> 
Car Rental Projenizde; 
 
* JWT entegrasyonu yapınız.
 
 <h3>12.10.2021</h3>
</b>
