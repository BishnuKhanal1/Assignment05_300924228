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
 * Version: 0.2- Created BMICalculatorForm_FormClosing event handler
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
    }
}
