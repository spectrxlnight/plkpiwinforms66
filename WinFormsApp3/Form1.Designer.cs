
namespace WinFormsApp3
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


        private void InitializeComponent()
        {
            btnRun = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblTurn = new Label();
            btnRestartGame = new Button();
            txtEditor = new TextBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(195, 135);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(85, 23);
            btnRun.TabIndex = 0;
            btnRun.Text = "злови мене";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(344, 89);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 42);
            btn1.TabIndex = 1;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(377, 89);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 42);
            btn2.TabIndex = 2;
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(410, 89);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 42);
            btn3.TabIndex = 3;
            btn3.Text = "button3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(344, 125);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 42);
            btn4.TabIndex = 4;
            btn4.Text = "button4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(377, 125);
            btn5.Name = "btn5";
            btn5.Size = new Size(40, 42);
            btn5.TabIndex = 5;
            btn5.Text = "button5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(410, 125);
            btn6.Name = "btn6";
            btn6.Size = new Size(40, 42);
            btn6.TabIndex = 6;
            btn6.Text = "button6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(344, 162);
            btn7.Name = "btn7";
            btn7.Size = new Size(40, 42);
            btn7.TabIndex = 7;
            btn7.Text = "button7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(377, 162);
            btn8.Name = "btn8";
            btn8.Size = new Size(40, 42);
            btn8.TabIndex = 8;
            btn8.Text = "button8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(410, 162);
            btn9.Name = "btn9";
            btn9.Size = new Size(40, 42);
            btn9.TabIndex = 9;
            btn9.Text = "button9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(325, 278);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(0, 15);
            lblTurn.TabIndex = 10;
            // 
            // btnRestartGame
            // 
            btnRestartGame.Location = new Point(355, 218);
            btnRestartGame.Name = "btnRestartGame";
            btnRestartGame.Size = new Size(82, 42);
            btnRestartGame.TabIndex = 11;
            btnRestartGame.Text = "Нова гра";
            btnRestartGame.UseVisualStyleBackColor = true;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(653, 89);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.Size = new Size(164, 141);
            txtEditor.TabIndex = 12;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(653, 227);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(75, 49);
            btnOpenFile.TabIndex = 13;
            btnOpenFile.Text = "Відкрити файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(742, 227);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 49);
            btnSaveFile.TabIndex = 14;
            btnSaveFile.Text = "Зберегти файл";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 491);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(txtEditor);
            Controls.Add(btnRestartGame);
            Controls.Add(lblTurn);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private Button btnRun;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lblTurn;
        private Button btnRestartGame;
        private TextBox txtEditor;
        private Button btnOpenFile;
        private Button btnSaveFile;
    }
}
