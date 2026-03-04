using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscountCalculate
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private bool CheckPasswordLength(string pass)
        {
            if(pass.Length < 8)
                return false;
            return true;
        }

        private bool CheckPasswordDigits(string pass)
        { 
            foreach(char c in pass)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        private void ShowPasswordStrength(string rez) 
        {
            resultRTB.Text = "Надежность пароля: " + rez;
            resultRTB.Select(18, resultRTB.Text.Length);
            if(rez.Equals("Слабый")) resultRTB.SelectionColor = Color.Red;
            else if (rez.Equals("Средний")) resultRTB.SelectionColor = Color.Yellow;
            else resultRTB.SelectionColor = Color.DarkGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            if (!CheckPasswordLength(pass))
                pass = "Слабый";
            else if (!CheckPasswordDigits(pass))
                pass = "Средний";
            else 
                pass = "Надежный";

            ShowPasswordStrength(pass);
        }
    }
}
