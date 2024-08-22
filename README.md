# 📌: NLayerApp

## ✏️: Projenin Amacı

**NLayerApp** projesi, katmanlı mimariyi daha iyi anlamak ve bu mimariyi uygulamalı olarak deneyimlemek amacıyla geliştirilmiştir. Bu proje, farklı işlevlerin ayrı katmanlar halinde nasıl yapılandırıldığını ve bu katmanlar arasında nasıl bir iş akışı sağlandığını göstermektedir.

## 🖥️: Kullanılan Teknolojiler

Projede aşağıdaki teknolojiler kullanılmıştır:

- **EntityFrameworkCore**: Veritabanı işlemleri için kullanılan ORM aracı.
- **Autofac**: Dependency Injection (Bağımlılık Enjeksiyonu) yönetimi için kullanılan bir kütüphane.
- **Automapper**: Nesneler arasında otomatik veri dönüştürme işlemleri için kullanılan bir kütüphane.
- **FluentValidation**: Veri doğrulama işlemleri için kullanılan bir kütüphane.
- **MSSQL**: Veritabanı yönetimi için kullanılan bir ilişkisel veritabanı yönetim sistemi.

## ⚙️: N Katmanlı Mimari ile Uygulama Nasıl İnşa Edilir?

N-Katmanlı mimari, uygulamanın fonksiyonel ihtiyaçlarını veya çalışma prensiplerini belirleyerek, uygulamayı belirli katmanlara bölerek inşa edilir. Bu katmanlar sırasıyla:

1. **Data Access Layer**
2. **Business Layer**
3. **Presentation Layer**
4. **User Interface (UI) Layer**

Her bir katman, bir önceki katmandaki verilere veya görevlere dayanır ve kendi görevlerini üstlenir. Bu sayede uygulamanın esneklik, ölçeklenebilirlik ve sürdürülebilirlik gibi özellikleri artar.

## 📦: Core Katmanı Nasıl İnşa Edilir?

Core layer (temel katman), bir uygulamanın en önemli ve en kritik işlevlerinin yer aldığı katmandır. Bu katman, diğer katmanların ihtiyaç duyduğu ortak işlevleri, verileri ve servisleri sağlar. Aşağıdaki adımlar takip edilerek inşa edilir:

1. **İş Fonksiyonlarını Tanımlama**: Uygulamanın temel işlevlerini belirleyin.
2. **Entities Tanımlama**: Verilerin nasıl saklanacağını belirleyin.
3. **Repository Pattern Implementasyonu**: Veri erişim düzeneklerini oluşturun.
4. **Servislerin Tanımlanması**: Ortak servisleri tanımlayın.
5. **Test Etme**: Core katmanını test edin.

## 📁: Data Access Katmanı Nasıl İnşa Edilir?

Data access katmanı, veri erişim katmanıdır. Bu katman, veritabanı, dosya sistemi veya diğer veri depolarından veri çekmek ve kaydetmek için kullanılan kodları barındırır. Aşağıdaki işlemleri içerir:

- Veritabanı modellerini tasarlama
- Veritabanı bağlantısı kurma
- Veri erişim stratejilerini belirleme
- CRUD işlemlerini gerçekleştirme

Bu katman, veri erişimini yönetir ve diğer katmanlarla olan veri etkileşimini sağlar.

## 📋: Business Katmanı Nasıl İnşa Edilir?

Business katmanı, veritabanından veya diğer veri kaynaklarından veri işleme ve uygulamanın iş mantığının uygulanması işlemlerini yapar. Aşağıdaki adımları içerir:

1. **Veri Modellerini Tanımlama**
2. **Servis Metodlarını Tanımlama**
3. **İş Logiklerini Tanımlama**
4. **Servis Metodlarının Erişilebilirliğini Sağlama**
5. **Test Etme**

## 📦: Generic Repository Çok Katmanlı Mimariye Nasıl Implement Edilir?

Generic Repository, veritabanı işlemlerini merkezi bir sınıfta toplar ve veri erişimini kolaylaştırır. Bu yapı, veritabanındaki verilere daha esnek bir şekilde erişilmesine olanak tanır. Uygulamanın her katmanı için bu tür bir yapı, veritabanındaki verilere tek bir noktadan erişmenin avantajını sunar ve değişikliklerin daha kolay yapılmasını sağlar.

