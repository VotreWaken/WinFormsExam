namespace WinFormsApp4
{
    partial class ScienceCalc
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
            this.Result = new System.Windows.Forms.TextBox();
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
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.btnClearCurrentOperand = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLsh = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryMinusButton = new System.Windows.Forms.Button();
            this.MemoryClearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryPlusButton = new System.Windows.Forms.Button();
            this.MemoryMinusButton1 = new System.Windows.Forms.Button();
            this.MemorySaveButton = new System.Windows.Forms.Button();
            this.MemoryClearButton1 = new System.Windows.Forms.Button();
            this.MemoryRemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(38, 29);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(368, 35);
            this.Result.TabIndex = 39;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
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
            this.tableLayoutPanel1.Controls.Add(this.btnAnd, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMod, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PercentButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearCurrentOperand, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOr, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCos, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXor, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSin, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLsh, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTg, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNot, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCtg, 5, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 293);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(186, 235);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(55, 55);
            this.btnEquals.TabIndex = 26;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Equals);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(125, 235);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 55);
            this.btnMultiply.TabIndex = 25;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Location = new System.Drawing.Point(64, 235);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(55, 55);
            this.btnDecimalPoint.TabIndex = 24;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(186, 177);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(55, 52);
            this.btnSubstract.TabIndex = 20;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(125, 177);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 52);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(64, 177);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 52);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 177);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 52);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(186, 119);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 52);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(125, 119);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 52);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(64, 119);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 52);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 119);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 52);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(125, 61);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 52);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(64, 61);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 52);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 61);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 52);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(308, 3);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(57, 52);
            this.btnAnd.TabIndex = 5;
            this.btnAnd.Text = "Pi";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.SetPiValue);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(247, 3);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(55, 52);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "N!";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.Factorial);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(186, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(55, 52);
            this.btnBackspace.TabIndex = 4;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.RemoveLastDigit);
            // 
            // PercentButton
            // 
            this.PercentButton.Location = new System.Drawing.Point(125, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(55, 52);
            this.PercentButton.TabIndex = 4;
            this.PercentButton.Text = "+/-";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new System.EventHandler(this.ChangeSign);
            // 
            // btnClearCurrentOperand
            // 
            this.btnClearCurrentOperand.Location = new System.Drawing.Point(64, 3);
            this.btnClearCurrentOperand.Name = "btnClearCurrentOperand";
            this.btnClearCurrentOperand.Size = new System.Drawing.Size(55, 52);
            this.btnClearCurrentOperand.TabIndex = 4;
            this.btnClearCurrentOperand.Text = "CE";
            this.btnClearCurrentOperand.UseVisualStyleBackColor = true;
            this.btnClearCurrentOperand.Click += new System.EventHandler(this.ClearOperator);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(3, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(55, 52);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearExceptMemory);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(247, 177);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(55, 52);
            this.btnOr.TabIndex = 9;
            this.btnOr.Text = "x^y";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(247, 61);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(55, 52);
            this.btnCos.TabIndex = 21;
            this.btnCos.Text = "COS";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(308, 177);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(57, 52);
            this.btnXor.TabIndex = 10;
            this.btnXor.Text = "x^2";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.FindSqure);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(308, 61);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(57, 52);
            this.btnSin.TabIndex = 22;
            this.btnSin.Text = "SIN";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnLsh
            // 
            this.btnLsh.Location = new System.Drawing.Point(247, 235);
            this.btnLsh.Name = "btnLsh";
            this.btnLsh.Size = new System.Drawing.Size(55, 55);
            this.btnLsh.TabIndex = 15;
            this.btnLsh.Text = "x^3";
            this.btnLsh.UseVisualStyleBackColor = true;
            this.btnLsh.Click += new System.EventHandler(this.FindCube);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(247, 119);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(55, 52);
            this.btnTg.TabIndex = 27;
            this.btnTg.Text = "TG";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(308, 235);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(57, 55);
            this.btnNot.TabIndex = 16;
            this.btnNot.Text = "Log";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.Log);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(308, 119);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(57, 52);
            this.btnCtg.TabIndex = 28;
            this.btnCtg.Text = "CTG";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.MemoryMinusButton, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MemoryMinusButton
            // 
            this.MemoryMinusButton.Location = new System.Drawing.Point(3, 83);
            this.MemoryMinusButton.Name = "MemoryMinusButton";
            this.MemoryMinusButton.Size = new System.Drawing.Size(53, 14);
            this.MemoryMinusButton.TabIndex = 8;
            this.MemoryMinusButton.Text = "M-";
            this.MemoryMinusButton.UseVisualStyleBackColor = true;
            // 
            // MemoryClearButton
            // 
            this.MemoryClearButton.Location = new System.Drawing.Point(3, 3);
            this.MemoryClearButton.Name = "MemoryClearButton";
            this.MemoryClearButton.Size = new System.Drawing.Size(53, 35);
            this.MemoryClearButton.TabIndex = 4;
            this.MemoryClearButton.Text = "MC";
            this.MemoryClearButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.MemoryPlusButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MemoryMinusButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MemorySaveButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MemoryClearButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MemoryRemoveButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(38, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 51);
            this.tableLayoutPanel3.TabIndex = 41;
            // 
            // MemoryPlusButton
            // 
            this.MemoryPlusButton.Location = new System.Drawing.Point(222, 3);
            this.MemoryPlusButton.Name = "MemoryPlusButton";
            this.MemoryPlusButton.Size = new System.Drawing.Size(67, 45);
            this.MemoryPlusButton.TabIndex = 8;
            this.MemoryPlusButton.Text = "M+";
            this.MemoryPlusButton.UseVisualStyleBackColor = true;
            this.MemoryPlusButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryMinusButton1
            // 
            this.MemoryMinusButton1.Location = new System.Drawing.Point(295, 3);
            this.MemoryMinusButton1.Name = "MemoryMinusButton1";
            this.MemoryMinusButton1.Size = new System.Drawing.Size(70, 45);
            this.MemoryMinusButton1.TabIndex = 7;
            this.MemoryMinusButton1.Text = "M-";
            this.MemoryMinusButton1.UseVisualStyleBackColor = true;
            this.MemoryMinusButton1.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemorySaveButton
            // 
            this.MemorySaveButton.Location = new System.Drawing.Point(149, 3);
            this.MemorySaveButton.Name = "MemorySaveButton";
            this.MemorySaveButton.Size = new System.Drawing.Size(67, 45);
            this.MemorySaveButton.TabIndex = 6;
            this.MemorySaveButton.Text = "MS";
            this.MemorySaveButton.UseVisualStyleBackColor = true;
            this.MemorySaveButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryClearButton1
            // 
            this.MemoryClearButton1.Location = new System.Drawing.Point(3, 3);
            this.MemoryClearButton1.Name = "MemoryClearButton1";
            this.MemoryClearButton1.Size = new System.Drawing.Size(67, 45);
            this.MemoryClearButton1.TabIndex = 5;
            this.MemoryClearButton1.Text = "MC";
            this.MemoryClearButton1.UseVisualStyleBackColor = true;
            this.MemoryClearButton1.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryRemoveButton
            // 
            this.MemoryRemoveButton.Location = new System.Drawing.Point(76, 3);
            this.MemoryRemoveButton.Name = "MemoryRemoveButton";
            this.MemoryRemoveButton.Size = new System.Drawing.Size(67, 45);
            this.MemoryRemoveButton.TabIndex = 4;
            this.MemoryRemoveButton.Text = "MR";
            this.MemoryRemoveButton.UseVisualStyleBackColor = true;
            this.MemoryRemoveButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // ScienceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScienceCalc";
            this.Text = "ScienceCalc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Result;
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
        private Button btnAnd;
        private Button btnMod;
        private Button btnBackspace;
        private Button PercentButton;
        private Button btnClearCurrentOperand;
        private Button btnClearAll;
        private Button btnOr;
        private Button btnCos;
        private Button btnXor;
        private Button btnSin;
        private Button btnLsh;
        private Button btnTg;
        private Button btnNot;
        private Button btnCtg;
        private TableLayoutPanel tableLayoutPanel2;
        private Button MemoryMinusButton;
        private Button MemoryClearButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button MemoryPlusButton;
        private Button MemoryMinusButton1;
        private Button MemorySaveButton;
        private Button MemoryClearButton1;
        private Button MemoryRemoveButton;
    }
}