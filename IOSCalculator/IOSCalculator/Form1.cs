using System;
using System.Windows.Forms;

namespace IOSCalculator
{
    public partial class Calculator : Form
    {
        private string expression = string.Empty;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void btnAllClear(object sender, EventArgs e)
        {
            expression = string.Empty;
            richTextBox1.Text = expression;
        }

        private void btnBackspace(object sender, EventArgs e)
        {
            if (expression.Length > 0)
            {
                expression = expression.Substring(0, expression.Length - 1);
                richTextBox1.Text = expression;
            }
        }

        private void btnMod(object sender, EventArgs e)
        {
            expression += "%";
            richTextBox1.Text = expression;
        }

        private void btnPlus(object sender, EventArgs e)
        {
            expression += "+";
            richTextBox1.Text = expression;
        }

        private void btnMinus(object sender, EventArgs e)
        {
            expression += "-";
            richTextBox1.Text = expression;
        }

        private void btnMul(object sender, EventArgs e)
        {
            expression += "*";
            richTextBox1.Text = expression;
        }

        private void btnDiv(object sender, EventArgs e)
        {
            expression += "/";
            richTextBox1.Text = expression;
        }

        private void btnSqRt(object sender, EventArgs e)
        {
            try
            {
                double squareroot = Convert.ToDouble(expression);
                double result = Math.Sqrt(squareroot);
                expression = result.ToString();
                richTextBox1.Text = expression;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expression = string.Empty;
                richTextBox1.Text = expression;
            }
        }

        private void btnBracketOpen(object sender, EventArgs e)
        {
            expression += "(";
            richTextBox1.Text = expression;
        }

        private void btnBracketClose(object sender, EventArgs e)
        {
            expression += ")";
            richTextBox1.Text = expression;
        }

        private void btnSquare(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);
                double result = Math.Pow(number, 2);
                expression = result.ToString();
                richTextBox1.Text = result.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool containsPi = false; // Flag to check if the expression contains π
        private void btnPi(object sender, EventArgs e)
        {
            try
            {
                expression += "π";
                richTextBox1.Text = expression;
                containsPi = true; // Set the flag to indicate that the expression contains π
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogPower2(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);
                double result = Math.Log(number, 2);
                expression = result.ToString("F2");
                richTextBox1.Text = expression;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);
                double result = Math.Tan(number);
                expression = result.ToString();
                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);
                double result = Math.Cos(number);
                expression = result.ToString();
                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSin(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);
                double result = Math.Sin(number);
                expression = result.ToString();
                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResult(object sender, EventArgs e)
        {
            try
            {
                if (containsPi)
                {
                    // Replace π with its numeric value (Math.PI) and then evaluate the expression
                    expression = expression.Replace("π", Math.PI.ToString());
                }

                double result = Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expression = string.Empty;
                richTextBox1.Text = expression;
            }

            try
            {
                double result = Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
                expression = result.ToString();
                richTextBox1.Text = expression;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expression = string.Empty;
                richTextBox1.Text = expression;
            }
        }

        private void btnDot(object sender, EventArgs e)
        {
            expression += ".";
            richTextBox1.Text = expression;
        }

        private void btnZero(object sender, EventArgs e)
        {
            expression += "0";
            richTextBox1.Text = expression;
        }

        private void btnOne(object sender, EventArgs e)
        {
            expression += "1";
            richTextBox1.Text = expression;
        }

        private void btnTwo(object sender, EventArgs e)
        {
            expression += "2";
            richTextBox1.Text = expression;
        }

        private void btnThree(object sender, EventArgs e)
        {
            expression += "3";
            richTextBox1.Text = expression;
        }

        private void btnFour(object sender, EventArgs e)
        {
            expression += "4";
            richTextBox1.Text = expression;
        }

        private void btnFive(object sender, EventArgs e)
        {
            expression += "5";
            richTextBox1.Text = expression;
        }

        private void btnSix(object sender, EventArgs e)
        {
            expression += "6";
            richTextBox1.Text = expression;
        }

        private void btnSeven(object sender, EventArgs e)
        {
            expression += "7";
            richTextBox1.Text = expression;
        }

        private void btnEight(object sender, EventArgs e)
        {
            expression += "8";
            richTextBox1.Text = expression;
        }

        private void btnNine(object sender, EventArgs e)
        {
            expression += "9";
            richTextBox1.Text = expression;
        }
    }
}

