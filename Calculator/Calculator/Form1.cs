﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        String lastInput = "";
        bool operation_pressed = false;
        bool hit_equals = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //b.BackColor = Color.FromArgb(153, 204, 255);
            if (Result_Textbox.Text == "0" || operation_pressed == true || hit_equals == true)
            {
                Result_Textbox.Clear();
            }

            operation_pressed = false;
            hit_equals = false;
            
            if (b.Text == ".")
            {
                if (!Result_Textbox.Text.Contains("."))
                    Result_Textbox.Text = Result_Textbox.Text + b.Text;
            }
            else
                Result_Textbox.Text = Result_Textbox.Text + b.Text;
        }

        public double Do_Math(string operation, string resultText, double value)
        {
            switch (operation)
            {
                case "+":
                    value = value + Double.Parse(resultText);
                    break;
                case "-":
                    value = value - Double.Parse(resultText);
                    break;
                case "x":
                    value = value * Double.Parse(resultText);
                    break;
                case "÷":
                    value = value / Double.Parse(resultText);
                    break;
                default:
                    break;
            }
            return value;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (operation_pressed == false)
            {
                if (value != 0)
                {
                    lastInput = lastInput + " " + Result_Textbox.Text;
                    value = Do_Math(operation, Result_Textbox.Text, value);
                    Result_Textbox.Text = value.ToString();
                    operation = b.Text;
                    equation.Text = lastInput + " " + operation;
                }

                else
                {
                    operation = b.Text;
                    value = Double.Parse(Result_Textbox.Text);
                    equation.Text = value + " " + operation;
                }
                lastInput = equation.Text;
                operation_pressed = true;
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            lastInput = "";
            hit_equals = true;
            value = Do_Math(operation, Result_Textbox.Text, value);
            Result_Textbox.Text = value.ToString();
            operation = "";
            value = 0;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            Result_Textbox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result_Textbox.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void PlusOrMinus_Click(object sender, EventArgs e)
        {
            if (Result_Textbox.Text.StartsWith("-"))
                Result_Textbox.Text = Result_Textbox.Text.Substring(1);
            else
                Result_Textbox.Text = "-" + Result_Textbox.Text;

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Result_Textbox.Text))
                Result_Textbox.Text = Result_Textbox.Text.Remove(Result_Textbox.Text.Length - 1);
            if (String.IsNullOrEmpty(Result_Textbox.Text))
                Result_Textbox.Text = "0";
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return) || e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //equation.Focus();
                equals.PerformClick();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Delete))
            {
                backspace.PerformClick();
            }
            //equation.Focus();
            switch (e.KeyChar)
            {
                case '0':
                    //zero.Focus();
                    zero.PerformClick();
                    break;
                case '1':
                    //one.Focus();
                    one.PerformClick();
                    break;
                case '2':
                    //two.Focus();
                    two.PerformClick();
                    break;
                case '3':
                    //three.Focus();
                    three.PerformClick();
                    break;
                case '4':
                    //four.Focus();
                    four.PerformClick();
                    break;
                case '5':
                    //five.Focus();
                    five.PerformClick();
                    break;
                case '6':
                    //six.Focus();
                    six.PerformClick();
                    break;
                case '7':
                    //seven.Focus();
                    seven.PerformClick();
                    break;
                case '8':
                    //eight.Focus();
                    eight.PerformClick();
                    break;
                case '9':
                    //nine.Focus();
                    nine.PerformClick();
                    break;
                case '+':
                    //add.Focus();
                    add.PerformClick();
                    break;
                case '-':
                    //subtract.Focus();
                    subtract.PerformClick();
                    break;
                case '*':
                    //multiply.Focus();
                    multiply.PerformClick();
                    break;
                case '/':
                    //divide.Focus();
                    divide.PerformClick();
                    break;
                case '=':
                    //equals.Focus();
                    equals.PerformClick();
                    break;
                case '.':
                    //dec.Focus();
                    dec.PerformClick();
                    break;
                default:
                    break;
            }
            //equation.Focus();
        }

        private void KeyPress_Color(object sender, KeyPressEventArgs e)
        {
            //Button b = (Button)sender;
            //b.BackColor = Color.FromArgb(153, 204, 255);
            //equation.Focus();
        }

        private void KeyDown_Color(object sender, KeyEventArgs e)
        {

            //switch (Convert.ToChar(e.KeyCode))
            //{
            //    case '0':
            //        //zero.Focus();
            //        zero.BackColor = Color.FromArgb(153, 204, 255);
            //        //Result_Textbox.Focus();
            //        break;
            //    case '1':
            //       // one.Focus();
            //        one.BackColor = Color.FromArgb(153, 204, 255);
            //        //dummyLabel.Focus();
            //        break;
            //    case '2':
            //        //two.Focus();
            //        two.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '3':
            //        //three.Focus();
            //        three.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '4':
            //        //four.Focus();
            //        //four.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '5':
            //        //five.Focus();
            //        five.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '6':
            //        //six.Focus();
            //        six.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '7':
            //        //seven.Focus();
            //        seven.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '8':
            //        //eight.Focus();
            //        eight.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '9':
            //        //nine.Focus();
            //        nine.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '+':
            //        //add.Focus();
            //        add.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '-':
            //        //subtract.Focus();
            //        subtract.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '*':
            //        //multiply.Focus();
            //        multiply.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '/':
            //        //divide.Focus();
            //        divide.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '=':
            //        //equals.Focus();
            //        equals.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    case '.':
            //        //dec.Focus();
            //        dec.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //    default:
            //        //equals.Focus();
            //        equals.BackColor = Color.FromArgb(153, 204, 255);
            //        break;
            //}
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(153, 204, 255);
        }

        private void KeyUp_Color(object sender, KeyEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.AliceBlue;
        }

        private void Hover_Color_Change(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(204, 230, 255);
        }

        private void Color_Default(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.AliceBlue;
        }

        private void Mouse_Down_Color(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(153, 204, 255);
        }

        private void Mouse_Up_Color(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.AliceBlue;
            equation.Focus();
        }
    }
}
