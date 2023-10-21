using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppNextGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if (displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();
                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numPressed.ToString();
                }
            }
        }


        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void displayLabelButton_Click(Object sender, EventArgs e)
        {

        }


        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "-" + displayLabel.Text;
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displayLabel.Text = sqrt.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            displayLabel1.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '*';
            result = result * num1;
            displayLabel.Text = "";
            displayLabel1.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '/';
            result = result / num1;
            displayLabel.Text = "";
            displayLabel1.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '-';
            result = result - num1;
            displayLabel.Text = "";
            displayLabel1.Text = "";
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '%';
            //result = (num1 / num2) * 100;
            //result = (num1 / 100) * num2;
            displayLabel.Text = "";
            displayLabel1.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '+';
            result = result + num1;
            displayLabel.Text = "";
            displayLabel1.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 * num2;
                        break;
                    case '%':
                        num2 = float.Parse(displayLabel.Text);
                        //result = num1 * num2;
                        result = (num1 / 100) * num2;
                        break;
                    default:
                        break;

                }
            }
            displayLabel.Text = ""; 
            displayLabel1.Text = result.ToString();
        }
    }
}
