# C# Eğitim Kampı 501 - Basit Form Uygulaması
## Projenin Amacı

Bu proje, **Dapper**'ın kullanımını öğrenmek ve SQL veritabanı işlemlerine yönelik pratik yapmak amacıyla geliştirilmiştir. Kullanıcılar, ürünler üzerinde listeleme, ekleme, silme ve güncelleme işlemleri yapabilir. Ayrıca, ürünler hakkında özet bilgileri görüntüleyebilecekleri bir arayüz sağlanmıştır.

---

## Kullanılan Teknolojiler

- **C#:** Uygulamanın ana programlama dili.
- **Dapper:** Veritabanı işlemlerini kolaylaştırmak için kullanılan bir ORM kütüphanesi.
- **SQL Server:** Veritabanı yönetim sistemi.
- **Windows Forms:** Kullanıcı arayüzü tasarımı için.

---

## Özellikler

1. **CRUD İşlemleri:**
   - **Listeleme:** Veritabanındaki ürünleri bir tabloda görüntüleyin.
   - **Ekleme:** Yeni bir ürün ekleyin.
   - **Silme:** Mevcut bir ürünü veritabanından silin.
   - **Güncelleme:** Bir ürünün bilgilerini düzenleyin.

2. **Label Bilgileri:**
   - **Kitap Sayısı:** Veritabanındaki toplam ürün sayısını görüntüler.
   - **En Pahalı Kitap:** En yüksek fiyatlı kitabın adını ve fiyatını görüntüler.
   - **Kategori Sayısı:** Veritabanında bulunan toplam kategori sayısını görüntüler.

---

## Veritabanı Yapısı

Projede kullanılan veritabanı aşağıdaki alanları içermektedir:

- **ProductId**: Ürünün benzersiz kimliği (int).
- **ProductName**: Ürünün adı (nvarchar).
- **ProductStock**: Ürünün stok miktarı (int).
- **ProductPrice**: Ürünün fiyatı (decimal).
- **ProductCategory**: Ürünün kategorisi (nvarchar).

---

## Kurulum ve Kullanım

1. **Proje Dosyasını Klonlayın:**
   ```bash
   git clone https://github.com/ozcanakyuz/CSharpEgitimKampi501.git
   ```

2. **SQL Veritabanını Ayarlayın:**
   - Veritabanı script dosyasını kullanarak gerekli tabloları oluşturun.
   - `appsettings.json` dosyasındaki bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin.

3. **Proje Bağımlılıklarını Yükleyin:**
   - NuGet üzerinden **Dapper** kütüphanesini yükleyin:
     ```bash
     Install-Package Dapper
     ```

4. **Uygulamayı Çalıştırın:**
   - Projeyi Visual Studio veya başka bir IDE ile çalıştırın.

---

## Ekran Görüntüleri

### 1. Ana Form
![Form Ekran Görüntüsü](https://i.hizliresim.com/spy7hlk.png)

---

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasını inceleyebilirsiniz.

---
**Ders:** C# Eğitim Kampı (Murat YÜCEDAĞ Youtube Serisi)
**Hazırlayan:** [ozcanakyuz](https://github.com/ozcanakyuz)

