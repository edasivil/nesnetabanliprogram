namespace Modul1Unite3
{
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }
}
