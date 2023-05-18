namespace WinFormsApp4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnT = new OpenTK.GLControl();
            this.ValuteConvertBtn = new System.Windows.Forms.Button();
            this.DatesBtn = new System.Windows.Forms.Button();
            this.ScienceCalcBtn = new System.Windows.Forms.Button();
            this.ProgrammerCalcBtn = new System.Windows.Forms.Button();
            this.StandartCalcBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PointInGrap = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(15)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.AnT);
            this.panel2.Controls.Add(this.ValuteConvertBtn);
            this.panel2.Controls.Add(this.DatesBtn);
            this.panel2.Controls.Add(this.ScienceCalcBtn);
            this.panel2.Controls.Add(this.ProgrammerCalcBtn);
            this.panel2.Controls.Add(this.StandartCalcBtn);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 422);
            this.panel2.TabIndex = 1;
            // 
            // AnT
            // 
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.Location = new System.Drawing.Point(13, 0);
            this.AnT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(166, 142);
            this.AnT.TabIndex = 6;
            this.AnT.VSync = false;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // ValuteConvertBtn
            // 
            this.ValuteConvertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ValuteConvertBtn.FlatAppearance.BorderSize = 0;
            this.ValuteConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValuteConvertBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValuteConvertBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ValuteConvertBtn.Image = global::WinFormsApp4.Properties.Resources.output_onlinepngtools__7___1_;
            this.ValuteConvertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValuteConvertBtn.Location = new System.Drawing.Point(3, 301);
            this.ValuteConvertBtn.Name = "ValuteConvertBtn";
            this.ValuteConvertBtn.Size = new System.Drawing.Size(200, 37);
            this.ValuteConvertBtn.TabIndex = 5;
            this.ValuteConvertBtn.Text = "CURRENCY";
            this.ValuteConvertBtn.UseVisualStyleBackColor = false;
            this.ValuteConvertBtn.Click += new System.EventHandler(this.ValuteConvertBtn_Click);
            // 
            // DatesBtn
            // 
            this.DatesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DatesBtn.FlatAppearance.BorderSize = 0;
            this.DatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatesBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DatesBtn.Image = global::WinFormsApp4.Properties.Resources.calendar__2_;
            this.DatesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatesBtn.Location = new System.Drawing.Point(3, 265);
            this.DatesBtn.Name = "DatesBtn";
            this.DatesBtn.Size = new System.Drawing.Size(200, 30);
            this.DatesBtn.TabIndex = 4;
            this.DatesBtn.Text = "DATES";
            this.DatesBtn.UseVisualStyleBackColor = false;
            this.DatesBtn.Click += new System.EventHandler(this.DatesBtn_Click);
            // 
            // ScienceCalcBtn
            // 
            this.ScienceCalcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScienceCalcBtn.FlatAppearance.BorderSize = 0;
            this.ScienceCalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScienceCalcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScienceCalcBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScienceCalcBtn.Image = global::WinFormsApp4.Properties.Resources.Bottle;
            this.ScienceCalcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScienceCalcBtn.Location = new System.Drawing.Point(3, 229);
            this.ScienceCalcBtn.Name = "ScienceCalcBtn";
            this.ScienceCalcBtn.Size = new System.Drawing.Size(200, 30);
            this.ScienceCalcBtn.TabIndex = 2;
            this.ScienceCalcBtn.Text = "SCIENTIFIC";
            this.ScienceCalcBtn.UseVisualStyleBackColor = false;
            this.ScienceCalcBtn.Click += new System.EventHandler(this.btnScienceCalc_Click);
            // 
            // ProgrammerCalcBtn
            // 
            this.ProgrammerCalcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProgrammerCalcBtn.FlatAppearance.BorderSize = 0;
            this.ProgrammerCalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgrammerCalcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgrammerCalcBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgrammerCalcBtn.Image = global::WinFormsApp4.Properties.Resources.Binary;
            this.ProgrammerCalcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgrammerCalcBtn.Location = new System.Drawing.Point(3, 193);
            this.ProgrammerCalcBtn.Name = "ProgrammerCalcBtn";
            this.ProgrammerCalcBtn.Size = new System.Drawing.Size(200, 30);
            this.ProgrammerCalcBtn.TabIndex = 1;
            this.ProgrammerCalcBtn.Text = "  PROGRAMMER";
            this.ProgrammerCalcBtn.UseVisualStyleBackColor = false;
            this.ProgrammerCalcBtn.Click += new System.EventHandler(this.btnProgrammerCalc_Click);
            // 
            // StandartCalcBtn
            // 
            this.StandartCalcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StandartCalcBtn.FlatAppearance.BorderSize = 0;
            this.StandartCalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StandartCalcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StandartCalcBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StandartCalcBtn.Image = global::WinFormsApp4.Properties.Resources.calculator;
            this.StandartCalcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StandartCalcBtn.Location = new System.Drawing.Point(3, 157);
            this.StandartCalcBtn.Name = "StandartCalcBtn";
            this.StandartCalcBtn.Size = new System.Drawing.Size(200, 30);
            this.StandartCalcBtn.TabIndex = 0;
            this.StandartCalcBtn.Text = "STANDART";
            this.StandartCalcBtn.UseVisualStyleBackColor = false;
            this.StandartCalcBtn.Click += new System.EventHandler(this.btnStandartCalc_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(186, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(614, 420);
            this.MainPanel.TabIndex = 2;
            // 
            // PointInGrap
            // 
            this.PointInGrap.Interval = 30;
            this.PointInGrap.Tick += new System.EventHandler(this.PointInGrap_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button DatesBtn;
        private Button ScienceCalcBtn;
        private Button ProgrammerCalcBtn;
        private Button StandartCalcBtn;
        private Button ValuteConvertBtn;
        private Panel MainPanel;
        private OpenTK.GLControl AnT;
        private System.Windows.Forms.Timer PointInGrap;
    }
}