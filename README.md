# CSharp Eğitim Kampı 501

Bu proje, **CSharp Eğitim Kampı 501** kapsamında Dapper ORM kullanılarak geliştirilmiş bir uygulamadır. Proje, bir ürün (kitap) yönetim sistemi oluşturarak temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmeyi ve SQL veritabanı ile etkileşim kurmayı öğretmeyi amaçlamaktadır.

## Projenin Özellikleri

Proje aşağıdaki işlevleri içermektedir:

1. **CRUD İşlemleri:**
   - **Listeleme:** Veritabanındaki ürünleri bir tabloda görüntüleyin.
   - **Ekleme:** Yeni bir ürün ekleyin.
   - **Silme:** Mevcut bir ürünü veritabanından silin.
   - **Güncelleme:** Bir ürünün bilgilerini düzenleyin.

2. **Label Bilgileri:**
   - **Kitap Sayısı:** Veritabanındaki toplam ürün sayısını görüntüler.
   - **En Pahalı Kitap:** En yüksek fiyatlı kitabın adını ve fiyatını görüntüler.
   - **Kategori Sayısı:** Veritabanında bulunan toplam kategori sayısını görüntüler.

## Kullanılan Teknolojiler

- **C#**: Uygulama geliştirme dili.
- **Dapper**: SQL veritabanıyla hızlı ve performanslı bir şekilde çalışmayı sağlayan ORM.
- **SQL**: Veritabanı yönetimi.
- **Windows Forms**: Kullanıcı arayüzü geliştirme.

## Veritabanı Yapısı

Projedeki SQL veritabanı aşağıdaki tabloları içerir:

| Kolon Adı       | Veri Tipi   | Açıklama                        |
|------------------|-------------|----------------------------------|
| ProductId        | INT         | Ürün kimliği (birincil anahtar).|
| ProductName      | NVARCHAR    | Ürün adı.                      |
| ProductStock     | INT         | Stok miktarı.                  |
| ProductPrice     | DECIMAL     | Ürün fiyatı.                   |
| ProductCategory  | NVARCHAR    | Ürün kategorisi.               |

## Proje Kurulumu ve Kullanımı

1. **Proje Dosyalarının İndirilmesi**:
   - Bu projeyi yerel makinenize indirin veya klonlayın:
     ```bash
     git clone https://github.com/ozcanakyuz/CSharpEgitimKampi501.git
     ```

2. **SQL Veritabanının Oluşturulması**:
   - `database.sql` dosyasını kullanarak veritabanını oluşturun.
   - Veritabanı bağlantı ayarlarını (`connectionString`) uygulama içerisinde güncelleyin.

3. **Projenin Çalıştırılması**:
   - Projeyi Visual Studio veya başka bir C# geliştirme ortamında açın.
   - Uygulamayı başlatmak için `Run` tuşuna basın.

4. **Form Kullanımı**:
   - **Listeleme**: Mevcut ürünleri listelemek için formda ilgili butona tıklayın.
   - **Ekleme**: Yeni bir ürün eklemek için formdaki ilgili alanları doldurup "Ekle" butonuna tıklayın.
   - **Silme**: Bir ürünü silmek için listeden seçip "Sil" butonuna tıklayın.
   - **Güncelleme**: Ürün bilgilerini düzenlemek için bir ürün seçip gerekli değişiklikleri yapın ve "Güncelle" butonuna tıklayın.
   - **Etiketler (Labels)**: Kitap sayısı, en pahalı kitap ve kategori bilgileri form üzerinde görüntülenir.

## Ekran Görüntüleri

**Listeleme Sayfası**  
![Form Ekran Görüntüsü](https://i.hizliresim.com/spy7hlk.png)

## Katkıda Bulunma

Eğer projeye katkıda bulunmak isterseniz:  
1. Depoyu fork edin.  
2. Yeni bir özellik geliştirmek için dal oluşturun.  
3. Değişikliklerinizi yapıp commit edin.  
4. Pull Request gönderin.

## Ders

C# Eğitim Kampı (Murat YÜCEDAĞ Youtube Serisi)

## İletişim

**GitHub**: [ozcanakyuz](https://github.com/ozcanakyuz)

---
