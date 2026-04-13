namespace WinFormsApp2
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonRight = new Button();
            buttonleft = new Button();
            buttonUp = new Button();
            buttondown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 106);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 252);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(12, 279);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(190, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 47);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(330, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(330, 112);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(75, 23);
            buttonRight.TabIndex = 10;
            buttonRight.Text = "button4";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += button4_Click;
            // 
            // buttonleft
            // 
            buttonleft.Location = new Point(457, 112);
            buttonleft.Name = "buttonleft";
            buttonleft.Size = new Size(75, 23);
            buttonleft.TabIndex = 11;
            buttonleft.Text = "button5";
            buttonleft.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(396, 83);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(75, 23);
            buttonUp.TabIndex = 12;
            buttonUp.Text = "button6";
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttondown
            // 
            buttondown.Location = new Point(396, 141);
            buttondown.Name = "buttondown";
            buttondown.Size = new Size(75, 23);
            buttondown.TabIndex = 13;
            buttondown.Text = "button7";
            buttondown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondown);
            Controls.Add(buttonUp);
            Controls.Add(buttonleft);
            Controls.Add(buttonRight);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Button button3;
        private CheckBox checkBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonRight;
        private Button buttonleft;
        private Button buttonUp;
        private Button buttondown;
    }
}
