using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long Silnia(int n)
        {
            if (n < 0) return 0;
            if (n <= 1) return 1;
            long w = 1;
            for (int i = 2; i <= n; i++)
                w *= i;
            return w;
        }

        public string NaBinarny(long n)
        {
            if (n == 0) return "0";
            string s = "";
            n = Math.Abs(n);
            while (n > 0)
            {
                s = (n % 2) + s;
                n /= 2;
            }
            return s;
        }

        public double NWD(double a, double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b > 0.00001)
            {
                double t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            a=float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            float dodawanie = a + b;
            textBox3.Text = dodawanie.ToString();
            textBox2.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a, b;
            a=float.Parse(textBox1.Text);
            b=float.Parse(textBox2.Text);
            float odejmowanie = a - b;
            textBox3.Text = odejmowanie.ToString();
            textBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a, b;
            a=float.Parse(textBox1.Text);
            b=float.Parse(textBox2.Text);
            float mnozenie = a * b;
            textBox3.Text = mnozenie.ToString();
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            if (Math.Abs(b) < 0.00001f)
            {
                textBox3.Text = "Błąd: dzielenie przez 0!"; 
            }
            else 
            { 
                textBox3.Text = (a / b).ToString(); 
            }
            textBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b) || a <= 0 || b <= 0)
                textBox3.Text = "Tylko dodatnie!";
            else
                textBox3.Text = NWD(a, b).ToString("F4");
            textBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a))
            {
                textBox3.Text = "Błąd!";
                return;
            }

            string s = Math.Abs(a).ToString(System.Globalization.CultureInfo.InvariantCulture);
            int suma = 0;
            foreach (char c in s)
                if (c >= '0' && c <= '9')
                    suma += c - '0';

            textBox3.Text = suma.ToString();
            textBox2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox1.Text, out long a))
                textBox3.Text = "Błąd!";
            else
                textBox3.Text = (a < 0 ? "-" : "") + NaBinarny(a);
            textBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int a) || a < 0 || a > 20)
                textBox3.Text = "Błąd! (0-20)";
            else
                textBox3.Text = Silnia(a).ToString();
            textBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;

            if (!double.TryParse(textBox1.Text, out double a))
            {
                textBox3.Text = "Podstawa niepoprawna!";
                return;
            }

            if (!int.TryParse(textBox2.Text, out int b))
            {
                textBox3.Text = "Wykładnik musi być liczbą całkowitą!";
                return;
            }

            if (b == 0)
            {
                textBox3.Text = "1";
                textBox2.Visible = true;
                return;
            }

            if (b < 0)
            {
                if (a == 0)
                {
                    textBox3.Text = "Błąd: dzielenie przez zero!";
                    return;
                }
                textBox3.Text = (1.0 / Math.Pow(a, -b)).ToString();
            }
            else
            {
                textBox3.Text = Math.Pow(a, b).ToString();
            }

            textBox2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (!long.TryParse(textBox1.Text, out long liczba))
            {
                textBox3.Text = "To nie jest liczba całkowita!";
                return;
            }

            if (liczba == 0)
                textBox3.Text = "0";
            else if (liczba > 0)
                textBox3.Text = liczba.ToString("X");
            else
                textBox3.Text = "-" + (-liczba).ToString("X");

            textBox2.Visible = false;
        }
    }
}
