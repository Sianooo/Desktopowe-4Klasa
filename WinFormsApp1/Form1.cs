namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int wybor = 0;
        private void PokazFormularz(string tekst1, string tekst2, string tekstPrzycisku)
        {
            label1.Text = tekst1;
            label2.Text = tekst2;
            button1.Text = tekstPrzycisku;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void PokazTest(string tekst, string tekstPrzycisku)
        {
            label4.Text = tekst;
            button2.Text = tekstPrzycisku;
            textBox4.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void potencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 1;
            PokazFormularz("Podaj wysokoœæ obiektu (m)", "Podaj masê obiektu (kg)", "Oblicz Ep");
        }

        private void kinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 2;
            PokazFormularz("Podaj prêdkoœæ obiektu (m/s)", "Podaj masê obiektu (kg)", "Oblicz Ek");
        }

        private void predkoscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 3;
            PokazFormularz("Podaj drogê (w metrach)", "Podaj czas (w sekundach)", "Oblicz prêdkoœæ");
        }

        private void drogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 4;
            PokazFormularz("Podaj prêdkoœæ (m/s)", "Podaj czas (w sekundach)", "Oblicz drogê");
        }

        private void czasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 5;
            PokazFormularz("Podaj drogê (w metrach)", "Podaj prêdkoœæ (m/s)", "Oblicz czas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (wybor)
            {
                case 1:
                    float h = float.Parse(textBox1.Text);
                    float m = float.Parse(textBox2.Text);
                    float Ep = m * 9.81f * h;
                    textBox3.Text = Ep.ToString("F2") + " J";
                    break;

                case 2:
                    float v = float.Parse(textBox1.Text);
                    float m2 = float.Parse(textBox2.Text);
                    float Ek = 0.5f * m2 * v * v;
                    textBox3.Text = Ek.ToString("F2") + " J";
                    break;

                case 3:
                    float s1 = float.Parse(textBox1.Text);
                    float t1 = float.Parse(textBox2.Text);
                    textBox3.Text = (s1 / t1).ToString("F2") + " m/s";
                    break;

                case 4:
                    float v2 = float.Parse(textBox1.Text);
                    float t2 = float.Parse(textBox2.Text);
                    textBox3.Text = (v2 * t2).ToString("F2") + " m";
                    break;

                case 5:
                    float s3 = float.Parse(textBox1.Text);
                    float v3 = float.Parse(textBox2.Text);
                    textBox3.Text = (s3 / v3).ToString("F2") + " s";
                    break;
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 6;
            PokazTest("Podaj nazwisko", "Sprawdz nazwisko ucznia");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (wybor != 6) return;

            string nazwisko = textBox4.Text.Trim();

            if (nazwisko == "")
            {
                MessageBox.Show("Wpisz nazwisko!");
                textBox4.Focus();
                return;
            }

            string plik = "sprawdzian.txt";

            if (!File.Exists(plik))
                File.WriteAllText(plik, "");

            string[] linie = File.ReadAllLines(plik);
            bool znaleziono = false;

            foreach (string linia in linie)
            {
                if (linia.StartsWith(nazwisko + ";"))
                {
                    string punkty = linia.Split(';')[1];
                    MessageBox.Show($"Witaj {nazwisko}!\nMasz {punkty} punktów");
                    znaleziono = true;
                    break;
                }
            }

            if (!znaleziono)
            {
                File.AppendAllText(plik, nazwisko + ";0" + Environment.NewLine);
                MessageBox.Show($"Witaj {nazwisko}!\nZosta³eœ dodany – masz 0 punktów");
            }

            textBox4.Text = "";
            textBox4.Focus();
        }
    }
}