using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        private void sortuj(int[] tab)
        {
            int temp;
            for (int i=0;i<10;i++)
            {
                for (int j=0;j<9;j++)
                {
                    if (tab[j] > tab[j+1])
                    {
                        temp = tab[j];
                        tab[j]= tab[j+1];
                        tab[j+1]= temp;
                    }
                }
            }
        }
        private int szukaj(int[] tab,int szukana,int p,int k)
        {
            int srodek;
           
            while (p<=k) {
                srodek =  (k+p)/ 2;
                if (tab[srodek] == szukana)
                {
                    return srodek;
                }
                else
                {
                    if (szukana < tab[srodek])
                    {
                        k = srodek - 1;
                    }
                    else
                    {
                        p = srodek + 1;
                    }
                }
            }
            return -1;
        }

        private int rekurencjeSzukanie(int[] tab, int szukana, int p, int k)
        {
            int srodek;
            if (p > k)
            {
                return -1;
            }
            else
            {
                srodek = (k + p) / 2;
                if (tab[srodek] == szukana)
                {
                    return srodek;
                }
                if (szukana < tab[srodek])
                {
                    return rekurencjeSzukanie(tab, szukana, p, srodek - 1);
                }
                if(szukana > tab[srodek])
                {
                    return rekurencjeSzukanie(tab, szukana, k, srodek + 1);
                }
            }
            return -1;
        }
        int[] temp;
        private void scalanie(int[] tab, int p, int k)
        {
            for (int i = p; i <= k; i++)
            {
                temp[i] = tab[i];
            }

            int srodek = p + (k - p) / 2;
            int i1 = p;   
            int i2 = srodek + 1; 
            int i3 = p;

            while (i1 <= srodek && i2 <= k)
            {
                if (temp[i1] <= temp[i2])
                {
                    tab[i3] = temp[i1];
                    i1++;
                }
                else
                {
                    tab[i3] = temp[i2];
                    i2++;
                }
                i3++;
            }

            while (i1 <= srodek)
            {
                tab[i3] = temp[i1];
                i1++;
                i3++;
            }

            while (i2 <= k)
            {
                tab[i3] = temp[i2];
                i2++;
                i3++;
            }
        }

        private void sortowaniePrzezSkalanie(int[] tab,int p, int k)
        {
            if (p >= k) return;
            int srodek = (k + p) / 2;
            sortowaniePrzezSkalanie(tab, p, srodek);
            sortowaniePrzezSkalanie(tab, srodek + 1, k);
            scalanie(tab, p, k);
        }

        int[] tab;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tab = new int[dataGridView1.Columns.Count];
            for (int i=0;i<10;i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = random.Next(1,101);
                tab[i]=(int)dataGridView1.Rows[0].Cells[i].Value;
            }
            label1.Hide();
            textBox1.Hide();
            dataGridView2.Hide();
        }

        private void min_Click(object sender, EventArgs e)
        {
            int min = 100;
            for (int i =0;i<10;i++)
            {
                if (min > tab[i])
                {
                    min = tab[i];
                }
            }
            label1.Show();
            textBox1.Show();
            textBox1.Text = min.ToString();
            
            
        }

        private void max_Click(object sender, EventArgs e)
        {
            int max = tab[0];
            for (int i=0;i<10;i++)
            {
                if (max < tab[i])
                {
                    max=tab[i];
                }
            }
            label1.Text = "Największy element: ";
            label1.Show();
            textBox1.Show();
            textBox1.Text = max.ToString();
        }

        private void sortowanie_Click(object sender, EventArgs e)
        {
            sortuj(tab);
            for (int i=0;i<10; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = tab[i];
            }
            label1.Hide();
            textBox1.Hide();
            dataGridView2.Show();

            
        }

        private void szukanie_Click(object sender, EventArgs e)
        {
            int szukany = int.Parse(textBox2.Text);
            int w= szukaj(tab,szukany,0,tab.Length -1);
            
                
            label1.Show();
            textBox1.Show();
            if(w==-1)
            {
                textBox1.Text = "Nie ma takiej liczby w tablicy";
            }
            else
            {
                textBox1.Text = w.ToString();
                label1.Text = "Szukany element znajduje sie na pozycji";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int szukany = int.Parse(textBox2.Text);
            int w = rekurencjeSzukanie(tab, szukany, 0, tab.Length - 1);


            label1.Show();
            textBox1.Show();
            if (w == -1)
            {
                textBox1.Text = "Nie ma takiej liczby w tablicy";
            }
            else
            {
                textBox1.Text = w.ToString();
                label1.Text = "Szukany element znajduje sie na pozycji";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = new int[tab.Length];
            sortowaniePrzezSkalanie(tab, 0, tab.Length - 1);
            for (int i = 0; i < tab.Length; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = tab[i];
            }
            label1.Hide();
            textBox1.Hide();
            dataGridView2.Show();
        }
    }
}
