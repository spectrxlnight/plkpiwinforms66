namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            int sum = a + b;
            label1.Text = "Сума: " + sum;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = checkBox1.Checked;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
