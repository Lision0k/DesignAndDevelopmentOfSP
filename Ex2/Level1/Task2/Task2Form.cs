using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task2Form : Form
    {
        MainForm mf;
        public Task2Form(MainForm mf)
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
            if (int.TryParse(textBox0.Text.Substring(ind+2), out int n) && n > 0)
            {
                Random random = new Random();
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(1, 101);
                }

                int max = array[0], min = array[0];
                int maxIndex = 0, minIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }
                label1.Text = $"Массив: [{string.Join(", ", array)}]\n" +
                                  $"Максимум: {max} (индекс {maxIndex})\n" +
                                  $"Минимум: {min} (индекс {minIndex})";
            }
            else
            {
                MessageBox.Show("Введите положительное число для размера массива");
            }
        }
    }
}
