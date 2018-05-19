using System;
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
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        bool hit_equals = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (Result_Textbox.Text == "0" || operation_pressed == true || hit_equals == true)
                Result_Textbox.Clear();
            operation_pressed = false;
            hit_equals = false;
            Button b = (Button)sender;
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
            if (value != 0)
            {
                value = Do_Math(operation, Result_Textbox.Text, value);
                Result_Textbox.Text = value.ToString();
                operation = b.Text;
                equation.Text = equation.Text + value + " " + operation;

            }
            else
            {
                operation = b.Text;
                value = Double.Parse(Result_Textbox.Text);
                equation.Text = value + " " + operation;

            }
            operation_pressed = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            hit_equals = true;
            value = Do_Math(operation, Result_Textbox.Text, value);
            Result_Textbox.Text = value.ToString();
            operation = "";
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.Focus();
                    zero.PerformClick();
                    break;
                case "1":
                    one.Focus();
                    one.PerformClick();
                    break;
                case "2":
                    two.Focus();
                    two.PerformClick();
                    break;
                case "3":
                    three.Focus();
                    three.PerformClick();
                    break;
                case "4":
                    four.Focus();
                    four.PerformClick();
                    break;
                case "5":
                    five.Focus();
                    five.PerformClick();
                    break;
                case "6":
                    six.Focus();
                    six.PerformClick();
                    break;
                case "7":
                    seven.Focus();
                    seven.PerformClick();
                    break;
                case "8":
                    eight.Focus();
                    eight.PerformClick();
                    break;
                case "9":
                    nine.Focus();
                    nine.PerformClick();
                    break;
                case "+":
                    add.Focus();
                    add.PerformClick();
                    break;
                case "-":
                    subtract.Focus();
                    subtract.PerformClick();
                    break;
                case "*":
                    multiply.Focus();
                    multiply.PerformClick();
                    break;
                case "/":
                    divide.Focus();
                    divide.PerformClick();
                    break;
                case "=":
                    equals.Focus();
                    equals.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
