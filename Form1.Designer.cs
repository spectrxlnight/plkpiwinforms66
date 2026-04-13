namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            textBoxInput = new TextBox();
            buttonAnalyze = new Button();
            labelWithSpaces = new Label();
            labelWithoutSpaces = new Label();
            labelWords = new Label();
            labelVowels = new Label();
            labelDigits = new Label();
            labelLongestWord = new Label();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new System.Drawing.Point(28, 52);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new System.Drawing.Size(420, 110);
            textBoxInput.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Location = new System.Drawing.Point(28, 180);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new System.Drawing.Size(140, 36);
            buttonAnalyze.TabIndex = 1;
            buttonAnalyze.Text = "Аналізувати";
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += buttonAnalyze_Click;
            // 
            // labelWithSpaces
            // 
            labelWithSpaces.AutoSize = true;
            labelWithSpaces.Location = new System.Drawing.Point(28, 240);
            labelWithSpaces.Name = "labelWithSpaces";
            labelWithSpaces.Size = new System.Drawing.Size(82, 15);
            labelWithSpaces.TabIndex = 2;
            labelWithSpaces.Text = "З символами:";
            // 
            // labelWithoutSpaces
            // 
            labelWithoutSpaces.AutoSize = true;
            labelWithoutSpaces.Location = new System.Drawing.Point(28, 270);
            labelWithoutSpaces.Name = "labelWithoutSpaces";
            labelWithoutSpaces.Size = new System.Drawing.Size(85, 15);
            labelWithoutSpaces.TabIndex = 3;
            labelWithoutSpaces.Text = "Без пробілів:";
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Location = new System.Drawing.Point(28, 300);
            labelWords.Name = "labelWords";
            labelWords.Size = new System.Drawing.Size(95, 15);
            labelWords.TabIndex = 4;
            labelWords.Text = "Кількість слів:";
            // 
            // labelVowels
            // 
            labelVowels.AutoSize = true;
            labelVowels.Location = new System.Drawing.Point(28, 330);
            labelVowels.Name = "labelVowels";
            labelVowels.Size = new System.Drawing.Size(61, 15);
            labelVowels.TabIndex = 5;
            labelVowels.Text = "Голосних:";
            // 
            // labelDigits
            // 
            labelDigits.AutoSize = true;
            labelDigits.Location = new System.Drawing.Point(28, 360);
            labelDigits.Name = "labelDigits";
            labelDigits.Size = new System.Drawing.Size(41, 15);
            labelDigits.TabIndex = 6;
            labelDigits.Text = "Цифр:";
            // 
            // labelLongestWord
            // 
            labelLongestWord.AutoSize = true;
            labelLongestWord.Location = new System.Drawing.Point(28, 390);
            labelLongestWord.Name = "labelLongestWord";
            labelLongestWord.Size = new System.Drawing.Size(104, 15);
            labelLongestWord.TabIndex = 7;
            labelLongestWord.Text = "Найдовше слово:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new System.Drawing.Point(28, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(86, 15);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Введіть текст:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(486, 441);
            Controls.Add(labelTitle);
            Controls.Add(labelLongestWord);
            Controls.Add(labelDigits);
            Controls.Add(labelVowels);
            Controls.Add(labelWords);
            Controls.Add(labelWithoutSpaces);
            Controls.Add(labelWithSpaces);
            Controls.Add(buttonAnalyze);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Аналіз тексту";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonAnalyze;
        private Label labelWithSpaces;
        private Label labelWithoutSpaces;
        private Label labelWords;
        private Label labelVowels;
        private Label labelDigits;
        private Label labelLongestWord;
        private Label labelTitle;
    }
}