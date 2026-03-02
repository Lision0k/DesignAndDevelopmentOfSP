using System;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task4Form : Form
    {
        MainForm mf;
        public Task4Form(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }

        private int[] Reverse(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
            return arr;
        }
        private void buttonCount_Click(object sender, EventArgs e)
        {
            TextBox[] TB = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5};
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                if (int.TryParse(TB[i].Text.Substring(11), out int value))
                {
                    array[i] = value;
                }
                else
                {
                    MessageBox.Show($"Ошибка в поле {i + 1}: введите целое число");
                    return;
                }
            }
            label1.Text = $"Массив: \n[{string.Join(", ", array)}]\n" + $"Ревeрсированный массив: \n[{string.Join(", ", Reverse(array))}]";
        }
    }
}
