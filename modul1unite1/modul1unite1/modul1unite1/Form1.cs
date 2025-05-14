namespace modul1unite1
{
    public partial class Form1 : Form
    {
        public delegate int IslemDelegate(int a, int b);
        public Form1()
        {
            InitializeComponent();
            {

            }
        }
        public int Topla(int x, int y)
        {
            int sonuc = x + y;
            MessageBox.Show($"Toplama: {x} + {y} = {sonuc}");
            return sonuc;
        }
        public int Cikar(int x, int y)
        {
            int sonuc = x - y;
            MessageBox.Show($"��karma: {x} - {y} = {sonuc}");
            return sonuc;
        }
        public int Carp(int x, int y)
        {
            int sonuc = x * y;
            MessageBox.Show($"�arpma: {x} * {y} = {sonuc}");
            return sonuc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form y�klendi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 5;

            // 4. Tekli �a��r�m
            IslemDelegate islem = Topla;
            int sonuc1 = islem(sayi1, sayi2); // Topla metodu �a�r�l�r

            islem = Cikar;
            int sonuc2 = islem(sayi1, sayi2); // Cikar metodu �a�r�l�r

            // 5. �oklu �a��r�m (Multicast Delegate)
            islem = Topla;
            islem += Cikar;
            islem += Carp;

            int sonucSon = islem(sayi1, sayi2); // Son metot olan Carp'�n sonucu d�ner
            MessageBox.Show($"�oklu �a��r�mdaki son metot d�n�� de�eri: {sonucSon}");
        }
    }
}
        
