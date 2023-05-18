namespace WinFormsApp4
{
    partial class DefaultCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.btnClearCurrentOperand = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimalPoint, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubstract, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeSign, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PercentButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearCurrentOperand, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 305);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(279, 247);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(86, 55);
            this.btnEquals.TabIndex = 26;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Equals);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(187, 247);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(86, 55);
            this.btnMultiply.TabIndex = 25;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Location = new System.Drawing.Point(95, 247);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(86, 55);
            this.btnDecimalPoint.TabIndex = 24;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 55);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(279, 186);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(86, 55);
            this.btnSubstract.TabIndex = 20;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(187, 186);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 55);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(95, 186);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(86, 55);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 186);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 55);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(279, 125);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(86, 55);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(187, 125);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 55);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(95, 125);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(86, 55);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(86, 55);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 55);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(187, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 55);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(95, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(86, 55);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(86, 55);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Location = new System.Drawing.Point(279, 3);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(86, 55);
            this.btnChangeSign.TabIndex = 4;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.ChangeSign);
            // 
            // PercentButton
            // 
            this.PercentButton.Location = new System.Drawing.Point(187, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(86, 55);
            this.PercentButton.TabIndex = 4;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            // 
            // btnClearCurrentOperand
            // 
            this.btnClearCurrentOperand.Location = new System.Drawing.Point(95, 3);
            this.btnClearCurrentOperand.Name = "btnClearCurrentOperand";
            this.btnClearCurrentOperand.Size = new System.Drawing.Size(86, 55);
            this.btnClearCurrentOperand.TabIndex = 4;
            this.btnClearCurrentOperand.Text = "CE";
            this.btnClearCurrentOperand.UseVisualStyleBackColor = true;
            this.btnClearCurrentOperand.Click += new System.EventHandler(this.ClearOperator);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(3, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(86, 55);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(44, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(362, 35);
            this.Result.TabIndex = 36;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(41, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 42);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(222, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "M+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "M-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DefaultCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefaultCalc";
            this.Text = "DefaultCalc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEquals;
        private Button btnMultiply;
        private Button btnDecimalPoint;
        private Button btn0;
        private Button btnSubstract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDivide;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnChangeSign;
        private Button PercentButton;
        private Button btnClearCurrentOperand;
        private Button btnClearAll;
        private TextBox Result;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}