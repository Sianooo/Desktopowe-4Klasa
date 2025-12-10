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
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton4 = new RadioButton();
            button3 = new Button();
            listBox1 = new ListBox();
            label9 = new Label();
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
            button2.Location = new Point(293, 84);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 130);
            label5.Name = "label5";
            label5.Size = new Size(312, 15);
            label5.TabIndex = 11;
            label5.Text = "1. Jakie jest przyspieszenie ziemskie na powierzchni Ziemi?";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10 m/s²", "9,8 m/s²", "1,6 m/s²", "9,0 m/s²" });
            comboBox1.Location = new Point(491, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 161);
            label6.Name = "label6";
            label6.Size = new Size(400, 15);
            label6.TabIndex = 13;
            label6.Text = "2. Które z poniższych ciał przyciągają się nawzajem w sposób grawitacyjny?";
            label6.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Ziemia i Księżyc";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(185, 216);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(106, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Ziemia i Słońce";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(337, 191);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(220, 19);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "Ziemia i każdy obiekt na powierzchni";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(338, 216);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(219, 19);
            checkBox4.TabIndex = 17;
            checkBox4.Text = "Wszystkie odpowiedzi są prawidłowe";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 251);
            label7.Name = "label7";
            label7.Size = new Size(191, 15);
            label7.TabIndex = 18;
            label7.Text = "3. Naposz wzór na moc elektryczną";
            label7.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(370, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 19;
            textBox5.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(173, 279);
            label8.Name = "label8";
            label8.Size = new Size(204, 15);
            label8.TabIndex = 20;
            label8.Text = "4. Co jest jednostką siły w układzie SI?";
            label8.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(266, 304);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Newton (N)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(369, 304);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dżul (J)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(462, 304);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 19);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.Text = "Pascal (Pa)";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(324, 465);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 25;
            button3.Text = "Przeslij wyniki";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Zwiekszenie prędkości ciała", "Zmniejszenie prędkości ciała\t", "Wykonanie pracy dodatniej na ciele (działanie siły w kierunku ruchu)", "Działanie siły prostopadłej do kierunku ruchu" });
            listBox1.Location = new Point(201, 355);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(372, 94);
            listBox1.TabIndex = 26;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 326);
            label9.Name = "label9";
            label9.Size = new Size(494, 15);
            label9.TabIndex = 27;
            label9.Text = "5. Co spowoduje zwiększenie energii kinetycznej ciała? ( wybierz dwie poprawne odpowiedzi)";
            label9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
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
            Load += Form1_Load;
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
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private Button button3;
        private ListBox listBox1;
        private Label label9;
    }
}
