namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result_Textbox = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.plusOrMinus = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result_Textbox
            // 
            this.Result_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Result_Textbox.Location = new System.Drawing.Point(12, 15);
            this.Result_Textbox.Multiline = true;
            this.Result_Textbox.Name = "Result_Textbox";
            this.Result_Textbox.ReadOnly = true;
            this.Result_Textbox.Size = new System.Drawing.Size(498, 112);
            this.Result_Textbox.TabIndex = 0;
            this.Result_Textbox.Text = "0";
            this.Result_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.AliceBlue;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zero.Location = new System.Drawing.Point(138, 567);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(120, 100);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Number_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.AliceBlue;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.one.Location = new System.Drawing.Point(12, 461);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(120, 100);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Number_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.AliceBlue;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.two.Location = new System.Drawing.Point(138, 461);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(120, 100);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Number_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.AliceBlue;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.three.Location = new System.Drawing.Point(264, 461);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(120, 100);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Number_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.AliceBlue;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.four.Location = new System.Drawing.Point(12, 355);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(120, 100);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Number_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.AliceBlue;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.five.Location = new System.Drawing.Point(138, 355);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(120, 100);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Number_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.AliceBlue;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.six.Location = new System.Drawing.Point(264, 355);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(120, 100);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Number_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.AliceBlue;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seven.Location = new System.Drawing.Point(12, 249);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(120, 100);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Number_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.AliceBlue;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eight.Location = new System.Drawing.Point(138, 249);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(120, 100);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Number_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.AliceBlue;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nine.Location = new System.Drawing.Point(264, 249);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(120, 100);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Number_Click);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.BackColor = System.Drawing.Color.AliceBlue;
            this.plusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plusOrMinus.Location = new System.Drawing.Point(12, 567);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(120, 100);
            this.plusOrMinus.TabIndex = 11;
            this.plusOrMinus.Text = "±";
            this.plusOrMinus.UseVisualStyleBackColor = false;
            this.plusOrMinus.Click += new System.EventHandler(this.PlusOrMinus_Click);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.Color.AliceBlue;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dec.Location = new System.Drawing.Point(264, 567);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(120, 100);
            this.dec.TabIndex = 12;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.Number_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.AliceBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.divide.Location = new System.Drawing.Point(390, 143);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(120, 100);
            this.divide.TabIndex = 13;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.AliceBlue;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.multiply.Location = new System.Drawing.Point(390, 249);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(120, 100);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.AliceBlue;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subtract.Location = new System.Drawing.Point(390, 355);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(120, 100);
            this.subtract.TabIndex = 15;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.Operator_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.AliceBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add.Location = new System.Drawing.Point(390, 461);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 100);
            this.add.TabIndex = 16;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Operator_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.AliceBlue;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.equals.Location = new System.Drawing.Point(390, 567);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(120, 100);
            this.equals.TabIndex = 17;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.AliceBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear.Location = new System.Drawing.Point(12, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 100);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.AliceBlue;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backspace.Location = new System.Drawing.Point(264, 143);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(120, 100);
            this.backspace.TabIndex = 19;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // clear_entry
            // 
            this.clear_entry.BackColor = System.Drawing.Color.AliceBlue;
            this.clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_entry.Location = new System.Drawing.Point(138, 143);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(120, 100);
            this.clear_entry.TabIndex = 20;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            this.clear_entry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // equation
            // 
            this.equation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(415, 85);
            this.equation.Name = "equation";
            this.equation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equation.Size = new System.Drawing.Size(95, 42);
            this.equation.TabIndex = 21;
            this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(522, 679);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.plusOrMinus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.Result_Textbox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result_Textbox;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plusOrMinus;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear_entry;
        private System.Windows.Forms.Label equation;
    }
}

