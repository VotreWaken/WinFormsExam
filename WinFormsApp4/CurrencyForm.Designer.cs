namespace WinFormsApp4
{
    partial class CurrencyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Location = new System.Drawing.Point(39, 122);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(149, 23);
            this.txtFromCurrency.TabIndex = 2;
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(194, 122);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(121, 23);
            this.cmbFromCurrency.TabIndex = 3;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Location = new System.Drawing.Point(39, 233);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(149, 23);
            this.txtToCurrency.TabIndex = 4;
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(194, 233);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(121, 23);
            this.cmbToCurrency.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConvert.Location = new System.Drawing.Point(116, 314);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(145, 70);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrencyForm";
            this.Text = "CurrencyForm";
            this.Load += new System.EventHandler(this.CurrencyForm_Load);
            this.Click += new System.EventHandler(this.CurrencyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFromCurrency;
        private ComboBox cmbFromCurrency;
        private TextBox txtToCurrency;
        private ComboBox cmbToCurrency;
        private Button btnConvert;
    }
}