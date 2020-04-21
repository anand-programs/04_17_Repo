using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Delete the character to the right of  cursor
            DeleteTextValue();

            //Focus the cursor
            FocusInputText();
        }

        #endregion

        #region Operators Methods

        private void DivisonButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            //Focus the cursor
            FocusInputText();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            //Focus the cursor
            FocusInputText();
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            //Focus the cursor
            FocusInputText();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            //Focus the cursor
            FocusInputText();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
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
            InsertTextValue(".");

            //Focus the cursor
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

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

        //Deletes a character to the right of the cursor
        private void DeleteTextValue()
        {
            //If there is nothing to delete
            if (this.UserInput.Text.Length < this.UserInput.SelectionStart + 1)
                return;

            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //Dlete the character to the right of the cusror
            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);

            //Restore selection start
            this.UserInput.SelectionStart = selectionStart;

            //Set selection lenght to 0 (selecting a part will focus the cursor to start of selection)
            this.UserInput.SelectionLength = 0;
        }

        #endregion

        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }
    }
}
