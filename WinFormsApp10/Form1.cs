using System.IO;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        private string[] paths = new string[]
        {
            @"C:\Users\Student\source\repos\spectrxlnight\plkpiwinforms66\WinFormsApp10\Resources\George_Floyd.png",
            @"C:\Users\Student\source\repos\spectrxlnight\plkpiwinforms66\WinFormsApp10\Resources\nig103.png",
            @"C:\Users\Student\source\repos\spectrxlnight\plkpiwinforms66\WinFormsApp10\Resources\b10.png",
        };
        private int currentIndex = 0;

        private Image LoadImage(string path)
        {
            return new Bitmap(path);
        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = LoadImage(paths[0]);
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_SizeModeChanged(object sender, EventArgs e) { }

        private void b1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + paths.Length) % paths.Length;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = LoadImage(paths[currentIndex]);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % paths.Length;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = LoadImage(paths[currentIndex]);
        }
    }
}