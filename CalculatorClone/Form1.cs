namespace CalculatorClone
{
    public partial class Form1 : Form
    {
        char operation = '0';
        decimal storedValue = 0;
        bool clearNext = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Button btnClicked = sender as Button;
                if (lblScreen.Text != "0" && clearNext == false)
                {
                    lblScreen.Text = lblScreen.Text + btnClicked.Text;
                }
                else
                {
                    lblScreen.Text = btnClicked.Text;
                    clearNext = false;
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            storedValue = decimal.Parse(lblScreen.Text);
            clearNext = true;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = '-';
            storedValue = decimal.Parse(lblScreen.Text);
            clearNext = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = '*';
            storedValue = decimal.Parse(lblScreen.Text);
            clearNext = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = '/';
            storedValue = decimal.Parse(lblScreen.Text);
            clearNext = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //operate the stored value against the value in the screen
            decimal secondValue = decimal.Parse(lblScreen.Text);
            decimal result = 0;
            if (operation == '+')
            {
                result = storedValue + secondValue;
            }
            else if (operation == '-')
            {
                result = storedValue - secondValue;
            }
            else if (operation == '/')
            {
                result = storedValue / secondValue;
            }
            else if (operation == '*')
            {
                result = storedValue * secondValue;
            }

            //display the result.
            lblScreen.Text = result.ToString();

            //set the screen to clear on next digit being entered.
            clearNext = true;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (clearNext == false)
            {
                //check there isn't already a decimal point
                if (!lblScreen.Text.Contains("."))
                {
                    lblScreen.Text = lblScreen.Text + ".";
                }
            }
            else
            {
                lblScreen.Text = "0.";
                clearNext = false;
            }
        }
    }
}
