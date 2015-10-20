/*  
Author:         Stephen Blanchard
CLID:           swb4062
Class:          CMPS 358
Assignment:     project_1 - Windows Forms
assignment­#     1
Due Date:       11:55pm October 13
Description:    Create a calculator using Windows Forms, Visual Studio 2013 and C#/.net
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1_swb4062
{
    public partial class Calculator : Form
    {
        float num1, num2, result;                        //holds the operands and result
        bool equalsPressed = false, trigger = false;    //a check to see if = was pressed or an operator
        string op = "";                                 //track the operator being used
        public Calculator()
        {
            InitializeComponent();
        }
        //method for choosing the Quit option from the drop-down menu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application gracefully.
        }
        //method for handling backspace button
        private void Backspace_Click(object sender, EventArgs e)
        {   //if equals has been previously pressed, clear the screen
            if (equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            //otherwise, remove the most recently entered character from the text box
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
        }
        //The clr button
        private void Clr_Click(object sender, EventArgs e)
        {   //this resets all variables back to their default and clears the text box.
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            equalsPressed = false;
            op = "";
            trigger = false;
        }
        //posneg button
        private void PosNeg_Click(object sender, EventArgs e)
        {   //if equals was previously pressed, clear the text box
            if (trigger == true | equalsPressed)
            {
                textBox1.Clear();
                if (equalsPressed)
                    equalsPressed = false;
            }
            //otherwise, if the number is already negative, make it positive
            if (textBox1.Text.Contains("-"))
                textBox1.Text = textBox1.Text.Remove(0, 1);
            //if the number if positive, insert a negative to the front of the number.
            else
                textBox1.Text = textBox1.Text.Insert(0, "-");
        }
        //The methods for each number work the same as one another:
        private void seven_Click(object sender, EventArgs e)
        {   //If there's a 0 or a -0, replace it with the number that's pressed
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {   //additionally, if the enter key was pressed, the next number hit will clear the screen
                textBox1.Clear();
                equalsPressed = false;
            }//There's also a character limit of 15, so after that's reached, no more characters are appended.
            if(textBox1.Text.Length<15)
                textBox1.AppendText("7");
        }
        //see comments for private void seven_Click
        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("8");
        }
        //see comments for private void seven_Click
        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();

                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("9");
        }
        //each operator is coded in the same way:
        private void divide_Click(object sender, EventArgs e)
        {   //If an operator has been previously pressed
            if (trigger)
            {   //then the current number in the text box is the second number
                num2 = float.Parse(textBox1.Text);
                if (op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("div"))
                    result = num1 / num1;
                //do an operation based on what the operator is, clear the box and put the result in
                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                //then set the operator to operator that called this function
                op = "div";
                //In preperation for the next operation, the first number is now the result of the previous operation.
                num1 = result;
            }
            //if no operator was previously pressed, then the number in the box is the first number
            if (!trigger)
            {   //and the current operator is the one that was pressed.
                op = "div";
                num1 = float.Parse(textBox1.Text);
                trigger = true;
            }
        }
        //see comments for private void seven_Click
        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("4");
        }
        //see comments for private void seven_Click
        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("5");
        }
        //see comments for private void seven_Click
        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("6");
        }
        //see comments for private void divide_Click
        private void times_Click(object sender, EventArgs e)
        {
            if (trigger)
            {
                num2 = float.Parse(textBox1.Text);
                if (op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("div"))
                    result = num1 / num1;

                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                op = "mult";
                num1 = result;
            }
            if (!trigger)
            {
                op = "mult";
                num1 = float.Parse(textBox1.Text);
                trigger = true;
            }
        }
        //see comments for private void seven_Click
        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("1");
        }
        //see comments for private void seven_Click
        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("2");
        }
        //see comments for private void seven_Click
        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | textBox1.Text == "-0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("3");
        }
        //see comments for private void divide_Click
        private void minus_Click(object sender, EventArgs e)
        {
            if (trigger)
            {
                num2 = float.Parse(textBox1.Text);
                if (op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("div"))
                    result = num1 / num1;

                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                op = "sub";
                num1 = result;
            }
            if (!trigger)
            {
                op = "sub";
                num1 = float.Parse(textBox1.Text);
                trigger = true;
            }
        }
        //see comments for private void seven_Click
        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | trigger == true | equalsPressed)
            {
                textBox1.Clear();
                trigger = false;
                equalsPressed = false;
            }
            if (textBox1.Text.Length < 15)
                textBox1.AppendText("0");
        }
        //the decimal is somewhat unique in that only one is allowed in the text box at a time
        private void point_Click(object sender, EventArgs e)
        {   //if an operator was clicked followed by a decimal, clear the text box
            if (trigger == true)
            {
                textBox1.Clear();
                trigger = false;
            }
            //then, if we haven't reached the character limit and there's no decimal in the box thus far, put one
            if (textBox1.Text.Length < 15 && textBox1.Text.Contains(".") == false)
                textBox1.AppendText(".");
            //if the decimal that was just entered is the first character to be entered, put a zero in front of it
            if (textBox1.Text.Length == 1)
                textBox1.Text = textBox1.Text.Insert(0, "0");
        }
        //Equals checks for two different states:  if it's the first time equals was pressed or subsequent
        private void equals_Click(object sender, EventArgs e)
        {
            //If this is not the first time equals has been pressed
            if (equalsPressed)
            {   //then we take the result from the previous equals and make it the first number
                num1 = result;
                //then, we perform the same operation that was performed last time equal was pressed
                if (op.Equals("div"))                    
                    result = num1 / num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                //Then clear the text box and place the new result in it.  Mark that equals was pressed and not an operator.
                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                equalsPressed = true;
                trigger = false;
            }
            //if equals has not been pressed yet
            if (!equalsPressed)
            {   //then the number that's currently in the text box is our second number in the operation
                num2 = float.Parse(textBox1.Text);
                //perform the chosen operation on the two numbers
                if (op.Equals("div"))
                    result = num1 / num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                //if no operator was chosen, then the result is simply the only number entered thus far
                if (op.Equals(""))
                {
                    result = float.Parse(textBox1.Text);
                }
                //clear the box and put the resulting number in. Mark equals as pressed and an operator as not.
                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                equalsPressed = true;
                trigger = false;
            }
        }
        //see comments for private void divide_Click
        private void plus_Click(object sender, EventArgs e)
        {
            if (trigger)
            {
                num2 = float.Parse(textBox1.Text);
                if(op.Equals("add"))
                    result = num1 + num2;
                if (op.Equals("sub"))
                    result = num1 - num2;
                if (op.Equals("mult"))
                    result = num1 * num2;
                if (op.Equals("div"))
                    result = num1 / num1;

                textBox1.Clear();
                textBox1.AppendText(result.ToString());
                op = "add";
                num1 = result;
            }
            if (!trigger)
            {
                op = "add";
                num1 = float.Parse(textBox1.Text);
                trigger = true;
            }
        }
        //performs the same operation as the Clr button only through a menu.
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            equalsPressed = false;
            op = "";
            trigger = false;
        }
    }
}
