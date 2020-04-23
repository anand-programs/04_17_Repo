using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// A simple Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Delete Methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears text from user input box
            this.UserInput.Text = string.Empty;
            //or just "" is also ok

            //Focus the cursor
            FocusInputText();
        }

        //CE and C buttons have the same funciton in this calculator
        private void CButton_Click(object sender, EventArgs e)
        {
            //Clears text from user input box
            this.UserInput.Text = string.Empty;

            //Focus the cursor
            FocusInputText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Delete the character to the left of  cursor
            DeleteTextValue();

            //Focus the cursor
            FocusInputText();
        }

        #endregion

        #region Operators Methods

        private void DivisonButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '/' after an operator or decimal
            if (this.UserInput.Text != "" && Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                InsertTextValue("/");
            }
            
            //Focus the cursor
            FocusInputText();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '*' after an operator or decimal
            if (this.UserInput.Text != "" && Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                InsertTextValue("*");
            }

            //Focus the cursor
            FocusInputText();
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '-' after an operator or decimal
            if (this.UserInput.Text == "" || Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                InsertTextValue("-");
            }

            //Focus the cursor
            FocusInputText();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '+' after an operator or decimal
            if (this.UserInput.Text != "" && Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                InsertTextValue("+");
            }

            //Focus the cursor
            FocusInputText();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if(!this.UserInput.Text.Contains('='))
            {
                InsertAnswer(CalculateEquation());
            }

            //Focus the cursor
            FocusInputText();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            //Insert a minus sign if nothing has been inserted
            if (this.UserInput.Text.Length == 0)
            {
                InsertTextValue("-");
            }

            //Delete the minus sign (make it positive) if a minus has already been inserted
            else if(this.UserInput.Text == "-")
            {
                //Clear the minus sign
                this.UserInput.Text = string.Empty;
            }

            //Focus the cursor
            FocusInputText();
        }

        #endregion

        #region Numbers Method

        //Inserts the specified number
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '.' after an operator or decimal
            if (Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                InsertTextValue(".");
            }

            //Focus the cursor
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Restricting from entering '0' after '/'
            if ((this.UserInput.Text[this.UserInput.Text.Length - 1] != '/'))
            {
                InsertTextValue("0");
            }

            //Focus the cursor
            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //Focus the cursor
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //Focus the cursor
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //Focus the cursor
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus the cursor
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //Focus the cursor
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //Focus the cursor
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //Focus the cursor
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //Focus the cursor
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            //Focus the cursor
            FocusInputText();
        }

        #endregion

        #region Private Helping Methods

        private void FocusInputText()
        {
            this.UserInput.Focus();
        }

        //Insert at the cursor
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //Set new text
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);

            //Restore selection start
            this.UserInput.SelectionStart = selectionStart + value.Length;

            //Set selection lenght to 0 (selecting a part will focus the cursor to start of selection)
            this.UserInput.SelectionLength = 0;
        }

        private void InsertAnswer(double value)
        {
            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //Set new text
            this.UserInput.Text = Convert.ToString(value);

            //Restore selection start
            this.UserInput.SelectionStart = selectionStart + 1 + Convert.ToString(value).Length;

            //Set selection lenght to 0 (selecting a part will focus the cursor to start of selection)
            this.UserInput.SelectionLength = 0;
        }

        //Deletes a character to the left of the cursor
        private void DeleteTextValue()
        {
            //If there is nothing to delete
            if (this.UserInput.Text == "")
                return;

            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //Delete the character to the left of the cusror
            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart - 1, 1);

            //Restore selection start
            this.UserInput.SelectionStart = selectionStart - 1;
            //this.UserInput.Select(selectionStart - 1, 1);

            //Set selection lenght to 0 (selecting a part will focus the cursor to start of selection)
            this.UserInput.SelectionLength = 0;
        }

        #endregion

        #region Final Calculation Method

        private double CalculateEquation()
        {
            //Get input text in variable input
            var input = this.UserInput.Text;

            //Count for number of operators in the input text
            int operatorCount = 0;
            //Count number of variables
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    operatorCount++;
                }
            }

            //Character string for storing operators
            char[] operatorString = new char[operatorCount];
            //Integer string for storing index of operators
            int[] operatorIndex = new int[operatorCount];
            int j = 0;
            //Capture operator along with its index
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    //Capture operator
                    operatorString[j] = input[i];

                    //Capture index of that operator
                    operatorIndex[j] = i;
                    j++;
                }
            }
           
            int minusIndicator = 0;
            //Checking if there is a minus sign at the start
            if(operatorIndex[0] == 0)
            {
                 minusIndicator = 1;
            }

            //Integer string for storing numbers in the text input
            double[] numberString = new double[operatorCount + 1];
            //Capture individual numbers
            for (int i = 0; i <= operatorCount; i++)
            {
                //First number in the input text
                if (i == 0)
                {
                    numberString[0] = double.Parse(input.Substring(0, operatorIndex[0]));
                    //MessageBox.Show(numberString[i].ToString());
                }

                //Remaining numbers in the input text
                else if (i != operatorCount)
                {
                    
                    numberString[i] = double.Parse(input.Substring(operatorIndex[i - 1] + 1, operatorIndex[i] - operatorIndex[i - 1] - 1));
                    //MessageBox.Show(numberString[i].ToString());
                }

                //Last number in the input text
                else
                {
                    numberString[i] = double.Parse(input.Substring(operatorIndex[i - 1] + 1, input.Length + minusIndicator - operatorIndex[i - 1] - 1));
                    //MessageBox.Show(numberString[i].ToString());
                }
            }

            //Initialize result
            double result = numberString[0];
            //Solving the equation
            for (int i = 0; i < operatorCount; i++)
            {
                //For current operator being Multiply or Divide operator
                if (operatorString[i] == '*' || operatorString[i] == '/')
                {
                    switch (operatorString[i])
                    {
                        case '*':
                            result = Multiply(result, numberString[i + 1]);
                            break;

                        case '/':
                            result = Divide(result, numberString[i + 1]);
                            break;
                    }
                }

                //For current operator being Add or Subtract operator
                else
                {
                    //Operators other than last one
                    if (i != operatorCount - 1)
                    {
                        //For next operator being Multiply or Divide operator
                        if (operatorString[i + 1] == '*' || operatorString[i + 1] == '/')
                        {
                            //Store result and operator in a temperory variable
                            double tempResult = result;
                            char tempOperator = operatorString[i];

                            //Multiply or Divide at least once since we are in the loop
                            do
                            {
                                i++;

                                //Multiply or Divide the next two numbers
                                switch (operatorString[i])
                                {
                                    case '*':
                                        result = Multiply(numberString[i], numberString[i + 1]);
                                        break;

                                    case '/':
                                        result = Divide(numberString[i], numberString[i + 1]);
                                        break;
                                }

                                numberString[i + 1] = result;
                            }

                            //Execute the loop till the next operator is Multiply or Divide
                            while (i != operatorCount - 1 && (operatorString[i + 1] == '*' || operatorString[i + 1] == '/'));

                            //Add or Subtract the result of next two number with the current number
                            switch (tempOperator)
                            {
                                case '+':
                                    result = Add(tempResult, result);
                                    break;

                                case '-':
                                    result = Subtract(tempResult, result);
                                    break;
                            }
                        }

                        //For next operator not being Multiply or Divide
                        else
                        {
                            switch (operatorString[i])
                            {
                                case '+':
                                    result = Add(result, numberString[i + 1]);
                                    break;

                                case '-':
                                    result = Subtract(result, numberString[i + 1]);
                                    break;
                            }
                        }
                    }

                    //Last operator
                    else
                    {
                        switch (operatorString[i])
                        {
                            case '+':
                                result = Add(result, numberString[i + 1]);
                                break;

                            case '-':
                                result = Subtract(result, numberString[i + 1]);
                                break;
                        }
                    }
                }
            }

            //this.UserInput.Text = this.UserInput.Text + "=" + result;

            return result;
        }

        #endregion

        #region Operator Methods for Final Calculaiton Method
        private double Add(double a, double b)
        {
            return a + b;
        }

        private double Subtract(double a, double b)
        {
            return a - b;
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        private double Divide(double a, double b)
        {
            return a / b;
        }

        #endregion

        #region Restricting Invalid Input Method

        //Restrict user from entering invalid Input
        //A KeyPress component had to be added in the InitializeComponent method to run this method
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If an operator has been pressed
            if (this.UserInput.Text != "" && !Char.IsDigit(this.UserInput.Text[this.UserInput.Text.Length - 1]))
            {
                //If an operator has been pressed again OR a '0' follows a '/'
                if (!Char.IsDigit(e.KeyChar) || (this.UserInput.Text[this.UserInput.Text.Length - 1]) == '/' && e.KeyChar == '0')
                {
                    //Handle this event, that is, tha basic functionality of this event will be bypassed, that is not able to press key
                    e.Handled = true;
                }
            }

            //Focus the cursor
            FocusInputText();
        }

        #endregion
    }
}
