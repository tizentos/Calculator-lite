using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    class Calculator
    {
        public TextBox myText;
        public Label myLabel;
        private bool isPerformed;
        private bool isOperation;
        private double dummyVariable = 0;
        private  string operationToPerform=" ";
        public bool IsPerformed
        {
            get {return isPerformed ;}
            set {isPerformed=value; }
        }
        public bool IsOperation
        {
            get { return isOperation;}
            set { isOperation=value;}
        }
        public double DummyVariable { get { return dummyVariable; } set {dummyVariable=value ;} }
        public string OperationToPerform { get { return operationToPerform; } set {operationToPerform=value;} }
        public string LabelText { get { return myLabel.Text; } set { myLabel.Text=value; } }
        public string TextBoxText { get { return myText.Text; } set {myText.Text=value ;} }
        public void UpdateLabel(bool isOperation)
        {
            if (isOperation)
            {
                this.myLabel.Text = "";
                this.LabelText = this.TextBoxText + this.operationToPerform;
            }
            else
                this.LabelText = "";

        }
        public void UpdateText(bool isOperation, bool isPerformed)
        {
            if (isOperation || isPerformed)
                myText.Clear();
        }
        public void PerformOperation(string operationToPerform)
        {
            switch (operationToPerform)
            {
                case "+":
                    myText.Text = (this.dummyVariable + Double.Parse(myText.Text)).ToString();
                    break;
                case "-":
                    myText.Text = (this.dummyVariable - Double.Parse(myText.Text)).ToString();
                    break;
                case "÷":
                    myText.Text = (this.dummyVariable / Double.Parse(myText.Text)).ToString();
                    break;
                case "×":
                    myText.Text = (this.dummyVariable * Double.Parse(myText.Text)).ToString();
                    break;
                case "y√x":
                    myText.Text = Math.Pow(this.dummyVariable,(1.0/Double.Parse(myText.Text))).ToString();
                    break;
                case "^":
                    myText.Text = Math.Pow(this.dummyVariable,Double.Parse(myText.Text)).ToString();
                    break;
                default:
                    break;
            }
            this.dummyVariable = Double.Parse(myText.Text);
            this.isPerformed=true;
            this.isOperation = false;
        }
        public void ParseText(string textboxText)
        {
            this.dummyVariable = Double.Parse(textboxText);
        }
        public void Clear()
        {
            this.dummyVariable = 0;
            UpdateLabel(false);
            this.isOperation =false;
            this.isPerformed = true;
            myText.Text = "0";
            operationToPerform = " ";
        }
        public void PerformOtherOperation(string operation)
        {
            double temp;
            switch (operation)
            {
                case "sin":
                    myLabel.Text = "sin(" + myText.Text + ")";
                    temp = Math.Sin((Double.Parse(myText.Text)*Math.PI)/180.0);
                    myText.Text = temp.ToString();
                    break;
                case "Asin":
                    myLabel.Text = "Asin(" + myText.Text + ")";
                    temp = Math.Asin(Double.Parse(myText.Text));
                    temp = 180.0 * temp / Math.PI;
                    myText.Text = temp.ToString();
                    break;
                case "cos":
                    myLabel.Text = "cos(" + myText.Text + ")";
                    temp = Math.Cos((Double.Parse(myText.Text) * Math.PI) / 180.0);
                    myText.Text = temp.ToString();
                    break;
                case "Acos":
                    myLabel.Text = "Acos(" + myText.Text + ")";
                    temp = Math.Acos(Double.Parse(myText.Text));
                    temp = 180.0 * temp / Math.PI;
                    myText.Text = temp.ToString();

                    break;
                case "tan":
                    myLabel.Text = "tan(" + myText.Text + ")";
                    temp = Math.Tan((Double.Parse(myText.Text) * Math.PI) / 180.0);
                    myText.Text = temp.ToString();
                    break;
                case "Atan":
                    myLabel.Text = "Atan(" + myText.Text + ")";
                    temp = Math.Atan(Double.Parse(myText.Text));
                    temp = 180.0 * temp / Math.PI;
                    myText.Text = temp.ToString();
                    break;
                case "log10":
                    myLabel.Text = "Log10(" + myText.Text + ")";
                    temp = Math.Log10(Double.Parse(myText.Text));
                    myText.Text = temp.ToString();
                    break;
                case "10^":
                    myLabel.Text = "10^(" + myText.Text + ")";
                    temp = Math.Pow(10.0,Double.Parse(myText.Text));
                    myText.Text = temp.ToString();
                    break;
                case "In":
                    myLabel.Text = "In(" + myText.Text + ")";
                    temp = Math.Log(Double.Parse(myText.Text));
                    myText.Text = temp.ToString();
                    break;
                case "e^":
                    myLabel.Text = "e^(" + myText.Text + ")";
                    temp = Math.Exp(Double.Parse(myText.Text));
                    myText.Text = temp.ToString();
                    break;
                case "n!":
                    myLabel.Text = "facto(" + myText.Text + ")";
                    temp = Double.Parse(myText.Text);
                    double prd = 1.0;
                    if (temp == 0 || temp == 1)
                        prd = 1;
                    else
                    {
                        while (temp > 1)
                        {
                            prd = prd * temp;
                            temp--;
                        }
                    }
                    myText.Text = prd.ToString();
                    break;
                case "π":
                    temp = Math.PI;
                    myText.Text = temp.ToString();
                    myLabel.Text = "π";
                    break;
                case "x³":
                    myLabel.Text = "cube(" + myText.Text + ")";
                    temp = Math.Pow(Double.Parse(myText.Text),3);
                    myText.Text = temp.ToString();
                    break;
                case  "√":
                    myLabel.Text = "√(" + myText.Text + ")";
                    temp = Math.Sqrt(Double.Parse(myText.Text));
                    myText.Text = temp.ToString();
                    break;
                case "x²":
                    myLabel.Text = "sqr(" + myText.Text + ")";
                    temp = Math.Pow(Double.Parse(myText.Text), 2);
                    myText.Text = temp.ToString();
                    break;
                case "¹/x":
                    myLabel.Text = "1/(" + myText.Text + ")";
                    temp = 1.0 / Double.Parse(myText.Text);
                    myText.Text = temp.ToString();
                    break;
                default:
                    break;            
            }
            isPerformed = true;
        }
    }
}
