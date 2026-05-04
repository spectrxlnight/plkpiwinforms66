using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        List<string> queue = new List<string>();
        List<string> serviceTypes = new List<string>()
        {
            "Паспорт",
            "Довідка",
            "Оплата",
            "Консультація"
        };

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(serviceTypes.ToArray());
            comboBox1.SelectedIndex = 0;

            UpdateQueue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pib = textBox1.Text;
            string service = comboBox1.Text;
            string time = DateTime.Now.ToString("HH:mm:ss");

            if (pib == "")
            {
                MessageBox.Show("Введіть ПІБ клієнта!");
                return;
            }

            string client = pib + " | " + service + " | " + time;
            queue.Add(client);

            textBox1.Clear();
            UpdateQueue();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                MessageBox.Show("Черга порожня!");
                return;
            }

            string nextClient = queue[0];
            queue.RemoveAt(0);

            label1.Text = "Обслуговується: " + nextClient;

            File.AppendAllText("history.txt", nextClient + Environment.NewLine);

            UpdateQueue();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string client in queue)
            {
                if (client.Contains(comboBox1.Text))
                {
                    listBox1.Items.Add(client);
                }
            }

            label2.Text = "Кількість у черзі: " + listBox1.Items.Count;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateQueue();
        }


        private void UpdateQueue()
        {
            listBox1.Items.Clear();

            foreach (string client in queue)
            {
                listBox1.Items.Add(client);
            }

            label2.Text = "Кількість у черзі: " + queue.Count;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            UpdateQueue();
        }
    }
}