using System;
using System.Windows.Forms;

namespace Tablice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tab;

        private void sortuj()
        {
            int temp;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        private void Wypełnij_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tab = new int[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                tab[i] = random.Next(1, 101);
                dataGridView1.Rows[0].Cells[i].Value = tab[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tab == null || tab.Length == 0)
                return;

            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                    min = tab[i];
            }
            label1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text=min.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tab == null || tab.Length == 0)
                return;

            sortuj();
            for (int i = 0; i < tab.Length; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = tab[i];
            }
            dataGridView2.Visible = true;
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tab == null || tab.Length == 0)
                return;

            int max = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
            }
            label2.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = max.ToString();
        }
    }
}