## 🔄: Migration İşlemleri Nasıl Gerçekleştirilir?

Migration işlemleri, veritabanının değişen gereksinimlere göre güncellenmesini sağlamaya yarayan bir yöntemdir. Bu işlemler .NET Core veya Entity Framework kullanılarak yapılabilir. Adımlar:

1. **Entity Framework CLI Aracını Kurun.**
2. **Uygulama Projesini Seçin ve Package Manager Console'u Açın.**
3. **Add-Migration Komutunu Kullanın ve Migration Adını Belirtin.**
4. **Update-Database Komutunu Kullanarak Veritabanını Güncelleyin.**

## ⚠️: Hata Yönetimi Global Olarak Nasıl Ele Alınır?

Global hata yönetimi, uygulamanın tüm bölümlerindeki hataların takip edilmesi ve yönetilmesini sağlar. Genellikle, hataların yapılandırılması ve loglanması için bir hata yakalama mekanizması oluşturulur ve bu mekanizma, tüm uygulama boyunca devreye girer. Global hata yönetimi, hata durumunda uygulamanın çalışmasını sürdürmesine yardımcı olur ve hata hakkında bilgi sağlar, böylece uygulama hızla onarılabilir.

## 🔗: Çok Katmanlı Mimari ile Entity Framework Nasıl Kullanılır?

Çok katmanlı mimaride Entity Framework, veritabanı erişimi ve veri kaydedilmesi işlemlerini yapmak için kullanılır. Entity Framework, veritabanındaki verileri C# nesnelerine dönüştüren ve bu nesneleri veritabanına kaydeden bir ORM (Object Relational Mapping) teknolojisidir. Çok katmanlı mimaride, Entity Framework genellikle "Data" katmanında kullanılır. Data katmanı, veritabanına erişimi ve veri işleme işlemlerini yapar. Entity Framework, bu işlemleri kolaylaştırarak, "Core" ve "Service" katmanlarına bu işlemleri yapması için gerekli verileri sunar.

## 🔃: AutoMapper Kütüphanesi Çok Katmanlı Mimaride Nasıl Kullanılır?

AutoMapper, bir veri nesnesinin bir başka veri nesnesine otomatik olarak dönüştürülmesine olanak tanıyan bir C# kütüphanesidir. Çok katmanlı mimaride, AutoMapper veri tabanından çekilen verilerin, uygulamanın farklı katmanlarındaki nesnelere dönüştürülmesinde kullanılabilir.

## ⚙️: AutoFac Nedir? Nasıl Kullanılır? Projeye Nasıl Implement Edilir?

AutoFac, .NET uygulamalarında Dependency Injection (Bağımlılık Enjeksiyonu) için kullanılan bir kütüphanedir. Autofac, nesnelerin bağımlılıklarını yönetir ve oluşturulmasını otomatikleştirir.

Kullanımı:

1. **NuGet Yardımı ile Autofac Paketini Projeye Ekleyin.**
2. **Konfigürasyonları 'Program.cs' Dosyasına Ekleyin.**
3. **Servisleri ve Bağımlılıkları Kaydedip Yapılandırın.**

## 📝: FluentValidation Nedir? Nasıl Kullanılır? Projeye Nasıl Implement Edilir?

FluentValidation, .NET platformunda kullanılan bir doğrulama (validation) kütüphanesidir. Bu kütüphane, nesnelerin ve verilerin geçerli olup olmadığını doğrulamak için birçok farklı doğrulama kuralı sunar. Kullanımı kolay ve esnek bir API sunar ve Fluent API adını verdiği bir yapıya sahiptir. Projeye FluentValidation'ı implement etmek için:

1. **FluentValidation Paketini NuGet Package Manager ile Projeye Ekleyin.**
2. **Her Model İçin Bir Doğrulama Sınıfı Oluşturun.**
3. **Uygulamanın Uygun Noktasında FluentValidation'ı Yapılandırın ve Uygulamaya Ekleyin.**

## 📬: İletişim

Bana ulaşmak için aşağıdaki iletişim bilgisini kullanabilirsiniz:

- **E-posta**: [pehlivan.enes53@gmail.com](mailto:pehlivan.enes53@gmail.com)
