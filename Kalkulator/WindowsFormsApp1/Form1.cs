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
            if(a == 0)
            {
                return 1;
            }
            else
            {
                return a * Silnia(a - 1);

            }
        }

        public string Binarny(int a)
        {
            if (a == 0)
            {
                return "0";
            }
            else if (a == 1)
            {
                return "1";
            }
            else
            {
                int reszta = a % 2;
                int podzielona =a / 2;
                return Binarny(podzielona)+reszta;
            }
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
            float a, b;
            a=float.Parse(textBox1.Text);
            b= float.Parse(textBox2.Text);
            if (a == 0 || b == 0)
            {
                textBox3.Text = "0";
            }
            else
            {
                float dzielenie = a / b;
                textBox3.Text = dzielenie.ToString();
            }
            textBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b;
            a=int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Wpisz liczby dodatnie!");
                return;
            }
            while (a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            int nwd = a;
            textBox3.Text = nwd.ToString();
            textBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);
            int suma= 0;
            int x=a;
            while (x>0) { 
                suma += x % 10; 
                x /= 10; 
            }
            if(a==0) suma=0;
            textBox3.Text=suma.ToString();
            textBox2.Visible=false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a= int.Parse(textBox1.Text);
            string wynik = Binarny(a);
            textBox3.Text=wynik.ToString();
            textBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a < 0)
            {
                MessageBox.Show("Wpisz liczby dodatnie!");
                return;
            }
            textBox3.Text = Silnia(a).ToString();
            textBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a=double.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            textBox2.Visible = true;
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show( "Podstawa musi być liczbą rzeczywistą!");
                return;
            }
            if (!int.TryParse(textBox2.Text, out b) || b < 0)
            {
                MessageBox.Show( "Wykładnik musi być liczbą naturalną");
                return;
            }
            double wynik = 1;
            for (int i = 0; i < b; i++)
            {
                wynik *= a;
            }
            textBox3.Text=wynik.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);
            textBox2.Visible=false;
            if (!int.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show( "Wpisz poprawną liczbę całkowitą!");
                return;
            }
            string wynik=a.ToString("X");
            textBox3.Text = wynik;
        }
    }
}
