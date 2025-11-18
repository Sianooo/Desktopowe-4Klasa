namespace Formularze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string age = textBox2.Text;

            bool isStudent = checkBox1.Checked;
            bool mezczyzna = radioButton2.Checked;
            bool kobieta = radioButton1.Checked;

            string plec = mezczyzna ? "Mê¿czyzna" : (kobieta ? "Kobieta" : "Nie wybrano");
            string studentText = isStudent ? "Student: TAK" : "Student: NIE";
            textBox3.Visible = true;
            textBox3.Text = $"Imiê: {name} \r\nlat/lata: {age} plec: {plec}  \r\n{studentText}";


            label5.Text = "Zainteresowania";
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                textBox4.Text += itemChecked.ToString() + " ";
                label5.Visible = true;
                textBox4.Visible = true;
            }

            label7.Text = "Jezyki:";
            foreach(object itemChecked in checkedListBox2.CheckedItems)
            {
                textBox5.Text += itemChecked.ToString() + " ";
                textBox5.Visible = true;
                label7.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
