using System;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task5Form : Form
    {
        MainForm mf;
        public Task5Form(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int ind = textBox0.Text.IndexOf(":");
            if (int.TryParse(textBox0.Text.Substring(ind + 2), out int n) && n > 0)
            {
                Random random = new Random();
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(1, 101);
                }
                label1.Text = $"Массив: \n[{string.Join(", ", array)}]\n" + $"Массив со сдвигом: \n[{string.Join(", ", Move(array))}]";
            }
        }
        private int[] Move(int[] array)
        {
            int lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
            return array;
        }
    }
}
