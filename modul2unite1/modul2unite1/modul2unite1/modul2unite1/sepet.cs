using Modul1Unite3;
using System;
using System.Collections.Generic;

namespace Modul1Unite3
{
    public class Sepet
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        // Olay tanımı (event)
        public event EventHandler UrunEklendi;

        // Ürün ekleme metodu
        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);

            // Olayı tetikle
            if (UrunEklendi != null)
            {
                UrunEklendi(this, EventArgs.Empty);
            }
        }

        // Toplam hesaplayan yardımcı metot
        public decimal ToplamTutar()
        {
            decimal toplam = 0;
            foreach (var u in Urunler)
            {
                toplam += u.Fiyat;
            }
            return toplam;
        }
    }
}

