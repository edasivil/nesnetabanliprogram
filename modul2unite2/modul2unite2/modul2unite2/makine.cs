using System;

namespace MakineSicaklikKontrol
{
    public class Makine
    {
        private int _sicaklik;
        public int Sicaklik
        {
            get => _sicaklik;
            set
            {
                _sicaklik = value;
                if (_sicaklik > 1000)
                {
                    SicaklikArtti?.Invoke(this, EventArgs.Empty); // olay tetikleniyor
                }
            }
        }

        // Olay tanımı
        public event EventHandler? SicaklikArtti;

        public void Calistir()
        {
            Console.WriteLine("Makine çalışıyor...");
        }

        public void Kapat()
        {
            Console.WriteLine("⚠️ Sıcaklık 1000 derecenin üzerine çıktı!");
            Console.WriteLine("🛑 Makine kapatılıyor...");
        }
    }
}

