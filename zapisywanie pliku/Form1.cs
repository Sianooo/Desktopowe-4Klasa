using System.IO;
namespace zapisywanie_pliku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sciezka = openFileDialog1.FileName;
                try
                {
                    string tresc = File.ReadAllText(sciezka);
                    textBox1.Text = tresc;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapil blad wczytywania pliku " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sciezka = saveFileDialog1.FileName;
                try
                {
                    File.WriteAllText(sciezka, textBox2.Text);
                    MessageBox.Show("Zapisano zawartosc do pliku ");
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Wystapil blad podczas zapisywania pliku" + ex.Message);
                    }
                }
            }
        }
    }
}
