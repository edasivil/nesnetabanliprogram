using System;
using System.Threading;

namespace MakineSicaklikKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Makine makine = new Makine();

            // Olay dinleniyor
            makine.SicaklikArtti += Makine_SicaklikArtti;

            makine.Calistir();

            Random rnd = new Random();

            while (true)
            {
                Thread.Sleep(500); // 0.5 saniye bekle

                int yeniSicaklik = rnd.Next(900, 1101); // 900-1100 arasında rastgele sıcaklık üret
                Console.WriteLine($"🔄 Sıcaklık: {yeniSicaklik}°C");
                makine.Sicaklik = yeniSicaklik;

                if (yeniSicaklik > 1000)
                    break;
            }

            Console.WriteLine("Program sonlandı.");
        }

        // Olay yakalanınca yapılacak işlem
        private static void Makine_SicaklikArtti(object? sender, EventArgs e)
        {
            if (sender is Makine m)
            {
                m.Kapat();
            }
        }
    }
}
