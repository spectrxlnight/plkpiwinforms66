namespace _1112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
 Random r = new Random();
            Point p = new Point(r.Next(0, this.ClientSize.Width - Button1.Width), r.Next(0, this.ClientSize.Height - Button1.Height));
            Button1.Location = p;
        }
    }
}
