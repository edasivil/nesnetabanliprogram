using System;
using System.Windows.Forms;

namespace modul1unite2
{
    public partial class Form1 : Form
    {
        // Delegate tanımı
        public delegate void SiralamaDelegate(ref string[] dizi);

        // Global dizi tanımı
        private string[] kelimeler = { "Elma", "Armut", "Karpuz", "Muz", "Kiraz" };

        public Form1()
        {
            InitializeComponent();
            ListeyiYukle(); // Form açılınca diziyi göster
        }

        // Diziyi ListBox'a yükleyen metot
        private void ListeyiYukle()
        {
            listBox1.Items.Clear();
            foreach (string kelime in kelimeler)
            {
                listBox1.Items.Add(kelime);
            }
        }

        // A-Z sıralama metodu
        private void SiralaAZ(ref string[] dizi)
        {
            Array.Sort(dizi);
        }

        // Z-A sıralama metodu
        private void SiralaZA(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
        }

        // button1 → A-Z Sırala
        private void button1_Click(object sender, EventArgs e)
        {
            SiralamaDelegate sirala = new SiralamaDelegate(SiralaAZ);
            sirala(ref kelimeler);
            ListeyiYukle();
        }

        // button2 → Z-A Sırala
        private void button2_Click(object sender, EventArgs e)
        {
            SiralamaDelegate sirala = new SiralamaDelegate(SiralaZA);
            sirala(ref kelimeler);
            ListeyiYukle();
        }

        // Bu örnekte listBox1'de seçim olayını kullanmıyoruz ama boş bırakabiliriz
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

