EntityFrameworkCoreProje
Bu proje, ASP.NET Core MVC ve Entity Framework Core kullanarak bir e-ticaret uygulaması geliştirmeyi amaçlamaktadır. Proje, kullanıcıların kategori, marka ve ürünleri yönetebileceği bir yönetim paneli içermektedir. Entity Framework Core ile veritabanı işlemleri yapılmakta, MVC yapısına uygun olarak Controller ve View'lar aracılığıyla dinamik bir kullanıcı deneyimi sağlanmaktadır.

Proje Yapısı
Areas/Admin: Yönetim paneline ait Controller'lar ve View'lar burada yer almaktadır. Kullanıcılar markalar, kategoriler ve ürünler üzerinde CRUD işlemleri gerçekleştirebilirler.

Controllers: Kategoriler, markalar ve ürünlerle ilgili işlemleri yöneten controller'lar.

Views: Admin panelinde kullanılan tüm görünümler (Create, Edit, Delete, Index vb.) burada bulunmaktadır.

Migrations: Veritabanı şeması değişikliklerini takip eden migration dosyaları içerir.

Models: Uygulamanın veritabanı modelleri burada yer alır. Bu modeller, Brand, Category, Product gibi temel varlıkları temsil eder.

wwwroot: Statik dosyalar (CSS, JavaScript, resimler vb.) burada bulunur.

Kullanılan Teknolojiler
ASP.NET Core MVC: Uygulamanın temel mimarisi ve kullanıcı arayüzü için.

Entity Framework Core: Veritabanı işlemlerini yönetmek ve CRUD işlemlerini gerçekleştirmek için kullanılmıştır.

SQL Server: Veritabanı yönetim sistemi olarak kullanılmıştır.

Özellikler
Kategoriler, markalar ve ürünler üzerinde ekleme, düzenleme, silme ve listeleme işlemleri yapılabilir.

Veritabanı işlemleri Entity Framework Core ile yapılır, bu da veritabanı sorgularını ve işlemleri kolaylaştırır.

Admin paneli, kullanıcı dostu bir arayüz ile kullanıcıların veritabanındaki verileri yönetmesini sağlar.
