using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student No: 300924228
 * Date: August 10, 2017
 * Description: This is the BMI Calculator wondow form for the prospective Assignment 05 of COMP123-s2017
 * Version: 0.8- Added KeyPress event handler to control MyHeight & MyWeight text box with Numeric value only
 */
namespace Assignment05_300924228
{
    public partial class BMICalculatorForm : Form
    {
        //Private Instance variables/fields
        private double _heightInInches;
        private double _heightInMeter;
        private double _weightInPounds;
        private double _weightInKg;
        private double _bmiResult;

        //Public Properties

        public double HeightInInches
        {
            get
            {
                return this._heightInInches;
            }
            set
            {
                this._heightInInches = value;
            }
        }
        public double HeightInMeter
        {
            get
            {
                return this._heightInMeter;
            }
            set
            {
                this._heightInMeter = value;
            }
        }
        public double WeightInPounds
        {
            get
            {
                return this._weightInPounds;
            }
            set
            {
                this._weightInPounds = value;
            }
        }
        public double WeightInKg
        {
            get
            {
                return this._weightInKg;
            }
            set
            {
                this._weightInKg = value;
            }
        }
        public double BmiResult
        {
            get
            {
                return this._bmiResult;
            }    
        }
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the BMICalculatorForm_FormClosing event handler, closes SplashForm after 3 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This method checks if the user checks Imperial Units
        /// It also prompts users the text boxes to input Height and weight in specified units
        /// Removes the decimal precision and sets 0 in Inches and pound property if user checks Imperial Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                HeightInInchLabel.Text = "Height in Inches";
                WeightInPoundLabel.Text = "Weight in Pounds";
            }
        }
        /// <summary>
        /// This method checks if the user checks Matric Units
        /// It also prompts users the text boxes to input Height and weight in specified units
        /// Adds the decimal precision to 2 in meters and kg property if user checks Metric Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MatricRadioButton.Checked)
            {
                HeightInInchLabel.Text = "Height in Meters";
                WeightInPoundLabel.Text = "Weight in Kg";
            }
        }
        /// <summary>
        /// This event handler calculates and returns the BMI result
        /// Also checks if the user clicks imperial or matric units and returns the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMI_Click(object sender, EventArgs e)

        {
            this._heightInInches = Convert.ToDouble(HeightTextBox.Text);
            this._weightInPounds = Convert.ToDouble(WeightTextBox.Text);
            this._heightInMeter = Convert.ToDouble(HeightTextBox.Text);
            this._weightInKg = Convert.ToDouble(WeightTextBox.Text);

            if (ImperialRadioButton.Checked)
            {
                this._bmiResult = this._weightInPounds * 703 / (this._heightInInches * this._heightInInches);
                this._bmiResult = (double)Math.Round(this._bmiResult, 2);

                if (_bmiResult < 18.5)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + _bmiResult + "\r\nYou're underweight!";
                }
                if ((_bmiResult >= 18.5) && (_bmiResult <= 24.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + _bmiResult + "\r\nIt's Normal!";
                }
                if ((_bmiResult >= 25) && (_bmiResult <= 29.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + _bmiResult + "\r\nYou're Overweight!";
                }
                if (_bmiResult >= 30)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + _bmiResult + "\r\nObese!";
                }
            }
            if (MatricRadioButton.Checked)
            {
                
                this._bmiResult = this._weightInKg / (this._heightInMeter * this._heightInMeter);
                this._bmiResult = (double)Math.Round(this._bmiResult, 2);
                if (this._bmiResult < 18.5)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + this._bmiResult + "\r\nYou're underweight!";
                }
                if((this._bmiResult >= 18.5) && (this._bmiResult <= 24.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + this._bmiResult + "\r\nIt's Normal!";
                }
                if((this._bmiResult >= 25) && (this._bmiResult <= 29.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + this._bmiResult + "\r\nYou're Overweight!";
                }
                if(this._bmiResult >= 30)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + this._bmiResult + "\r\nObese!";
                }
            }
        }
        /// <summary>
        /// This is the resetButton event handler, clears the information when it is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if((WeightTextBox.Text != "") || (HeightTextBox.Text !="") || (BMIResultTextBox.Text != ""))
            {
                HeightTextBox.Text = "";
                WeightTextBox.Text = "";
                BMIResultTextBox.Text = "";
            }             
        }
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private TextBoxBase _textBoxBase;
        public TextBoxBase TextBoxBase
        {
            get
            {
                return this._textBoxBase;
            }
            set
            {
                this._textBoxBase = value;
            }
        }
        private void BMIResultTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// this method disable user to input any string in MyHeighttextBox.
        /// Allows to input only numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Reference if this code: https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// this method disable user to input any string in MyHeighttextBox.
        /// Allows to input only numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
