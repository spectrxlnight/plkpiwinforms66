using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;

            int withSpaces = text.Length;
            int withoutSpaces = text.Replace(" ", "").Length;

            string[] wordsArray = text.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int words = wordsArray.Length;

            int vowels = 0;
            string vowelLetters = "аеєиіїоуюяАЕЄИІЇОУЮЯaeiouyAEIOUY";

            for (int i = 0; i < text.Length; i++)
            {
                if (vowelLetters.Contains(text[i]))
                {
                    vowels++;
                }
            }

            int digits = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits++;
                }
            }

            string longestWord = "";
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i].Length > longestWord.Length)
                {
                    longestWord = wordsArray[i];
                }
            }

            labelWithSpaces.Text = "З символами: " + withSpaces;
            labelWithoutSpaces.Text = "Без пробілів: " + withoutSpaces;
            labelWords.Text = "Кількість слів: " + words;
            labelVowels.Text = "Голосних: " + vowels;
            labelDigits.Text = "Цифр: " + digits;
            labelLongestWord.Text = "Найдовше слово: " + longestWord;
        }
    }
}