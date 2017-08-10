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
 * Version: 0.3- Created CalculateBMI click event
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
                HeightNumericUpDown.DecimalPlaces = 0;
                WeightNumericUpDown.DecimalPlaces = 0;
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
                HeightNumericUpDown.DecimalPlaces = 2;
                WeightNumericUpDown.DecimalPlaces = 2;
            }
        }
        private void CalculateBMI_Click(object sender, EventArgs e)
       
        {
            if (ImperialRadioButton.Checked)
            {
                double bmi;
                int heightInInches = 0;
                int weightInPounds = 0;
                heightInInches = Convert.ToInt32(HeightNumericUpDown.Text);
                weightInPounds = Convert.ToInt32(WeightNumericUpDown.Text);

                bmi = weightInPounds * 703 / (heightInInches * heightInInches);
                BMIResultTextBox.Text = "Your BMI is : {0:f2}" + bmi;
            }
            if (MatricRadioButton.Checked)
            {
                double bmi;
                double heightInMeters = 0;
                double weightInKg = 0;
                heightInMeters = Convert.ToDouble(HeightNumericUpDown.Text);
                weightInKg = Convert.ToDouble(WeightNumericUpDown.Text);

                bmi = weightInKg * 703 / (heightInMeters * heightInMeters);
                BMIResultTextBox.Text = "Your BMI is : {0:f2}" + bmi;
            }
        }
      }
   }
