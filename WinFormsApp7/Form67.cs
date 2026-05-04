namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a, b;

            bool ok1 = int.TryParse(textBox2.Text, out a);
            bool ok2 = int.TryParse(textBox3.Text, out b);

            if (ok1 && ok2)
            {
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);


                int sum = a + b;
                MessageBox.Show("—ума: " + sum);
            }
            else
            {
                MessageBox.Show("¬вед≥ть два ц≥л≥ числа");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                bool Vis = true;
                if (checkBox1.Checked == true)
                {
                    Vis = true;
                }
                else
                {
                    Vis = false;
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Left = Left + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Left = Left - 10;
            }
        }
    }
}

