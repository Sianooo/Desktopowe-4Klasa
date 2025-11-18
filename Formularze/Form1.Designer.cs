namespace Formularze
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox3 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            checkedListBox2 = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj nazwisko";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 82);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Podaj wiek";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(148, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Student";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(148, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 23);
            textBox3.TabIndex = 6;
            textBox3.Visible = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Matematyka", "Granie w gry komputerowe", "Sport", "Jedzenie", "Nauka programowania" });
            checkedListBox1.Location = new Point(143, 177);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(172, 94);
            checkedListBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 153);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 8;
            label3.Text = "Wybierz swoje zainteresowania";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 406);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(419, 23);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 375);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Polski", "Angielski", "Hiszpanki", "Wloski", "Niemiecki" });
            checkedListBox2.Location = new Point(343, 178);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(120, 94);
            checkedListBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 150);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 13;
            label6.Text = "Wybierz jezyk ktory znasz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(149, 445);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            label7.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 474);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(419, 23);
            textBox5.TabIndex = 15;
            textBox5.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(524, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wybierz plec";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mezczyzna";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kobieta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(checkedListBox2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dane osobowe";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox3;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private CheckedListBox checkedListBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
