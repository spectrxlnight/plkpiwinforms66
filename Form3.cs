using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        string[] phrases =
        {
            "Працюй далі!",
            "У тебе виходить!",
            "Чудова робота!",
            "Так тримати!"
        };

        int index = 0;

        public Form3()
        {
            InitializeComponent();
            labelPhrase.Text = phrases[0];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            index++;

            if (index >= phrases.Length)
            {
                index = 0;
            }

            labelPhrase.Text = phrases[index];
        }
    }
}
