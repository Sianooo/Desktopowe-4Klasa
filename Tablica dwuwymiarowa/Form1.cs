using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablica_dwuwymiarowa
{
    public partial class Tablice_dwuwymiarowe : Form
    {
        public Tablice_dwuwymiarowe()
        {
            InitializeComponent();
        }
        int[,] tab;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(5);
            dataGridView2.Rows.Add(5);
            Random random = new Random();
            tab= new int[dataGridView1.Rows.Count,dataGridView1.ColumnCount];
            for(int i = 0;i < dataGridView1.Rows.Count;i++)
            {
                for(int j = 0;j < dataGridView1.Columns.Count;j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(1, 101);
                    tab[i, j] = (int) dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j=0;j< dataGridView1.Columns.Count; j++)
                {
                    sum += tab[i,j];
                }
            dataGridView2.Rows[i].Cells[0].Value = sum;
            sum = 0;
            }
        }
    }
}
