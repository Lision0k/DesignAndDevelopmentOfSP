using System;
using System.Windows.Forms;

namespace Level1
{
    public partial class Task1Form : Form
    {
        MainForm mf;
        public Task1Form(MainForm mf)
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
            try {
                TextBox[] TB = new TextBox[] {textBox1, textBox2 , textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10};
                int sum = 0;
                foreach (TextBox tb in TB) {
                    int ind = tb.Text.IndexOf(":") + 2;
                    if (string.IsNullOrWhiteSpace(tb.Text.Substring(ind)))
                    {
                        MessageBox.Show("Заполните все поля!", "Ошибка");
                        return;
                    }
                    sum += Convert.ToInt32(tb.Text.Substring(ind));
                    }
                textBoxResult.Text = "Сумма эл-ов массива = " + sum.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число!", "Ошибка");
            }
        }
    }
}
