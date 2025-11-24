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

        public int Silnia(int a)
        {
            if (a == 0) return 1;
            return a * Silnia(a - 1);
        }

        public string Binarny(int a)
        {
            if (a == 0) return "0";
            if (a == 1) return "1";
            return Binarny(a / 2) + (a % 2);
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
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            if (a <= 0 || b <= 0)
            {
                textBox3.Text = "Tylko dodatnie!";
                return;
            }
            while (b > 0.00001f)
            {
                float temp = b;
                b = a % b;
                a = temp;
            }
            textBox3.Text = a.ToString("F4");
            textBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int suma = 0;
            int x = Math.Abs(a);
            if (x == 0)
                suma = 0;
            else
                while (x > 0)
                {
                    suma += x % 10;
                    x /= 10;
                }
            textBox3.Text = suma.ToString();
            textBox2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox3.Text = a < 0 ? "Tylko dodatnie!" : Binarny(a);
            textBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a < 0 || a > 12)
                textBox3.Text = "0-12!";
            else
                textBox3.Text = Silnia(a).ToString();
            textBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            if (b < 0)
            {
                textBox3.Text = "Wykładnik >= 0!";
                return;
            }
            double w = 1;
            for (int i = 0; i < b; i++) w *= a;
            textBox3.Text = w.ToString();
            textBox2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox3.Text = a.ToString("X");
            textBox2.Visible = false;
        }
    }
}
