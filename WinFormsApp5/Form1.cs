namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private object labelResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //зміна кольору фону при натисканні
            this.BackColor = Color.Coral;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            //  MessageBox.Show(name);
            label2.Text = "Hello," + name + "!";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        //string name1 = textBox2.Text;
        //string name2 = textBox3.Text;
        //label3.Text = " name1 + name2 ";
        private void button3_Click(object sender, EventArgs e)

        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            int sum = a + b;
            label3.Text = "Сума: " + sum;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(label1.Visible)
            { label1.Visible = false; }
            else
            {
                label1.Visible = true;
            }
        }
    }
}
