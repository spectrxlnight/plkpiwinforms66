using System;
using System.Windows.Forms;

namespace Variant7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double usdRate = 41.0;
            double eurRate = 44.0;
            double plnRate = 10.2;

            double uah;

            if (!double.TryParse(textBoxHryvnia.Text, out uah))
            {
                MessageBox.Show("Помилка: введіть число");
                return;
            }

            if (uah < 0)
            {
                MessageBox.Show("Помилка: сума не може бути від'ємною");
                return;
            }

            double usd = uah / usdRate;
            double eur = uah / eurRate;
            double pln = uah / plnRate;

            labelUSD.Text = "Долари: " + usd.ToString("F2");
            labelEUR.Text = "Євро: " + eur.ToString("F2");
            labelPLN.Text = "Злоті: " + pln.ToString("F2");
        }
    }
}
