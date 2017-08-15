namespace Assignment05_300924228
{
    partial class BMICalculatorForm
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
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.BMIFormLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MatricRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.HeightInInchLabel = new System.Windows.Forms.Label();
            this.WeightInPoundLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.BMIResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 288);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(297, 77);
            this.BMIResultTextBox.TabIndex = 11;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.HeightTextBox.Location = new System.Drawing.Point(77, 27);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(70, 38);
            this.HeightTextBox.TabIndex = 30;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // BMIFormLabel
            // 
            this.BMIFormLabel.AutoSize = true;
            this.BMIFormLabel.Location = new System.Drawing.Point(24, 0);
            this.BMIFormLabel.Name = "BMIFormLabel";
            this.BMIFormLabel.Size = new System.Drawing.Size(253, 31);
            this.BMIFormLabel.TabIndex = 0;
            this.BMIFormLabel.Text = "BMI CALCULATOR";
            this.BMIFormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatricRadioButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Maroon;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.White;
            this.ImperialRadioButton.Location = new System.Drawing.Point(16, 9);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(129, 25);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial Units";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.UseCompatibleTextRendering = true;
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MatricRadioButton
            // 
            this.MatricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MatricRadioButton.AutoSize = true;
            this.MatricRadioButton.BackColor = System.Drawing.Color.Maroon;
            this.MatricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatricRadioButton.ForeColor = System.Drawing.Color.White;
            this.MatricRadioButton.Location = new System.Drawing.Point(151, 10);
            this.MatricRadioButton.Name = "MatricRadioButton";
            this.MatricRadioButton.Size = new System.Drawing.Size(123, 24);
            this.MatricRadioButton.TabIndex = 1;
            this.MatricRadioButton.TabStop = true;
            this.MatricRadioButton.Text = "Matric Units";
            this.MatricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatricRadioButton.UseVisualStyleBackColor = false;
            this.MatricRadioButton.CheckedChanged += new System.EventHandler(this.MatricRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.HeightTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MyHeightLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.HeightInInchLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.WeightInPoundLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.WeightTextBox, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.24324F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.71428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.62774F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.92701F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 137);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(89, 20);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 70);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(92, 20);
            this.MyWeightLabel.TabIndex = 1;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightInInchLabel
            // 
            this.HeightInInchLabel.AutoSize = true;
            this.HeightInInchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInInchLabel.Location = new System.Drawing.Point(153, 24);
            this.HeightInInchLabel.Name = "HeightInInchLabel";
            this.HeightInInchLabel.Size = new System.Drawing.Size(128, 24);
            this.HeightInInchLabel.TabIndex = 2;
            this.HeightInInchLabel.Text = "Height in Inches";
            this.HeightInInchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeightInInchLabel.UseCompatibleTextRendering = true;
            // 
            // WeightInPoundLabel
            // 
            this.WeightInPoundLabel.AutoSize = true;
            this.WeightInPoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInPoundLabel.Location = new System.Drawing.Point(153, 95);
            this.WeightInPoundLabel.Name = "WeightInPoundLabel";
            this.WeightInPoundLabel.Size = new System.Drawing.Size(139, 24);
            this.WeightInPoundLabel.TabIndex = 3;
            this.WeightInPoundLabel.Text = "Weight in Pounds";
            this.WeightInPoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightInPoundLabel.UseCompatibleTextRendering = true;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.WeightTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.WeightTextBox.Location = new System.Drawing.Point(77, 98);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(70, 38);
            this.WeightTextBox.TabIndex = 31;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CalculateBMI, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 399);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 42);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(151, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(140, 35);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CalculateBMI.BackColor = System.Drawing.Color.Maroon;
            this.CalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.ForeColor = System.Drawing.Color.White;
            this.CalculateBMI.Location = new System.Drawing.Point(4, 3);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(140, 35);
            this.CalculateBMI.TabIndex = 1;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = false;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ResultLabel.Location = new System.Drawing.Point(-1, 262);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(55, 20);
            this.ResultLabel.TabIndex = 29;
            this.ResultLabel.Text = "Result";
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.BackColor = System.Drawing.Color.Green;
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 372);
            this.BMIProgressBar.Maximum = 60;
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(297, 23);
            this.BMIProgressBar.TabIndex = 30;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIProgressBar);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.BMIResultTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BMIFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMIFormLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MatricRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Label HeightInInchLabel;
        private System.Windows.Forms.Label WeightInPoundLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

