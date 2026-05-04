namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random r = new Random();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random btn = new Random();

            button1.Location = new Point(btn.Next(0, 67), btn.Next(0, 67));
        }
    }
}
