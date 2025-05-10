# Yol Arkadaşım – Tatil Planlama Konsol Uygulaması

## Açıklama
Basit bir C# konsol uygulaması ile:
1. Kullanıcıdan tatil paketi seçimi (Bodrum, Marmaris, Çeşme)  
2. Kaç kişi katılacağı  
3. Ulaşım tercihi (Karayolları, Havayolları)  

bilgilerini alır, paket ve ulaşım fiyatlarını hesaplar, ardından toplam tutarı ekrana yazdırır.

---

## Özellikler
- **tatilPaketi()**  
  - Kullanıcıya Bodrum (₺4000), Marmaris (₺3000) veya Çeşme (₺5000) seçeneklerini sunar.  
  - Geçerli bir seçim yapana kadar tekrar sorar.  
  - Seçilen paket adına ve kişi başı fiyata göre kullanıcıyı bilgilendirir.  
  - Kullanıcıdan kişi sayısını `int.TryParse` ile güvenli şekilde alır.

- **ulasimTercihi()**  
  - Kullanıcıya Karayolları (₺1500) ve Havayolları (₺4000) seçeneklerini sunar.  
  - Geçerli bir kod (1 veya 2) girene kadar tekrar sorar.  
  - Seçilen ulaşım tipi için kişi başı ücreti döndürür.

- **tatilTutari()**  
  - Önceki iki metottan alınan “paket fiyatı”, “kişi sayısı” ve “ulaşım fiyatı” verilerini kullanır.  
  - Toplam maliyeti `(kişi sayısı × paket fiyatı) + (kişi sayısı × ulaşım fiyatı)` formülüyle hesaplar ve ekrana yazar.

---

## Gereksinimler
- .NET SDK (7.0 veya üstü)  
- C# 8.0 veya üstü

---

## Kurulum ve Çalıştırma

1. Depoyu klonlayın veya proje dosyalarını indirin.
2. Proje klasörüne girin:
   ```bash
   cd Pratik---Yol-Arkada-Tatil-uygulamas
Uygulamayı derleyip çalıştırın:

bash
Kopyala
Düzenle
dotnet run
Kullanım
Tatil paketi ekranında Bodrum, Marmaris veya Çeşme yazarak seçim yapın.

Kişi sayısı girin (tam sayı).

Ulaşım ekranında 1 veya 2 girin:

1 → Karayolları (₺1500 kişi başı)

2 → Havayolları (₺4000 kişi başı)

Ekranda paket ücreti, ulaşım ücreti ve genel toplam tutar gösterilecektir.

Kod Yapısı
scss
Kopyala
Düzenle
Program
 ├─ Main()
 │    ├─ tatilPaketi()
 │    ├─ ulasimTercihi()
 │    └─ tatilTutari()
 ├─ static (string secim, int kisiSayisi, int paketFiyati) TatilPaketi()
 ├─ static int UlasimTercihi()
 └─ static void TatilTutari(string secim, int kisiSayisi, int paketFiyati, int ulasimFiyati)
Main: Uygulama akışını başlatır, metodları çağırır.

TatilPaketi: Paket seçimi ve kişi sayısını alır, döner.

UlasimTercihi: Ulaşım kodu sorar, fiyatı döner.

TatilTutari: Dönen değerleri birleştirip toplam maliyeti ekrana yazdırır.

