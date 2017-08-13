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
 * Version: 0.5- Added ResetButton_Click event handler
 */
namespace Assignment05_300924228
{
    public partial class BMICalculatorForm : Form
    {
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
                WeightInPounds.Text = "Weight in Pounds";
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
                WeightInPounds.Text = "Weight in Kg";
            }
            if (BMIResultTextBox.Text == "")
            {

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
            if (ImperialRadioButton.Checked)
            {
                int heightInInches = Convert.ToInt32(HeightTextBox.Text);
                int weightInPounds = Convert.ToInt32(WeightTextBox.Text);
                double bmi = weightInPounds * 703 / (heightInInches * heightInInches);
                
                if (bmi < 18.5)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nYou're underweight!";
                }
                if ((bmi >= 18.5) && (bmi <= 24.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nIt's Normal!";
                }
                if ((bmi >= 25) && (bmi <= 29.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi+ "\nYou're Overweight!";
                }
                if (bmi >= 30)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nObese!";
                }
            }
            if (MatricRadioButton.Checked)
            {
                double heightInMeters = Convert.ToDouble(HeightTextBox.Text);
                double weightInKg = Convert.ToDouble(WeightTextBox.Text);
                double bmi = weightInKg / (heightInMeters * heightInMeters);
                
                if(bmi < 18.5)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nYou're underweight!";
                }
                if((bmi >= 18.5) && (bmi <= 24.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nIt's Normal!";
                }
                if((bmi >= 25) && (bmi <= 29.9))
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi + "\nYou're Overweight!";
                }
                if(bmi >= 30)
                {
                    BMIResultTextBox.Text = "Your BMI is :" + bmi+ "\nObese!";
                }
            }
        }
        /// <summary>
        /// This is the sesent event handler, clears the information when it is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {           
                HeightTextBox.Text = "0";
                WeightTextBox.Text = "0";
                BMIResultTextBox.Text = "";
        }
    }
}
