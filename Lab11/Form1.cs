// Author: Jonathan Spalding
// Assignment: Lab 11
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 2/11/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The button1_click method
        // Purpose: take the length of both sides and put them in variables, then return the method CalcHypotenuse to output the Hypotenuse.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void button1_Click(object sender, EventArgs e)
        {
            //convert the input for both side1 and 2 from strings to double and store them in their own variables
            double side1 = double.Parse(a.Text);
            double side2 = double.Parse(b.Text);
            //call the CalcHypetunse method and pass in the lengths of the two sides of the triangle as parameters and save the value returned by the method in a variable.
            double total = CalcHypotenuse(side1, side2);
            //convert the output from a double to a string.
            string outStr = $"{total}";
            //output to the output box as side c.
            c.Text = outStr;
        }
        // The CalcHypotenuse Method
        // Purpose: multiply the square root of two sides to find the Hypotenuse
        // Parameters: double side1, double side2
        // returns: hypotenuse
        static double CalcHypotenuse(double side1, double side2)
        {
            //find the hypotenuse by adding the square root of side1 and side2.
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            //return the hypotenuse.
            return hypotenuse;
        }
    }
}
