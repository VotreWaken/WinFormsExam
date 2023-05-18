using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class DefaultCalc : Form
    {
        bool isNewEntry = false, isInfinityException = false, isRepeatLastOperation = false;
        double dblResult = 0, dblOperand = 0;
        char chPreviousOperator = new char();
        public DefaultCalc()
        {
            InitializeComponent();
        }
        private void UpdateOperand(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (isNewEntry)
                {
                    Result.Text = "0";
                    isNewEntry = false;
                }
                if (isRepeatLastOperation)
                {
                    chPreviousOperator = '\0';
                    dblResult = 0;
                }
                if (!(Result.Text == "0" && (Button)sender == btn0) && !(((Button)sender) == btnDecimalPoint && Result.Text.Contains(".")))
                    Result.Text = (Result.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." : ((Result.Text == "0") ? ((Button)sender).Text : Result.Text + ((Button)sender).Text);
            }
        }
        private void ClearOperator(object sender, EventArgs e)
        {
            isInfinityException = false;
            Result.Text = "0";
        }
        private void ChangeSign(object sender, EventArgs e)
        {
            if (!isInfinityException)
                Result.Text = (double.Parse(Result.Text) * -1).ToString();
        }

        private void OperatorFound(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (chPreviousOperator == '\0')
                {
                    chPreviousOperator = ((Button)sender).Text[0];
                    dblResult = double.Parse(Result.Text);
                }
                else if (isNewEntry)
                    chPreviousOperator = ((Button)sender).Text[0];
                else
                {
                    Operate(dblResult, chPreviousOperator, double.Parse(Result.Text));
                    chPreviousOperator = ((Button)sender).Text[0];
                }
                isNewEntry = true;
                isRepeatLastOperation = false;
            }
        }
        void Operate(double dblPreviousResult, char chPreviousOperator, double dblOperand)
        {
            switch (chPreviousOperator)
            {
                case '+':
                    Result.Text = (dblResult = (dblPreviousResult + dblOperand)).ToString();
                    break;
                case '-':
                    Result.Text = (dblResult = (dblPreviousResult - dblOperand)).ToString();
                    break;
                case '*':
                    Result.Text = (dblResult = (dblPreviousResult * dblOperand)).ToString();
                    break;
                case '/':
                    if (dblOperand == 0)
                    {
                        Result.Text = "Cannot divide by zero";
                        isInfinityException = true;
                    }
                    else
                        Result.Text = (dblResult = (dblPreviousResult / dblOperand)).ToString();
                    break;
            }
        }
        private void Equals(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (!isRepeatLastOperation)
                {
                    dblOperand = double.Parse(Result.Text);
                    isRepeatLastOperation = true;
                }
                Operate(dblResult, chPreviousOperator, dblOperand);
                isNewEntry = true;
            }
        }
        private void ClearAll(object sender, EventArgs e)
        {
            isInfinityException = isRepeatLastOperation = false;
            dblOperand = dblResult = 0; Result.Text = "0";
            isNewEntry = true;
            chPreviousOperator = '\0';
        }
    }
}
