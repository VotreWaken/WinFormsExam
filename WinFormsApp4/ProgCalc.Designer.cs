namespace WinFormsApp4
{
    partial class ProgCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        System.Windows.Forms.RadioButton[] ctrControlsForDecimalsSystem;
        System.Windows.Forms.RadioButton[] ctrControlsForNonDecimalsSystem;
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
            this.GbNumberSystem = new System.Windows.Forms.GroupBox();
            this.RbBinButton = new System.Windows.Forms.RadioButton();
            this.RbOctButton = new System.Windows.Forms.RadioButton();
            this.RbDecButton = new System.Windows.Forms.RadioButton();
            this.RbHexButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlphabetF = new System.Windows.Forms.Button();
            this.btnAlphabetE = new System.Windows.Forms.Button();
            this.btnAlphabetD = new System.Windows.Forms.Button();
            this.btnAlphabetC = new System.Windows.Forms.Button();
            this.btnAlphabetB = new System.Windows.Forms.Button();
            this.btnAlphabetA = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnLsh = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryMinusButton = new System.Windows.Forms.Button();
            this.MemoryClearButton = new System.Windows.Forms.Button();
            this.MemoryRemoveButton = new System.Windows.Forms.Button();
            this.MemorySaveButton = new System.Windows.Forms.Button();
            this.MemoryPlusButton = new System.Windows.Forms.Button();
            this.gbConversions = new System.Windows.Forms.GroupBox();
            this.RbGrads = new System.Windows.Forms.RadioButton();
            this.RbRadians = new System.Windows.Forms.RadioButton();
            this.RbDegree = new System.Windows.Forms.RadioButton();
            this.rbtDword = new System.Windows.Forms.RadioButton();
            this.rbtByte = new System.Windows.Forms.RadioButton();
            this.rbtQword = new System.Windows.Forms.RadioButton();
            this.rbtWord = new System.Windows.Forms.RadioButton();
            this.GbNumberSystem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbConversions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(12, 24);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(448, 35);
            this.Result.TabIndex = 0;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GbNumberSystem
            // 
            this.GbNumberSystem.Controls.Add(this.RbBinButton);
            this.GbNumberSystem.Controls.Add(this.RbOctButton);
            this.GbNumberSystem.Controls.Add(this.RbDecButton);
            this.GbNumberSystem.Controls.Add(this.RbHexButton);
            this.GbNumberSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbNumberSystem.Location = new System.Drawing.Point(12, 65);
            this.GbNumberSystem.Name = "GbNumberSystem";
            this.GbNumberSystem.Size = new System.Drawing.Size(59, 115);
            this.GbNumberSystem.TabIndex = 3;
            this.GbNumberSystem.TabStop = false;
            // 
            // RbBinButton
            // 
            this.RbBinButton.AutoSize = true;
            this.RbBinButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbBinButton.Location = new System.Drawing.Point(6, 86);
            this.RbBinButton.Name = "RbBinButton";
            this.RbBinButton.Size = new System.Drawing.Size(42, 19);
            this.RbBinButton.TabIndex = 3;
            this.RbBinButton.TabStop = true;
            this.RbBinButton.Text = "Bin";
            this.RbBinButton.UseVisualStyleBackColor = true;
            this.RbBinButton.Click += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // RbOctButton
            // 
            this.RbOctButton.AutoSize = true;
            this.RbOctButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbOctButton.Location = new System.Drawing.Point(6, 61);
            this.RbOctButton.Name = "RbOctButton";
            this.RbOctButton.Size = new System.Drawing.Size(44, 19);
            this.RbOctButton.TabIndex = 2;
            this.RbOctButton.TabStop = true;
            this.RbOctButton.Text = "Oct";
            this.RbOctButton.UseVisualStyleBackColor = true;
            this.RbOctButton.Click += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // RbDecButton
            // 
            this.RbDecButton.AutoSize = true;
            this.RbDecButton.Checked = true;
            this.RbDecButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbDecButton.Location = new System.Drawing.Point(6, 36);
            this.RbDecButton.Name = "RbDecButton";
            this.RbDecButton.Size = new System.Drawing.Size(45, 19);
            this.RbDecButton.TabIndex = 1;
            this.RbDecButton.TabStop = true;
            this.RbDecButton.Text = "Dec";
            this.RbDecButton.UseVisualStyleBackColor = true;
            this.RbDecButton.Click += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // RbHexButton
            // 
            this.RbHexButton.AutoSize = true;
            this.RbHexButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbHexButton.Location = new System.Drawing.Point(6, 11);
            this.RbHexButton.Name = "RbHexButton";
            this.RbHexButton.Size = new System.Drawing.Size(46, 19);
            this.RbHexButton.TabIndex = 0;
            this.RbHexButton.TabStop = true;
            this.RbHexButton.Text = "Hex";
            this.RbHexButton.UseVisualStyleBackColor = true;
            this.RbHexButton.Click += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
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
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetF, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetE, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetD, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetC, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAlphabetA, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCtg, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTg, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimalPoint, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSin, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCos, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSubstract, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNot, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLsh, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXor, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOr, 4, 1);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 293);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAlphabetF
            // 
            this.btnAlphabetF.Location = new System.Drawing.Point(308, 243);
            this.btnAlphabetF.Name = "btnAlphabetF";
            this.btnAlphabetF.Size = new System.Drawing.Size(57, 47);
            this.btnAlphabetF.TabIndex = 34;
            this.btnAlphabetF.Text = "F";
            this.btnAlphabetF.UseVisualStyleBackColor = true;
            this.btnAlphabetF.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetE
            // 
            this.btnAlphabetE.Location = new System.Drawing.Point(247, 243);
            this.btnAlphabetE.Name = "btnAlphabetE";
            this.btnAlphabetE.Size = new System.Drawing.Size(55, 47);
            this.btnAlphabetE.TabIndex = 33;
            this.btnAlphabetE.Text = "E";
            this.btnAlphabetE.UseVisualStyleBackColor = true;
            this.btnAlphabetE.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetD
            // 
            this.btnAlphabetD.Location = new System.Drawing.Point(186, 243);
            this.btnAlphabetD.Name = "btnAlphabetD";
            this.btnAlphabetD.Size = new System.Drawing.Size(55, 47);
            this.btnAlphabetD.TabIndex = 32;
            this.btnAlphabetD.Text = "D";
            this.btnAlphabetD.UseVisualStyleBackColor = true;
            this.btnAlphabetD.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetC
            // 
            this.btnAlphabetC.Location = new System.Drawing.Point(125, 243);
            this.btnAlphabetC.Name = "btnAlphabetC";
            this.btnAlphabetC.Size = new System.Drawing.Size(55, 47);
            this.btnAlphabetC.TabIndex = 31;
            this.btnAlphabetC.Text = "C";
            this.btnAlphabetC.UseVisualStyleBackColor = true;
            this.btnAlphabetC.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetB
            // 
            this.btnAlphabetB.Location = new System.Drawing.Point(64, 243);
            this.btnAlphabetB.Name = "btnAlphabetB";
            this.btnAlphabetB.Size = new System.Drawing.Size(55, 47);
            this.btnAlphabetB.TabIndex = 30;
            this.btnAlphabetB.Text = "B";
            this.btnAlphabetB.UseVisualStyleBackColor = true;
            this.btnAlphabetB.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetA
            // 
            this.btnAlphabetA.Location = new System.Drawing.Point(3, 243);
            this.btnAlphabetA.Name = "btnAlphabetA";
            this.btnAlphabetA.Size = new System.Drawing.Size(55, 47);
            this.btnAlphabetA.TabIndex = 29;
            this.btnAlphabetA.Text = "A";
            this.btnAlphabetA.UseVisualStyleBackColor = true;
            this.btnAlphabetA.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(308, 195);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(57, 42);
            this.btnCtg.TabIndex = 28;
            this.btnCtg.Text = "CTG";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(247, 195);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(55, 42);
            this.btnTg.TabIndex = 27;
            this.btnTg.Text = "TG";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(186, 195);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(55, 42);
            this.btnEquals.TabIndex = 26;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Equals);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(125, 195);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 42);
            this.btnMultiply.TabIndex = 25;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Location = new System.Drawing.Point(64, 195);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(55, 42);
            this.btnDecimalPoint.TabIndex = 24;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 195);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 42);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(308, 147);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(57, 42);
            this.btnSin.TabIndex = 22;
            this.btnSin.Text = "SIN";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(247, 147);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(55, 42);
            this.btnCos.TabIndex = 21;
            this.btnCos.Text = "COS";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(186, 147);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(55, 42);
            this.btnSubstract.TabIndex = 20;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(125, 147);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 42);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(64, 147);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 42);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 147);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 42);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(308, 99);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(57, 42);
            this.btnNot.TabIndex = 16;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.BitwiseInverse);
            // 
            // btnLsh
            // 
            this.btnLsh.Location = new System.Drawing.Point(247, 99);
            this.btnLsh.Name = "btnLsh";
            this.btnLsh.Size = new System.Drawing.Size(55, 42);
            this.btnLsh.TabIndex = 15;
            this.btnLsh.Text = "LSH";
            this.btnLsh.UseVisualStyleBackColor = true;
            this.btnLsh.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(186, 99);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 42);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(125, 99);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 42);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(64, 99);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 42);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 99);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 42);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(308, 51);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(57, 42);
            this.btnXor.TabIndex = 10;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(247, 51);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(55, 42);
            this.btnOr.TabIndex = 9;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(125, 51);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 42);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(64, 51);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 42);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 51);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 42);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(308, 3);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(57, 42);
            this.btnAnd.TabIndex = 5;
            this.btnAnd.Text = "And";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(247, 3);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(55, 42);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(186, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(55, 42);
            this.btnBackspace.TabIndex = 4;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.RemoveLastDigit);
            // 
            // PercentButton
            // 
            this.PercentButton.Location = new System.Drawing.Point(125, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(55, 42);
            this.PercentButton.TabIndex = 4;
            this.PercentButton.Text = "N!";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new System.EventHandler(this.Factorial);
            // 
            // btnClearCurrentOperand
            // 
            this.btnClearCurrentOperand.Location = new System.Drawing.Point(64, 3);
            this.btnClearCurrentOperand.Name = "btnClearCurrentOperand";
            this.btnClearCurrentOperand.Size = new System.Drawing.Size(55, 42);
            this.btnClearCurrentOperand.TabIndex = 4;
            this.btnClearCurrentOperand.Text = "CE";
            this.btnClearCurrentOperand.UseVisualStyleBackColor = true;
            this.btnClearCurrentOperand.Click += new System.EventHandler(this.ClearOperator);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(3, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(55, 42);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearExceptMemory);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.MemoryMinusButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.MemoryClearButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemoryRemoveButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MemorySaveButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MemoryPlusButton, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(59, 208);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // MemoryMinusButton
            // 
            this.MemoryMinusButton.Location = new System.Drawing.Point(3, 167);
            this.MemoryMinusButton.Name = "MemoryMinusButton";
            this.MemoryMinusButton.Size = new System.Drawing.Size(53, 38);
            this.MemoryMinusButton.TabIndex = 8;
            this.MemoryMinusButton.Text = "M-";
            this.MemoryMinusButton.UseVisualStyleBackColor = true;
            this.MemoryMinusButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryClearButton
            // 
            this.MemoryClearButton.Location = new System.Drawing.Point(3, 3);
            this.MemoryClearButton.Name = "MemoryClearButton";
            this.MemoryClearButton.Size = new System.Drawing.Size(53, 35);
            this.MemoryClearButton.TabIndex = 4;
            this.MemoryClearButton.Text = "MC";
            this.MemoryClearButton.UseVisualStyleBackColor = true;
            this.MemoryClearButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryRemoveButton
            // 
            this.MemoryRemoveButton.Location = new System.Drawing.Point(3, 44);
            this.MemoryRemoveButton.Name = "MemoryRemoveButton";
            this.MemoryRemoveButton.Size = new System.Drawing.Size(53, 35);
            this.MemoryRemoveButton.TabIndex = 5;
            this.MemoryRemoveButton.Text = "MR";
            this.MemoryRemoveButton.UseVisualStyleBackColor = true;
            this.MemoryRemoveButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemorySaveButton
            // 
            this.MemorySaveButton.Location = new System.Drawing.Point(3, 85);
            this.MemorySaveButton.Name = "MemorySaveButton";
            this.MemorySaveButton.Size = new System.Drawing.Size(53, 35);
            this.MemorySaveButton.TabIndex = 6;
            this.MemorySaveButton.Text = "MS";
            this.MemorySaveButton.UseVisualStyleBackColor = true;
            this.MemorySaveButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // MemoryPlusButton
            // 
            this.MemoryPlusButton.Location = new System.Drawing.Point(3, 126);
            this.MemoryPlusButton.Name = "MemoryPlusButton";
            this.MemoryPlusButton.Size = new System.Drawing.Size(53, 35);
            this.MemoryPlusButton.TabIndex = 7;
            this.MemoryPlusButton.Text = "M+";
            this.MemoryPlusButton.UseVisualStyleBackColor = true;
            this.MemoryPlusButton.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // gbConversions
            // 
            this.gbConversions.Controls.Add(this.RbGrads);
            this.gbConversions.Controls.Add(this.RbRadians);
            this.gbConversions.Controls.Add(this.RbDegree);
            this.gbConversions.Location = new System.Drawing.Point(92, 61);
            this.gbConversions.Name = "gbConversions";
            this.gbConversions.Size = new System.Drawing.Size(368, 37);
            this.gbConversions.TabIndex = 0;
            this.gbConversions.TabStop = false;
            // 
            // RbGrads
            // 
            this.RbGrads.AutoSize = true;
            this.RbGrads.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbGrads.Location = new System.Drawing.Point(163, 11);
            this.RbGrads.Name = "RbGrads";
            this.RbGrads.Size = new System.Drawing.Size(55, 19);
            this.RbGrads.TabIndex = 2;
            this.RbGrads.TabStop = true;
            this.RbGrads.Text = "Grads";
            this.RbGrads.UseVisualStyleBackColor = true;
            this.RbGrads.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // RbRadians
            // 
            this.RbRadians.AutoSize = true;
            this.RbRadians.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbRadians.Location = new System.Drawing.Point(91, 11);
            this.RbRadians.Name = "RbRadians";
            this.RbRadians.Size = new System.Drawing.Size(66, 19);
            this.RbRadians.TabIndex = 1;
            this.RbRadians.TabStop = true;
            this.RbRadians.Text = "Radians";
            this.RbRadians.UseVisualStyleBackColor = true;
            this.RbRadians.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // RbDegree
            // 
            this.RbDegree.AutoSize = true;
            this.RbDegree.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RbDegree.Location = new System.Drawing.Point(6, 11);
            this.RbDegree.Name = "RbDegree";
            this.RbDegree.Size = new System.Drawing.Size(67, 19);
            this.RbDegree.TabIndex = 0;
            this.RbDegree.TabStop = true;
            this.RbDegree.Text = "Degrees";
            this.RbDegree.UseVisualStyleBackColor = true;
            this.RbDegree.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // rbtDword
            // 
            this.rbtDword.AutoSize = true;
            this.rbtDword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtDword.Location = new System.Drawing.Point(74, 9);
            this.rbtDword.Name = "rbtDword";
            this.rbtDword.Size = new System.Drawing.Size(46, 19);
            this.rbtDword.TabIndex = 2;
            this.rbtDword.Text = "Dword";
            this.rbtDword.UseVisualStyleBackColor = true;
            // 
            // rbtByte
            // 
            this.rbtByte.AutoSize = true;
            this.rbtByte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtByte.Location = new System.Drawing.Point(218, 9);
            this.rbtByte.Name = "rbtByte";
            this.rbtByte.Size = new System.Drawing.Size(46, 17);
            this.rbtByte.TabIndex = 2;
            this.rbtByte.Text = "Byte";
            this.rbtByte.UseVisualStyleBackColor = true;
            this.rbtByte.CheckedChanged += new System.EventHandler(this.ChangeConversionStatusForNonDecimal);
            // 
            // rbtQword
            // 
            this.rbtQword.AutoSize = true;
            this.rbtQword.Checked = true;
            this.rbtQword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtQword.Location = new System.Drawing.Point(6, 9);
            this.rbtQword.Name = "rbtQword";
            this.rbtQword.Size = new System.Drawing.Size(56, 17);
            this.rbtQword.TabIndex = 2;
            this.rbtQword.TabStop = true;
            this.rbtQword.Text = "Qword";
            this.rbtQword.UseVisualStyleBackColor = true;
            // 
            // rbtWord
            // 
            this.rbtWord.AutoSize = true;
            this.rbtWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtWord.Location = new System.Drawing.Point(146, 9);
            this.rbtWord.Name = "rbtWord";
            this.rbtWord.Size = new System.Drawing.Size(51, 17);
            this.rbtWord.TabIndex = 2;
            this.rbtWord.Text = "Word";
            this.rbtWord.UseVisualStyleBackColor = true;
            // 
            // ProgCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(505, 409);
            this.Controls.Add(this.gbConversions);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GbNumberSystem);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgCalc";
            this.Text = "ProgCalc";
            this.GbNumberSystem.ResumeLayout(false);
            this.GbNumberSystem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbConversions.ResumeLayout(false);
            this.gbConversions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AdditionalInitialisation()
        {
            ctrControlsForDecimalsSystem = new System.Windows.Forms.RadioButton[] { RbDegree, RbRadians, RbGrads };
            ctrControlsForNonDecimalsSystem = new System.Windows.Forms.RadioButton[] { rbtDword, rbtQword, rbtWord, rbtByte };
        }

        #endregion

        private TextBox Result;
        private GroupBox GbNumberSystem;
        private RadioButton RbBinButton;
        private RadioButton RbOctButton;
        private RadioButton RbDecButton;
        private RadioButton RbHexButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAlphabetF;
        private Button btnAlphabetE;
        private Button btnAlphabetD;
        private Button btnAlphabetC;
        private Button btnAlphabetB;
        private Button btnAlphabetA;
        private Button btnCtg;
        private Button btnTg;
        private Button btnEquals;
        private Button btnMultiply;
        private Button btnDecimalPoint;
        private Button btn0;
        private Button btnSin;
        private Button btnCos;
        private Button btnSubstract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnNot;
        private Button btnLsh;
        private Button btnDivide;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnXor;
        private Button btnOr;
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
        private TableLayoutPanel tableLayoutPanel2;
        private Button MemoryMinusButton;
        private Button MemoryClearButton;
        private Button MemoryRemoveButton;
        private Button MemorySaveButton;
        private Button MemoryPlusButton;
        private GroupBox gbConversions;
        private RadioButton RbGrads;
        private RadioButton RbRadians;
        private RadioButton RbDegree;
        private RadioButton rbtQword;
        private RadioButton rbtDword;
        private RadioButton rbtWord;
        private RadioButton rbtByte;
    }
}