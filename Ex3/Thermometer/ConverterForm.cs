using System;
using System.Windows.Forms;

namespace DiscountCalculate
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += KeyPush;
        }

        private void KeyPush(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Delete) 
            {
                textBoxC.Clear();
                textBoxF.Clear();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl.Equals(textBoxC)) fromCtoF();
                else fromFtoC();
            }
        }

        private void textBoxC_Leave(object sender, System.EventArgs e)
        {
            fromCtoF();
        }

        private void textBoxF_Leave(object sender, System.EventArgs e) 
        {
            fromFtoC();
        }

        private void fromCtoF() 
        {
            string gradus = textBoxC.Text;
            if (double.TryParse(gradus, out double value))
                textBoxF.Text = Math.Round((value * 1.8 + 32), 2).ToString();
            else textBoxF.Text = "";
        }

        private void fromFtoC()
        {
            string gradus = textBoxF.Text;
            if (double.TryParse(gradus, out double value))
                textBoxC.Text = Math.Round(((value - 32) / 1.8), 2).ToString();
            else textBoxC.Text = "";
        }
    }
}
