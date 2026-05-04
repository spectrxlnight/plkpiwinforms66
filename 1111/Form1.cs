namespace _1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            Point p = new Point(r.Next(0, this.ClientSize.Width - button1.Width), r.Next(0, this.ClientSize.Height - button1.Height));
            button1.Location = p;
        }
    }
}
