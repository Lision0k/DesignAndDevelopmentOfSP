using System;
using System.Windows.Forms;

namespace Level1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task1Form task1Form = new Task1Form(this);
            task1Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form(this);
            task2Form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3Form task3Form = new Task3Form(this);
            task3Form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task4Form task4Form = new Task4Form(this);
            task4Form.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Task5Form task5Form = new Task5Form(this);
            task5Form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Task6Form task6Form = new Task6Form(this);
            task6Form.Show();
            this.Hide();
        }
    }
}
