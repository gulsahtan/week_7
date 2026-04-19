# 🎯 week_7 - Koleksiyonlar, ComboBox, ListBox ve Öğrenci Yönetim Sistemi

Bu proje, **Görsel Programlama dersi - Hafta 7** kapsamında işlenen **diziler, List<T>, ComboBox, ListBox ve CRUD işlemleri** konularını uygulamalı olarak göstermek amacıyla geliştirilmiştir.

Bu haftada öğrenciler sadece veri tutmayı değil, aynı zamanda bu verileri **arayüzde göstermeyi, seçmeyi, eklemeyi, güncellemeyi ve silmeyi** öğrenirler.

---

## 📌 Bu Haftanın Konusu

Bu haftada aşağıdaki konular ele alınmıştır:

- Diziler (Array)
- 2 boyutlu diziler
- Jagged diziler
- `List<T>` koleksiyonu
- ComboBox kullanımı
- ListBox kullanımı
- Veri bağlama (Data Binding)
- CRUD işlemleri
  - Create (Ekle)
  - Read (Listele / Göster)
  - Update (Güncelle)
  - Delete (Sil)

---

## 🧠 Proje Amacı

Bu proje ile öğrencilerin:

- Dizi ve liste arasındaki farkı görmesi
- Dinamik veri tutma mantığını öğrenmesi
- ComboBox ile seçim işlemleri yapması
- ListBox ile nesne listeleme mantığını anlaması
- Form üzerinden veri ekleme, silme ve güncelleme işlemleri yapması
- Nesne tabanlı çalışma mantığını kavraması

hedeflenmiştir.

---

## 🖥️ Uygulama İçeriği

Bu uygulama, basit bir **Öğrenci Yönetim Sistemi** örneğidir.

Kullanıcı form üzerinden:

- Öğrenci numarası girer
- Ad soyad bilgisini yazar
- Bölüm seçer
- Öğrenciyi listeye ekler
- Seçili öğrenciyi günceller
- Seçili öğrenciyi siler
- Giriş alanlarını temizler

---

## 👨‍🎓 Uygulamada Yapılan İşlemler

### 🔹 Öğrenci Ekleme
- Kullanıcı `txtNumara`, `txtAdSoyad` ve `comboBolum` alanlarını doldurur
- **Ekle** butonuna bastığında yeni bir öğrenci nesnesi oluşturulur
- Öğrenci `BindingList<Student>` içine eklenir
- ListBox otomatik olarak güncellenir

### 🔹 Öğrenci Listeleme
- Eklenen tüm öğrenciler `listBoxOgrenciler` içinde gösterilir
- Her öğrenci ekranda şu formatta görünür:

`101 - Ali Yılmaz (BST)`

Bu görünüm, `Student` sınıfı içindeki `ToString()` metodu sayesinde sağlanır.

### 🔹 Öğrenci Seçme
- Kullanıcı listeden bir öğrenci seçtiğinde
- O öğrencinin bilgileri otomatik olarak soldaki alanlara aktarılır
- Böylece kullanıcı güncelleme işlemi yapabilir

### 🔹 Öğrenci Güncelleme
- Listeden seçilen öğrenci üzerinde değişiklik yapılır
- **Güncelle** butonuna basıldığında bilgiler güncellenir
- Numara çakışması kontrol edilir
- ListBox görünümü yenilenir

### 🔹 Öğrenci Silme
- Kullanıcı listeden bir öğrenci seçer
- **Sil** butonuna bastığında onay kutusu gelir
- Kullanıcı **Evet** derse öğrenci listeden silinir

### 🔹 Giriş Alanlarını Temizleme
- **Temizle** butonu ile TextBox ve ComboBox alanları sıfırlanır
- Yeni veri girişi için form hazır hale gelir

---

## 🎛️ Kullanılan Kontroller

Bu projede aşağıdaki WinForms kontrolleri kullanılmıştır:

- `Label`
- `TextBox`
- `ComboBox`
- `ListBox`
- `Button`

---

## ⚙️ Kullanılan Yapılar

Projede aşağıdaki C# yapıları kullanılmıştır:

- `class`
- `List<T>`
- `BindingList<T>`
- `if`
- `return`
- `TryParse`
- `Any()`
- `Max()`
- `SelectedItem`
- `SelectedIndexChanged`
- `MessageBox`

---

## 🧱 Kullanılan Sınıflar

### `Student` Sınıfı
Her öğrenci bir nesne olarak tutulur.

Bu sınıfta şu alanlar vardır:

- `Id`
- `Numara`
- `AdSoyad`
- `Bolum`

Ayrıca `ToString()` metodu ezilerek öğrencinin ListBox’ta anlamlı şekilde görünmesi sağlanmıştır.


---

## ✅ Validasyonlar

Bu projede kullanıcı hatalarını önlemek için bazı kontroller yapılmıştır:

- Numara alanı boş geçilemez
- Numara sayısal olmalıdır
- Ad soyad boş geçilemez
- Bölüm seçilmelidir
- Aynı öğrenci numarası iki kez eklenemez

---

## 💡 Uygulama Özellikleri

- Hazır örnek öğrenci listesi ile açılır
- Bölümler ComboBox içine yüklenir
- Öğrenciler nesne olarak tutulur
- Seçilen kayıt forma taşınır
- Ekle / Güncelle / Sil / Temizle işlemleri yapılır
- Silme işleminde kullanıcıdan onay alınır

---

## 📚 Ek Eğitim Notu

Bu proje ile öğrenciler şu farkları uygulamalı olarak öğrenmiş olur:

### Array
- Sabit boyutludur
- Sonradan eleman sayısı değişmez

### List<T>
- Dinamik yapıdadır
- Kolayca eleman eklenip çıkarılabilir

### ComboBox
- Kullanıcıya hazır seçenek sunar

### ListBox
- Çok sayıda veriyi listelemek için uygundur

---

## 🧠 Öğrenilecek Kazanımlar

Bu proje sayesinde öğrenciler:

- Koleksiyon mantığını kavrar
- Array ve List farkını öğrenir
- Nesne tabanlı veri saklamayı anlar
- ComboBox ve ListBox kullanımını öğrenir
- CRUD işlemlerini uygulamalı olarak görür
- WinForms üzerinde kullanıcı etkileşimli form geliştirir
