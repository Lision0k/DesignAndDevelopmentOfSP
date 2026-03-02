using System;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task3Form : Form
    {
        MainForm mf;
        public Task3Form(MainForm mf)
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
            Random random = new Random();
            int[] array = new int[15];
            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(10, 51);
            }

            foreach (int num in array)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            label1.Text = $"Массив: [{string.Join(", ", array)}]\n" +
                              $"Чётных чисел: {evenCount}\n" +
                              $"Нечётных чисел: {oddCount}";
        }
    }
}
