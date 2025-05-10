using System;
using System.Collections.Generic;

namespace YolArkadasım
{
    class Program
    {
        // alan değişkenleri
        static string secim;
        static int kisiSayisi;
        static int paketFiyati;
        static int ulasimFiyati;

        static void Main(string[] args)
        {
            // 1) Paket seçimi ve kişi sayısını al
            tatilPaketi();

            // 2) Ulaşım tercihini al
            ulasimTercihi();

            // 3) Toplam tutarı hesapla ve yazdır
            tatilTutari();
        }

        public static void tatilPaketi()
        {
            Console.WriteLine("TatilKeyfiBurada.com'a Hoş Geldiniz..");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bodrum Paketi Başlangıç Fiyatı : 4000 TL");
            Console.WriteLine("Marmaris Paketi Başlangıç Fiyatı : 3000 TL");
            Console.WriteLine("Çeşme Paketi Başlangıç Fiyatı   : 5000 TL");
            Console.WriteLine("------------------------------------------");

            // Paket seçimi
            while (true)
            {
                Console.Write("Lütfen Bodrum, Marmaris veya Çeşme yazın: ");
                secim = Console.ReadLine()!.Trim().ToLower();
                if (secim == "bodrum" || secim == "marmaris" || secim == "cesme")
                    break;
                Console.WriteLine(" Geçersiz seçim, tekrar deneyin.\n");
            }

            // Paket fiyatını belirle
            paketFiyati = secim switch
            {
                "bodrum"   => 4000,
                "marmaris" => 3000,
                "cesme"    => 5000,
                _           => 0
            };
            Console.WriteLine($"Seçiminiz: {secim} (Kişi başi {paketFiyati} TL)");

            // Kişi sayısını al
            Console.Write("Tatile kaç kişi katilacak? ");
            while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
            {
                Console.WriteLine("Geçerli bir sayi giriniz.");
                Console.Write("Tatile kaç kişi katilacak? ");
            }
            Console.WriteLine($"{kisiSayisi} kişi tatil yapmayi planliyor.\n");

            Console.WriteLine("Sizin için etkinlikler listesi:");
            Console.WriteLine("- Havuz Aktiviteleri");
            Console.WriteLine("- DJ Gösterileri");
            Console.WriteLine("- Spor Aktiviteleri\n");
        }

        public static void ulasimTercihi()
        {
            var ulasimSecenekleri = new Dictionary<int, string>
            {
                { 1, "Karayolları (1500 TL kişi başı)" },
                { 2, "Havayolları (4000 TL kişi başı)" }
            };

            Console.WriteLine("Ulaşım Tercihiniz nasıl olacak?");
            Console.WriteLine("------------------------------------------");
            foreach (var kvp in ulasimSecenekleri)
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");
            Console.WriteLine("------------------------------------------");

            Console.Write("Seçiminiz (1-2): ");
            if (!int.TryParse(Console.ReadLine(), out int tercih) || !ulasimSecenekleri.ContainsKey(tercih))
            {
                Console.WriteLine("Geçersiz seçim, program sonlanıyor.");
                Environment.Exit(0);
            }

            ulasimFiyati = tercih switch
            {
                1 => 1500,
                2 => 4000,
                _ => 0
            };
            Console.WriteLine($"Seçilen ulaşım: {ulasimSecenekleri[tercih]}\n");
        }

        public static void tatilTutari()
        {
            int toplamPaket = kisiSayisi * paketFiyati;
            int toplamUlasim = kisiSayisi * ulasimFiyati;
            int genelToplam = toplamPaket + toplamUlasim;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Paket Ücreti : {toplamPaket} TL");
            Console.WriteLine($"Ulaşım Ücreti: {toplamUlasim} TL");
            Console.WriteLine($"Genel Toplam : {genelToplam} TL");
            Console.WriteLine("------------------------------------------");
        }
    }
}
