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
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (Result_Textbox.Text == "0" || operation_pressed == true)
                Result_Textbox.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            Result_Textbox.Text = Result_Textbox.Text + b.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result_Textbox.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    Result_Textbox.Text = (value + Double.Parse(Result_Textbox.Text)).ToString();
                    break;
                case "-":
                    Result_Textbox.Text = (value - Double.Parse(Result_Textbox.Text)).ToString();
                    break;
                case "*":
                    Result_Textbox.Text = (value * Double.Parse(Result_Textbox.Text)).ToString();
                    break;
                case "/":
                    Result_Textbox.Text = (value / Double.Parse(Result_Textbox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            Result_Textbox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result_Textbox.Clear();
            value = 0;
        }

    }
}
