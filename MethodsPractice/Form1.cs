using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            Addition();
            CircleArea();
            LargestValue();
        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display:
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared

        public void RectangleArea()
        {
            int unitSquare, width, height;

            width = 5;
            height = 7;

            unitSquare = width * height;
            q2Output.Text = $"The area of a {width} x {height} rectangle is {unitSquare} units squared";
        }

        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 

        public void Addition()
        {
            try
            {
                int first = Convert.ToInt32(q3Num1Input.Text);
                int second = Convert.ToInt32(q3Num2Input.Text);

                int total = first * second;
                q3Output.Text = $"{first} + {second} = {total}";
            }
            catch
            {

            }
        }

        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared

        public void CircleArea()
        {
            try
            {
                int radius = Convert.ToInt32(radiusInput.Text);

                double area = radius * radius * 3.14159;
                q4Output.Text = $"The area of a circle with radius of {radius} is {area.ToString(".##")} units squared";
            }
            catch
            {

            }
        }

        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// he largest value is 7
        public void LargestValue()
        {
            try
            {
                int third = Convert.ToInt32(q5Num1Input.Text);
                int fourth = Convert.ToInt32(q5Num2Input.Text);
                int fifth = Convert.ToInt32(q5Num3Input.Text);

                if (third > fourth && third > fifth)
                {
                    q5Output.Text = $"The largest value is {third}";
                }
                else if (fourth > third && fourth > fifth)
                {
                    q5Output.Text = $"The largest value is {fourth}";
                }
                else if (fifth > third && fifth > fourth)
                {
                    q5Output.Text = $"The largest value is {fifth}";
                }
                else
                {
                    q5Output.Text = "All numbers are the same";
                }
            }
            catch
            {

            }
        }
    }
}
