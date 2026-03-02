using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task6Form : Form
    {
        MainForm mf;
        public Task6Form(MainForm mf)
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
            TextBox[] TB = new TextBox[] {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10};
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int ind = TB[i].Text.IndexOf(":");
                if (int.TryParse(TB[i].Text.Substring(ind+2), out int value))
                {
                    array[i] = value;
                }
                else
                {
                    MessageBox.Show($"Ошибка в поле {i + 1}: введите целое число");
                    return;
                }
            }
            List<string> results = new List<string>();
            bool[] counted = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                if (!counted[i])
                {
                    int count = 1;
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[j] == array[i])
                        {
                            count++;
                            counted[j] = true;
                        }
                    }
                    results.Add($"Число {array[i]} встречается {count} раз(а)");
                    counted[i] = true;
                }
            }

            label1.Text = string.Join("\n", results);

        }
    }
}
