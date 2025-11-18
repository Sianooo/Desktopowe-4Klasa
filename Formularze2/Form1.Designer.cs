namespace Formularze2
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            Szkola = new ListBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wies", "Miasto do 10 000 ", "Miasto od 10 000 do 100 000 ", "Miasto powyzej 100 000" });
            comboBox1.Location = new Point(57, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Miejsce zamieszkania";
            // 
            // button1
            // 
            button1.Location = new Point(60, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // Szkola
            // 
            Szkola.FormattingEnabled = true;
            Szkola.ItemHeight = 15;
            Szkola.Items.AddRange(new object[] { "Liceum", "Branzowa", "Podstawowa", "Technikum" });
            Szkola.Location = new Point(207, 17);
            Szkola.Name = "Szkola";
            Szkola.Size = new Size(120, 94);
            Szkola.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 23);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(Szkola);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private ListBox Szkola;
        private TextBox textBox2;
    }
}
