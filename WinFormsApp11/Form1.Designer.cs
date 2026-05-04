namespace WinFormsApp11
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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(297, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(241, 119);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 2;
            button1.Text = "Додати клієнта";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(358, 119);
            button2.Name = "button2";
            button2.Size = new Size(111, 40);
            button2.TabIndex = 3;
            button2.Text = "Наступний клієнт";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(241, 165);
            button3.Name = "button3";
            button3.Size = new Size(111, 40);
            button3.TabIndex = 4;
            button3.Text = "Фільтр";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(358, 165);
            button4.Name = "button4";
            button4.Size = new Size(111, 40);
            button4.TabIndex = 5;
            button4.Text = "Показати всіх";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(241, 211);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 94);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 308);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 7;
            label1.Text = "Обслуговується:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 308);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Кількість у черзі:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(445, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(445, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(400, 194);
            button5.Name = "button5";
            button5.Size = new Size(96, 47);
            button5.TabIndex = 2;
            button5.Text = "Додати";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(502, 194);
            button6.Name = "button6";
            button6.Size = new Size(96, 47);
            button6.TabIndex = 3;
            button6.Text = "Наступний";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(400, 247);
            button7.Name = "button7";
            button7.Size = new Size(96, 47);
            button7.TabIndex = 4;
            button7.Text = "Фільтр";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.Location = new Point(502, 247);
            button8.Name = "button8";
            button8.Size = new Size(96, 47);
            button8.TabIndex = 5;
            button8.Text = "Показати";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(400, 300);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(198, 94);
            listBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 397);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "Обслуговується:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 397);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 8;
            label4.Text = "Кількість у черзі: 0";
            // 
            // Form1
            // 
            ClientSize = new Size(1059, 551);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
            // 
            // Form1
            // 
            //AutoScaleDimensions = new SizeF(7F, 15F);
            //AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(800, 450);
            //Controls.Add(label2);
            //Controls.Add(label1);
            //Controls.Add(listBox1);
            //Controls.Add(button4);
            //Controls.Add(button3);
            //Controls.Add(button2);
            //Controls.Add(button1);
            //Controls.Add(comboBox1);
            //Controls.Add(textBox1);
            //Name = "Form1";
            //Text = "Form1";
            //ResumeLayout(false);
            //PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
    }
}
