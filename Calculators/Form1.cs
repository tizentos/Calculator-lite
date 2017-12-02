using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        bool SecondFunctionActivated = false;
        public Form1()
        {
            InitializeComponent();
            calculator.myText = textResult;
            calculator.myLabel = labelCalc;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            calculator.IsOperation = false;
            Button button = (Button)sender;
            if ((calculator.myText.Text == "0") || calculator.IsPerformed||calculator.IsOperation)
            {
                if (button.Text != "0")
                {
                    if (button.Text != "." )
                    {
                        if (button.Text != "±")
                        {
                            calculator.myText.Clear();
                            calculator.myText.Text += button.Text;
                        }
                    }
                    else
                        calculator.myText.Text="0"+button.Text;
                }
                else 
                {
                    textResult.Text = "0";
                }
            }
            else
                if (button.Text != "±")
                {
                    if (button.Text != ".")
                        calculator.myText.Text += button.Text;
                    else
                        if (!(calculator.myText.Text.Contains(".")))
                            calculator.myText.Text += button.Text;
                }
                else
                    if (!calculator.myText.Text.Contains("-"))
                        calculator.myText.Text = "-" + textResult.Text;
            calculator.IsPerformed = false;
            if (!calculator.IsOperation && (!calculator.IsPerformed))
                calculator.IsOperation = true;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!calculator.IsOperation)
            {
                calculator.OperationToPerform = button.Text;
                calculator.ParseText(calculator.myText.Text);
                calculator.IsOperation = true;
                calculator.UpdateLabel(calculator.IsOperation);
            }
            else
            {
                calculator.UpdateLabel(true);
                calculator.PerformOperation(calculator.OperationToPerform);
                calculator.OperationToPerform = button.Text;
            }
            calculator.UpdateLabel(true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculator.PerformOperation(calculator.OperationToPerform);
            calculator.UpdateLabel(calculator.IsOperation);
            calculator.OperationToPerform = " ";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.myText.Text = calculator.myText.Text.Remove(calculator.myText.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("nothing to delete", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textResult.Text = "0";
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(232, 343);
            Scientificpanel1.Visible = false;
            Basicpanel1.Location = new Point(8, 72);
            buttonSecondFunction.Enabled = false;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(232, 343);
            Scientificpanel1.Visible = false;
            Basicpanel1.Location = new Point(8, 72);
            buttonSecondFunction.Enabled = false;
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(232, 437);
            Scientificpanel1.Visible = true;
            Basicpanel1.Location = new Point(8, 164);
            buttonSecondFunction.Enabled = true;
        }

        private void buttonSecondFunction_Click(object sender, EventArgs e)
        {
            if (!SecondFunctionActivated)
            {
                buttonCos.Text = "Acos";
                buttonCos.Size = new System.Drawing.Size(50, 30);
                buttonCube.Text = "y√x";
                buttonFacto.Text = "π";
                buttonLin.Text = "e^";
                buttonLog.Text = "10^";
                buttonSin.Text = "Asin";
                buttonTan.Text = "Atan";
                buttonTan.Size = new System.Drawing.Size(50, 30);
                SecondFunctionActivated = true;
            }
            else
            {
                buttonCos.Text = "cos";
                buttonCube.Text = "x³";
                buttonFacto.Text = "n!";
                buttonLin.Text = "In";
                buttonLog.Text = "log10";
                buttonSin.Text = "sin";
                buttonTan.Text = "tan";
                SecondFunctionActivated = false;
            }
        }

        private void OtherOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "y√x")
            {
                if (!calculator.IsOperation)
                {
                    calculator.OperationToPerform = button.Text;
                    calculator.ParseText(calculator.myText.Text);
                    calculator.IsOperation = true;
                    calculator.UpdateLabel(calculator.IsOperation);
                }
                else
                {
                    calculator.UpdateLabel(calculator.IsOperation);
                    calculator.PerformOperation(calculator.OperationToPerform);
                    calculator.OperationToPerform = button.Text;
                }
                calculator.UpdateLabel(true);
            }
            else
                calculator.PerformOtherOperation(button.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator v1.1 \r\nCreated by:Tosin Jemilehin\r\n IT Consultant", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
