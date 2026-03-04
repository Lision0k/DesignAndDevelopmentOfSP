using System;
using System.Windows.Forms;

namespace DiscountCalculate
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                if (result > 5000)
                    result *= 0.9;
                else if (result >= 1000)
                    result *= 0.95;
                label2.Text = "Итоговая сумма к оплате: " + result.ToString();
            }
            else {
                MessageBox.Show("Введите число!", "Ошибка");
            }
        }
    }
}
