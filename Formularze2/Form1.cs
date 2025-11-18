namespace Formularze2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wybranaWartosc = comboBox1.SelectedItem.ToString();
            textBox1.Visible = true;
            textBox1.Text = wybranaWartosc.ToString();

            int wybranyIndeks = Szkola.SelectedIndex;
            string wybWartosc = Szkola.Items[wybranyIndeks].ToString();
            textBox2.Visible = true;
            textBox2.Text = wybWartosc.ToString();
        }
    }
}
