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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMIFormLabel
            // 
            this.BMIFormLabel.AutoSize = true;
            this.BMIFormLabel.Location = new System.Drawing.Point(28, 9);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Maroon;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.White;
            this.ImperialRadioButton.Location = new System.Drawing.Point(22, 11);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(125, 25);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial Units";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.UseCompatibleTextRendering = true;
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            // 
            // MatricRadioButton
            // 
            this.MatricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatricRadioButton.AutoSize = true;
            this.MatricRadioButton.BackColor = System.Drawing.Color.Maroon;
            this.MatricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatricRadioButton.ForeColor = System.Drawing.Color.White;
            this.MatricRadioButton.Location = new System.Drawing.Point(170, 11);
            this.MatricRadioButton.Name = "MatricRadioButton";
            this.MatricRadioButton.Size = new System.Drawing.Size(111, 24);
            this.MatricRadioButton.TabIndex = 1;
            this.MatricRadioButton.TabStop = true;
            this.MatricRadioButton.Text = "Matric Units";
            this.MatricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatricRadioButton.UseVisualStyleBackColor = false;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BMIFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMIFormLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MatricRadioButton;
    }
}

