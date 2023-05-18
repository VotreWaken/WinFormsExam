using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class ScienceCalc : Form
    {
        public ScienceCalc()
        {
            InitializeComponent();
        }
        bool blNewEntry = false;
        string strPreviousOperator = string.Empty, strStatisticsOperation = string.Empty;
        double dblResult = 0, dblOperand = 0, dblMemory = 0;
        int inConversionForTrigonometry = 1, inConversionForNonDecimal = 1, inInfinityException = 0, inEquals = 0, inCurrentBase = 10, inParanthesisCount = 0, inCurrentBaseOfMemory = 10;

        string ConvertNumberSystem(int inFromBase, string strOperand, int inToBase)
        {
            if (inFromBase != 10)
                strOperand = Convert.ToInt64(strOperand, inFromBase).ToString();
            if (inToBase != 10)
                strOperand = Convert.ToString((long)double.Parse(strOperand), inToBase).ToUpper();
            if (strOperand == "∞") { Result.Text = "Result is ∞"; inInfinityException = 1; return "Result is ∞"; }
            if (inFromBase == 10 && inToBase == 10) strOperand = ((int)double.Parse(strOperand, CultureInfo.InvariantCulture)).ToString();
            return strOperand;
        }

        void DisableOrEnableNumbers(bool blBinaryStatus, bool blOctalStatus)
        {
            btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = blBinaryStatus;
            btn8.Enabled = btn9.Enabled = blOctalStatus;
        }
        void DisableOrEnableTrigonometric(bool blStatus)
        {
            btnCos.Enabled = btnSin.Enabled = btnCtg.Enabled = btnTg.Enabled = blStatus;
        }
        private void UpdateOperand(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (blNewEntry)
                {
                    Result.Text = "0";
                    blNewEntry = false;
                }
                if (inEquals == 1)
                {
                    strPreviousOperator = string.Empty;
                    dblResult = 0;
                }
                if (Result.Text.Contains("E+0"))
                    Result.Text = Result.Text.Remove(Result.Text.Length - 1) + ((Button)sender).Text;
                else if (sender as Button == btnDecimalPoint && inCurrentBase != 10) { }
                else if (!(Result.Text == "0" && (Button)sender == btn0) && !(((Button)sender) == btnDecimalPoint && Result.Text.Contains(".")))
                    Result.Text = (Result.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." : ((Result.Text == "0") ? ((Button)sender).Text : Result.Text + ((Button)sender).Text);
            }
        }
        private void ChangeSign(object sender, EventArgs e)
        {
            Result.Text = (double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10)) * -1).ToString();
            if (inCurrentBase != 10) Result.Text = ConvertNumberSystem(10, Result.Text, inCurrentBase);
        }
        private void RemoveLastDigit(object sender, EventArgs e)
        {
            if (Result.Text.Contains("E"))
            {
                string strlastThreeCharacters = Result.Text.Substring(Result.Text.Length - 3, 3);
                if (strlastThreeCharacters[0] != 'E') Result.Text = Result.Text.Remove(Result.Text.Length - 1);
                else if (strlastThreeCharacters[2] == '0') Result.Text = Result.Text.Remove(Result.Text.Length - 3);
                else Result.Text = Result.Text.Remove(Result.Text.Length - 1) + "0";
            }
            else if (Result.Text != "0") Result.Text = ((Result.Text = Result.Text.Remove(Result.Text.Length - 1)) == "" | Result.Text == "-") ? "0" : Result.Text;
        }

        private void OperatorFound(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                inEquals = 0;
                if (strPreviousOperator == string.Empty)
                {
                    strPreviousOperator = ((Button)sender).Text;
                    if (Result.Text.Contains("(") == false)
                        dblResult = (inCurrentBase == 10) ? double.Parse(Result.Text, CultureInfo.InvariantCulture) : int.Parse(ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture);
                }
                else if (blNewEntry)
                    strPreviousOperator = ((Button)sender).Text;
                else
                {
                    Operate(dblResult, strPreviousOperator, ((inCurrentBase == 10) ? double.Parse(Result.Text) : int.Parse(ConvertNumberSystem(inCurrentBase, Result.Text, 10))));
                    strPreviousOperator = ((Button)sender).Text;
                }
                blNewEntry = true;
            }
        }
        void Operate(double dblPreviousResult, string strPreviousOperator, double dblOperand)
        {
            switch (strPreviousOperator)
            {
                case "+":
                    Result.Text = (dblResult = (dblPreviousResult + dblOperand)).ToString();
                    break;
                case "-":
                    Result.Text = (dblResult = (dblPreviousResult - dblOperand)).ToString();
                    break;
                case "*":
                    Result.Text = (dblResult = (dblPreviousResult * dblOperand)).ToString();
                    break;
                case "/":
                    Result.Text = (dblResult = (dblPreviousResult / dblOperand)).ToString();
                    if (Result.Text == "∞") { Result.Text = "Cannot divide by zero"; inInfinityException = 1; }
                    break;
                case "Mod":
                    Result.Text = (dblResult = (dblPreviousResult % dblOperand)).ToString();
                    break;
                case "And":
                    Result.Text = ((int)dblResult & (int)(dblOperand)).ToString();
                    break;
                case "Or":
                    Result.Text = ((int)dblResult | (int)(dblOperand)).ToString();
                    break;
                case "Xor":
                    Result.Text = ((int)dblResult ^ (int)(dblOperand)).ToString();
                    break;
                case "Lsh":
                    Result.Text = (((int)dblResult << (int)dblOperand)).ToString();
                    break;
                default: break;
            }
            if (inCurrentBase != 10) Result.Text = ConvertNumberSystem(10, Result.Text, inCurrentBase);
        }
        private void Equals(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (inEquals == 0)
                {
                    dblOperand = Convert.ToDouble((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture);
                    inEquals++;
                }
                Operate(dblResult, strPreviousOperator, dblOperand);
                blNewEntry = true;
            }
        }
        private void OneByNumber(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                Operate(1, "/", double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10)));
            blNewEntry = true;
        }
        private void ClearExceptMemory(object sender, EventArgs e)
        {
            inParanthesisCount = inInfinityException = 0;
            dblOperand = dblResult = inEquals = 0; Result.Text = "0";
            blNewEntry = false;
            strPreviousOperator = string.Empty;
        }
        private void ClearOperator(object sender, EventArgs e)
        {
            inInfinityException = 0;
            Result.Text = "0";
        }
        private void MemmoryOperations(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                blNewEntry = true;
                if ((Button)sender == MemorySaveButton && double.Parse(Result.Text) != 0)
                {
                    dblMemory = double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10));
                }
                else if ((Button)sender == MemoryPlusButton && double.Parse(Result.Text) != 0)
                {

                    dblMemory = dblMemory + ((inCurrentBase == 10) ? double.Parse(Result.Text, CultureInfo.InvariantCulture) : double.Parse(ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture));
                }
                else if ((Button)sender == MemoryRemoveButton)
                    Result.Text = (inCurrentBase == 10) ? dblMemory.ToString() : ConvertNumberSystem(10, dblMemory.ToString(), inCurrentBase);
                else if ((Button)sender == MemoryClearButton1)
                {
                    dblMemory = 0;
                    inCurrentBaseOfMemory = 10;
                }
                inCurrentBaseOfMemory = inCurrentBase;
            }
        }
        private void SetPiValue(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                Result.Text = (Math.PI).ToString();
            blNewEntry = true;
        }
        private void BitwiseInverse(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                Result.Text = ConvertNumberSystem(10, (~(int)((inCurrentBase == 10) ? double.Parse(Result.Text, CultureInfo.InvariantCulture) : Convert.ToDouble(ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture))).ToString(), inCurrentBase);
            blNewEntry = true;
        }
        private void Factorial(object sender, EventArgs e)
        {

            if (inInfinityException != 1 && Result.Text.Contains(".") == false)
            {
                if (Result.Text == "Input Infinity")
                {
                    return;
                }
                if (int.Parse(Result.Text) > 12)
                {
                    Result.Text = "Input Infinity";
                    return;
                }
                if (double.Parse(Result.Text) >= 0)
                    Result.Text = ConvertNumberSystem(10, (Fact(double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture))).ToString(), inCurrentBase);
                else
                {
                    Result.Text = "Invalid Input For Function";
                    inInfinityException = 1;
                }
                blNewEntry = true;
            }
        }
        double Fact(double dblOperand)
        {

            if (dblOperand == 0 || dblOperand == 1)
                return 1;
            else
                return dblOperand * Fact(dblOperand - 1);
        }

        private void FindCube(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                Result.Text = (dblResult = Math.Pow(double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture), 3)).ToString();
                if (inCurrentBase != 10)
                    Result.Text = ConvertNumberSystem(10, Result.Text, inCurrentBase);
                blNewEntry = true;
            }
        }
        private void FindSqure(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                Result.Text = (dblResult = Math.Pow(double.Parse((inCurrentBase == 10) ? Result.Text : ConvertNumberSystem(inCurrentBase, Result.Text, 10), CultureInfo.InvariantCulture), 2)).ToString();
                if (inCurrentBase != 10)
                    Result.Text = ConvertNumberSystem(10, Result.Text, inCurrentBase);

            }
            blNewEntry = true;
        }
        private void AllowScientificNotation(object sender, EventArgs e)
        {
            if (inInfinityException != 1 && (double.Parse(Result.Text, CultureInfo.InvariantCulture) != 0 & Result.Text.Contains('E') == false))
                Result.Text += "E+0";
        }
        private void SwitchOnAndOffScientificNotation(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (Result.Text.Contains("E") == false)
                    Result.Text = double.Parse(Result.Text).ToString("E");
                else
                    Result.Text = (double.Parse(Result.Text, System.Globalization.NumberStyles.Float)).ToString();
            }
        }
        private void ForTrigonometricFunctions(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (Result.Text == "∞") { Result.Text = "Result is ∞"; inInfinityException = 1; return; }
                dblResult = double.Parse(Result.Text, CultureInfo.InvariantCulture);
                if (((Button)sender) == btnSin)
                {
                    Result.Text = (dblResult = Math.Sinh(dblResult)).ToString();
                }
                else if (((Button)sender) == btnCos)
                {
                    Result.Text = (dblResult = Math.Cosh(dblResult)).ToString();
                }
                else if (((Button)sender) == btnTg)
                {
                    Result.Text = (dblResult = Math.Tanh(dblResult)).ToString();
                }
                else if (((Button)sender) == btnCtg)
                {
                    Result.Text = (dblResult = 1.0 / Math.Tanh(dblResult)).ToString();
                }
                if (Result.Text == "NaN")
                    Result.Text = "Invalid Input For Function";
                blNewEntry = true;
            }
        }
        private void AllowedKeyboardEntries(object sender, KeyPressEventArgs e)
        {
            if (inInfinityException != 1)
            {
                switch ((int)e.KeyChar)
                {
                    case 8: btnBackspace.PerformClick(); break;
                    case 13: btnEquals.PerformClick(); break;
                    case 42: btnMultiply.PerformClick(); break;
                    case 43: btnAdd.PerformClick(); break;
                    case 45: btnSubstract.PerformClick(); break;
                    case 46: btnDecimalPoint.PerformClick(); break;
                    case 47: btnDivide.PerformClick(); break;
                    case 48: btn0.PerformClick(); break;
                    case 49: btn1.PerformClick(); break;
                    case 50: btn2.PerformClick(); break;
                    case 51: btn3.PerformClick(); break;
                    case 52: btn4.PerformClick(); break;
                    case 53: btn5.PerformClick(); break;
                    case 54: btn6.PerformClick(); break;
                    case 55: btn7.PerformClick(); break;
                    case 56: btn8.PerformClick(); break;
                    case 57: btn9.PerformClick(); break;
                    case 61: btnEquals.PerformClick(); break;
                }
            }
        }
        private void DegreeMinuteSecondFormatConversion(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                double d = double.Parse(Result.Text, CultureInfo.InvariantCulture);
                double degree = (int)d;
                double minute = (int)((d - degree) * 60);
                double seconde = (int)((d - degree - (minute / 60)) * 3600);
                Result.Text = degree + "." + minute + "" + seconde;
            }
        }
        private void Log(object sender, EventArgs e)
        {

        }
    }
}
