using Modul1Unite3;
using System;

namespace Modul1Unite3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();

            // Olay yakalama (dinleme)
            sepet.UrunEklendi += (sender, e) =>
            {
                var s = sender as Sepet;
                Console.WriteLine($"[Bilgi] Ürün eklendi. Güncel toplam: {s.ToplamTutar()} TL");
            };

            // Ürün ekleme döngüsü
            while (true)
            {
                Console.Write("Ürün adını girin (çıkmak için boş bırak): ");
                string ad = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ad))
                    break;

                Console.Write("Fiyatını girin: ");
                string fiyatInput = Console.ReadLine();

                if (decimal.TryParse(fiyatInput, out decimal fiyat))
                {
                    Urun yeniUrun = new Urun(ad, fiyat);
                    sepet.UrunEkle(yeniUrun);
                }
                else
                {
                    Console.WriteLine("Geçersiz fiyat!");
                }
            }

            Console.WriteLine("Alışveriş tamamlandı. Toplam tutar: " + sepet.ToplamTutar() + " TL");
            Console.ReadLine();
        }
    }
}

