using System;
using System.Windows.Forms;

namespace UsefulCalculator
{
    public partial class Form1 : Form
    {
        private bool isFieldCleared;
        private bool isIncompleteOperand;
        private bool isResultEvaluated;
        private bool hasUsedEqualsButton;
        private bool hasGotResultFromEqualButton;
        private String lastOperator;
        private double lastOperand;
        private double result;
        public Form1()
        {
            InitializeComponent();
            this.isFieldCleared = true;
            this.isIncompleteOperand = true;
            this.isResultEvaluated = false;
            this.hasUsedEqualsButton = false;
            this.hasGotResultFromEqualButton = false;
            this.lastOperator = "";
            this.lastOperand = 0;
            this.result = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                isFieldCleared = true;
            }
            else
            {
                isFieldCleared = false;
            }

            if (!isFieldCleared)
            {
                if (isResultEvaluated)
                {
                    this.result += Double.Parse(textBox1.Text);
                }
                else
                {
                    this.result = Double.Parse(textBox1.Text);
                }
                textBox1.Text = this.result.ToString();
                this.isIncompleteOperand = true;
                this.lastOperator = "+";
            }
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                isFieldCleared = true;
            }
            else
            {
                isFieldCleared = false;
            }

            if (!isFieldCleared)
            {
                if (isResultEvaluated)
                {
                    this.result -= Double.Parse(textBox1.Text);
                }
                else
                {
                    this.result = Double.Parse(textBox1.Text);
                }
                textBox1.Text = this.result.ToString();
                this.isIncompleteOperand = true;
                this.lastOperator = "-";
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                isFieldCleared = true;
            }
            else
            {
                isFieldCleared = false;
            }

            if (!isFieldCleared)
            {
                if (isResultEvaluated)
                {
                    this.result *= Double.Parse(textBox1.Text);
                }
                else
                {
                    this.result = Double.Parse(textBox1.Text);
                }
                textBox1.Text = this.result.ToString();
                this.isIncompleteOperand = true;
                this.lastOperator = "*";
            }
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                isFieldCleared = true;
            }
            else
            {
                isFieldCleared = false;
            }

            if (!isFieldCleared)
            {
                if (isResultEvaluated)
                {
                    this.result /= Double.Parse(textBox1.Text);
                }
                else
                {
                    this.result = Double.Parse(textBox1.Text);
                }
                textBox1.Text = this.result.ToString();
                this.isIncompleteOperand = true;
                this.lastOperator = "/";
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.isFieldCleared = true;
            this.isIncompleteOperand = true;
            this.isResultEvaluated = false;
            this.hasUsedEqualsButton = false;
            this.lastOperator = "";
            this.lastOperand = 0;
            this.result = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            this.hasUsedEqualsButton = false;
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!hasUsedEqualsButton && !textBox1.Text.Equals(""))
            {
                this.lastOperand = Double.Parse(textBox1.Text);
            }

            if (!this.isIncompleteOperand)
            {
                switch (this.lastOperator)
                {
                    case "+":
                        if (hasUsedEqualsButton)
                        {
                            this.result += this.lastOperand;
                        }
                        else
                        {
                            this.result += Double.Parse(textBox1.Text);
                        }
                        break;
                    case "-":
                        if (hasUsedEqualsButton)
                        {
                            this.result -= this.lastOperand;
                        }
                        else
                        {
                            this.result -= Double.Parse(textBox1.Text);
                        }
                        break;
                    case "*":
                        if (hasUsedEqualsButton)
                        {
                            this.result *= this.lastOperand;
                        }
                        else
                        {
                            this.result *= Double.Parse(textBox1.Text);
                        }
                        break;
                    case "/":
                        if (hasUsedEqualsButton)
                        {
                            this.result /= this.lastOperand;
                        }
                        else
                        {
                            this.result /= Double.Parse(textBox1.Text);
                        }
                        break;
                }
            }
            textBox1.Text = this.result.ToString();
            this.isIncompleteOperand = false;
            this.hasUsedEqualsButton = true;
            this.hasGotResultFromEqualButton = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button1.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button2.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button3.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button4.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button5.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button6.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button7.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button8.Text;
            this.hasUsedEqualsButton = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            textBox1.Text += button9.Text;
            this.hasUsedEqualsButton = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            if (!textBox1.Text.Equals("0"))
            {
                textBox1.Text += button10.Text;
            }
            this.hasUsedEqualsButton = false;
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            if (!textBox1.Text.Equals(""))
            {
                textBox1.Text += button11.Text;
            }
            else
            {
                textBox1.Text = "0";
            }
            this.hasUsedEqualsButton = false;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (this.isIncompleteOperand)
            {
                textBox1.Text = "";
                this.isIncompleteOperand = false;
            }
            else if (this.hasGotResultFromEqualButton)
            {
                textBox1.Text = "";
                this.hasGotResultFromEqualButton = false;
            }

            if (!textBox1.Text.Contains("."))
            {
                if (textBox1.Text.Equals(""))
                {
                    textBox1.Text += "0";
                }
                textBox1.Text += button12.Text;
            }
            this.hasUsedEqualsButton = false;
        }
    }
}
