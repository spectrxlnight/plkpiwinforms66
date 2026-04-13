using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        bool isX = true;
        string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();

            btnRun.MouseEnter += btnRun_MouseEnter;

            btn1.Click += Cell_Click;
            btn2.Click += Cell_Click;
            btn3.Click += Cell_Click;
            btn4.Click += Cell_Click;
            btn5.Click += Cell_Click;
            btn6.Click += Cell_Click;
            btn7.Click += Cell_Click;
            btn8.Click += Cell_Click;
            btn9.Click += Cell_Click;

            btnRestartGame.Click += btnRestartGame_Click;
            btnOpenFile.Click += btnOpenFile_Click;
            btnSaveFile.Click += btnSaveFile_Click;

            lblTurn.Text = "Хід: X";
        }

        Random rnd = new Random();

        private void btnRun_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - btnRun.Width;
            int maxY = this.ClientSize.Height - btnRun.Height;

            int newX = rnd.Next(0, maxX);
            int newY = rnd.Next(0, maxY);

            btnRun.Location = new Point(newX, newY);
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != "")
                return;

            btn.Text = isX ? "X" : "O";

            if (CheckWinner())
            {
                MessageBox.Show("Переміг: " + btn.Text);
                DisableGameButtons();
                return;
            }

            if (IsDraw())
            {
                MessageBox.Show("Нічия");
                return;
            }

            isX = !isX;
            lblTurn.Text = "Хід: " + (isX ? "X" : "O");
        }

        private bool CheckWinner()
        {
            return
                CheckLine(btn1, btn2, btn3) ||
                CheckLine(btn4, btn5, btn6) ||
                CheckLine(btn7, btn8, btn9) ||
                CheckLine(btn1, btn4, btn7) ||
                CheckLine(btn2, btn5, btn8) ||
                CheckLine(btn3, btn6, btn9) ||
                CheckLine(btn1, btn5, btn9) ||
                CheckLine(btn3, btn5, btn7);
        }

        private bool CheckLine(Button a, Button b, Button c)
        {
            return a.Text != "" && a.Text == b.Text && b.Text == c.Text;
        }

        private bool IsDraw()
        {
            return btn1.Text != "" && btn2.Text != "" && btn3.Text != "" &&
                   btn4.Text != "" && btn5.Text != "" && btn6.Text != "" &&
                   btn7.Text != "" && btn8.Text != "" && btn9.Text != "";
        }

        private void DisableGameButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void EnableGameButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            EnableGameButtons();

            isX = true;
            lblTurn.Text = "Хід: X";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = ofd.FileName;
                txtEditor.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (currentFilePath == "")
            {
                MessageBox.Show("Спочатку відкрий файл");
                return;
            }

            File.WriteAllText(currentFilePath, txtEditor.Text);
            MessageBox.Show("Файл збережено");
        }
    }
}