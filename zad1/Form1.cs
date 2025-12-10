namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a =float.Parse(textBox1.Text);
            float b =float.Parse(textBox2.Text);
            float c =float.Parse(textBox3.Text);

            textBox4.Text =(a+b+c).ToString("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s =int.Parse(textBox4.Text);
            if (s<0)
            {
                textBox5.Text="suma nie jest naturalna";
                return;
            }
            for (int i =1; i * i<=s;i++)
            {
                if (i * i==s)
                {
                    textBox5.Text="suma jest kwadratem liczby "+i;
                    return;
                }
            }
            textBox5.Text="suma nie jest kwadratem";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
