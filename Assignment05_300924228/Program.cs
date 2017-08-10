using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student No: 300924228
 * Date: August 10, 2017
 * Description: This is the BMI Calculator wondow form for the prospective Assignment 05 of COMP123-s2017
 * This calculator prompts users to input information like gender, age height and weight and returns a standard result
 */
namespace Assignment05_300924228
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
