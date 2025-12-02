namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            obliczeniaToolStripMenuItem = new ToolStripMenuItem();
            energiaToolStripMenuItem = new ToolStripMenuItem();
            kinetycznaToolStripMenuItem = new ToolStripMenuItem();
            potencjalnaToolStripMenuItem = new ToolStripMenuItem();
            ruchJednostajnyProstoliniowyToolStripMenuItem = new ToolStripMenuItem();
            predkoscToolStripMenuItem = new ToolStripMenuItem();
            drogaToolStripMenuItem = new ToolStripMenuItem();
            czasToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { obliczeniaToolStripMenuItem, testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // obliczeniaToolStripMenuItem
            // 
            obliczeniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { energiaToolStripMenuItem, ruchJednostajnyProstoliniowyToolStripMenuItem });
            obliczeniaToolStripMenuItem.Name = "obliczeniaToolStripMenuItem";
            obliczeniaToolStripMenuItem.Size = new Size(74, 20);
            obliczeniaToolStripMenuItem.Text = "Obliczenia";
            // 
            // energiaToolStripMenuItem
            // 
            energiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kinetycznaToolStripMenuItem, potencjalnaToolStripMenuItem });
            energiaToolStripMenuItem.Name = "energiaToolStripMenuItem";
            energiaToolStripMenuItem.Size = new Size(240, 22);
            energiaToolStripMenuItem.Text = "Energia";
            // 
            // kinetycznaToolStripMenuItem
            // 
            kinetycznaToolStripMenuItem.Name = "kinetycznaToolStripMenuItem";
            kinetycznaToolStripMenuItem.Size = new Size(136, 22);
            kinetycznaToolStripMenuItem.Text = "Kinetyczna";
            kinetycznaToolStripMenuItem.Click += kinetycznaToolStripMenuItem_Click;
            // 
            // potencjalnaToolStripMenuItem
            // 
            potencjalnaToolStripMenuItem.Name = "potencjalnaToolStripMenuItem";
            potencjalnaToolStripMenuItem.Size = new Size(136, 22);
            potencjalnaToolStripMenuItem.Text = "Potencjalna";
            potencjalnaToolStripMenuItem.Click += potencjalnaToolStripMenuItem_Click;
            // 
            // ruchJednostajnyProstoliniowyToolStripMenuItem
            // 
            ruchJednostajnyProstoliniowyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { predkoscToolStripMenuItem, drogaToolStripMenuItem, czasToolStripMenuItem });
            ruchJednostajnyProstoliniowyToolStripMenuItem.Name = "ruchJednostajnyProstoliniowyToolStripMenuItem";
            ruchJednostajnyProstoliniowyToolStripMenuItem.Size = new Size(240, 22);
            ruchJednostajnyProstoliniowyToolStripMenuItem.Text = "Ruch jednostajny prostoliniowy";
            // 
            // predkoscToolStripMenuItem
            // 
            predkoscToolStripMenuItem.Name = "predkoscToolStripMenuItem";
            predkoscToolStripMenuItem.Size = new Size(122, 22);
            predkoscToolStripMenuItem.Text = "Predkosc";
            predkoscToolStripMenuItem.Click += predkoscToolStripMenuItem_Click;
            // 
            // drogaToolStripMenuItem
            // 
            drogaToolStripMenuItem.Name = "drogaToolStripMenuItem";
            drogaToolStripMenuItem.Size = new Size(122, 22);
            drogaToolStripMenuItem.Text = "Droga";
            drogaToolStripMenuItem.Click += drogaToolStripMenuItem_Click;
            // 
            // czasToolStripMenuItem
            // 
            czasToolStripMenuItem.Name = "czasToolStripMenuItem";
            czasToolStripMenuItem.Size = new Size(122, 22);
            czasToolStripMenuItem.Text = "Czas";
            czasToolStripMenuItem.Click += czasToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(40, 20);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(68, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 102);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Wynik";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 47);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(324, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(295, 73);
            button2.Name = "button2";
            button2.Size = new Size(168, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "pliki tekstowe|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem obliczeniaToolStripMenuItem;
        private ToolStripMenuItem energiaToolStripMenuItem;
        private ToolStripMenuItem kinetycznaToolStripMenuItem;
        private ToolStripMenuItem potencjalnaToolStripMenuItem;
        private ToolStripMenuItem ruchJednostajnyProstoliniowyToolStripMenuItem;
        private ToolStripMenuItem predkoscToolStripMenuItem;
        private ToolStripMenuItem drogaToolStripMenuItem;
        private ToolStripMenuItem czasToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ToolStripMenuItem testToolStripMenuItem;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
