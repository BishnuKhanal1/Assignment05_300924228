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
            this.BMIFormLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MatricRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.HeightInInchLabel = new System.Windows.Forms.Label();
            this.WeightInPounds = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.MyHeightLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.HeightInInchLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.WeightInPounds, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.HeightNumericUpDown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.WeightNumericUpDown, 0, 3);
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
            // WeightInPounds
            // 
            this.WeightInPounds.AutoSize = true;
            this.WeightInPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInPounds.Location = new System.Drawing.Point(153, 95);
            this.WeightInPounds.Name = "WeightInPounds";
            this.WeightInPounds.Size = new System.Drawing.Size(139, 24);
            this.WeightInPounds.TabIndex = 3;
            this.WeightInPounds.Text = "Weight in Pounds";
            this.WeightInPounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightInPounds.UseCompatibleTextRendering = true;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightNumericUpDown.BackColor = System.Drawing.Color.LightCyan;
            this.HeightNumericUpDown.DecimalPlaces = 2;
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightNumericUpDown.Location = new System.Drawing.Point(57, 27);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(90, 35);
            this.HeightNumericUpDown.TabIndex = 29;
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightNumericUpDown.BackColor = System.Drawing.Color.LightCyan;
            this.WeightNumericUpDown.DecimalPlaces = 2;
            this.WeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightNumericUpDown.Location = new System.Drawing.Point(57, 98);
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(90, 35);
            this.WeightNumericUpDown.TabIndex = 31;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 288);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(297, 108);
            this.BMIResultTextBox.TabIndex = 11;
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
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.BMIResultTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BMIFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label WeightInPounds;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.Label ResultLabel;
    }
}

