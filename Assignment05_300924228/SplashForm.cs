﻿using System;
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
 * Description: This is the SplashForm class for the Assignment 05 BMI Calculator
 * Version:0.2- Created SplashFormTimer_Tick event handler
 */
namespace Assignment05_300924228
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the SplashFormTimer_Tick event handler
        /// This event handler displays SplashForm form for 3 seconds and replaced by bmiCalculatorform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculatorForm = new BMICalculatorForm();
            bmiCalculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; //triggers only once
        }
    }
}
