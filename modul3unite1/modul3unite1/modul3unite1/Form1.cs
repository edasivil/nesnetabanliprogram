namespace modul3unite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Gunler
        {
            Pazartesi, Sal�, �ar�amba, Per�embe, Cuma, Cumartesi, Pazar
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gunListe = Enum.GetNames(typeof(Gunler));

            if (comboBox1 != null)
            {
                comboBox1.Items.AddRange(gunListe);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se�ilen g�n: " + comboBox1.SelectedItem?.ToString());
        }
    }
}
