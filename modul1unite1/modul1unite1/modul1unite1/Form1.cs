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
            MessageBox.Show($"Çýkarma: {x} - {y} = {sonuc}");
            return sonuc;
        }
        public int Carp(int x, int y)
        {
            int sonuc = x * y;
            MessageBox.Show($"Çarpma: {x} * {y} = {sonuc}");
            return sonuc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form yüklendi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 5;

            // 4. Tekli çaðýrým
            IslemDelegate islem = Topla;
            int sonuc1 = islem(sayi1, sayi2); // Topla metodu çaðrýlýr

            islem = Cikar;
            int sonuc2 = islem(sayi1, sayi2); // Cikar metodu çaðrýlýr

            // 5. Çoklu çaðýrým (Multicast Delegate)
            islem = Topla;
            islem += Cikar;
            islem += Carp;

            int sonucSon = islem(sayi1, sayi2); // Son metot olan Carp'ýn sonucu döner
            MessageBox.Show($"Çoklu çaðýrýmdaki son metot dönüþ deðeri: {sonucSon}");
        }
    }
}
        
