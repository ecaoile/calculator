namespace Calculator
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Result_Textbox.TextChanged += new System.EventHandler(this.Result_Textbox_TextChanged);
            // 
            // zero
            // 
            this.zero.AutoSize = true;
            this.zero.BackColor = System.Drawing.Color.AliceBlue;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zero.Location = new System.Drawing.Point(138, 567);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(120, 100);
            this.zero.TabIndex = 1;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Number_Click);
            this.zero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.zero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.zero.Leave += new System.EventHandler(this.Color_Default);
            this.zero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.zero.MouseLeave += new System.EventHandler(this.Color_Default);
            this.zero.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.zero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.BackColor = System.Drawing.Color.AliceBlue;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.one.Location = new System.Drawing.Point(12, 461);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(120, 100);
            this.one.TabIndex = 2;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Number_Click);
            this.one.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.one.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.one.Leave += new System.EventHandler(this.Color_Default);
            this.one.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.one.MouseLeave += new System.EventHandler(this.Color_Default);
            this.one.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.one.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.BackColor = System.Drawing.Color.AliceBlue;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.two.Location = new System.Drawing.Point(138, 461);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(120, 100);
            this.two.TabIndex = 3;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Number_Click);
            this.two.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.two.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.two.Leave += new System.EventHandler(this.Color_Default);
            this.two.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.two.MouseLeave += new System.EventHandler(this.Color_Default);
            this.two.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.two.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.BackColor = System.Drawing.Color.AliceBlue;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.three.Location = new System.Drawing.Point(264, 461);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(120, 100);
            this.three.TabIndex = 4;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Number_Click);
            this.three.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.three.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.three.Leave += new System.EventHandler(this.Color_Default);
            this.three.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.three.MouseLeave += new System.EventHandler(this.Color_Default);
            this.three.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.three.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.BackColor = System.Drawing.Color.AliceBlue;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.four.Location = new System.Drawing.Point(12, 355);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(120, 100);
            this.four.TabIndex = 5;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Number_Click);
            this.four.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.four.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.four.Leave += new System.EventHandler(this.Color_Default);
            this.four.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.four.MouseLeave += new System.EventHandler(this.Color_Default);
            this.four.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.four.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.BackColor = System.Drawing.Color.AliceBlue;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.five.Location = new System.Drawing.Point(138, 355);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(120, 100);
            this.five.TabIndex = 6;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Number_Click);
            this.five.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.five.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.five.Leave += new System.EventHandler(this.Color_Default);
            this.five.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.five.MouseLeave += new System.EventHandler(this.Color_Default);
            this.five.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.five.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // six
            // 
            this.six.AutoSize = true;
            this.six.BackColor = System.Drawing.Color.AliceBlue;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.six.Location = new System.Drawing.Point(264, 355);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(120, 100);
            this.six.TabIndex = 7;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Number_Click);
            this.six.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.six.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.six.Leave += new System.EventHandler(this.Color_Default);
            this.six.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.six.MouseLeave += new System.EventHandler(this.Color_Default);
            this.six.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.six.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // seven
            // 
            this.seven.AutoSize = true;
            this.seven.BackColor = System.Drawing.Color.AliceBlue;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seven.Location = new System.Drawing.Point(12, 249);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(120, 100);
            this.seven.TabIndex = 8;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Number_Click);
            this.seven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.seven.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.seven.Leave += new System.EventHandler(this.Color_Default);
            this.seven.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.seven.MouseLeave += new System.EventHandler(this.Color_Default);
            this.seven.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.seven.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // eight
            // 
            this.eight.AutoSize = true;
            this.eight.BackColor = System.Drawing.Color.AliceBlue;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eight.Location = new System.Drawing.Point(138, 249);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(120, 100);
            this.eight.TabIndex = 9;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Number_Click);
            this.eight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.eight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.eight.Leave += new System.EventHandler(this.Color_Default);
            this.eight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.eight.MouseLeave += new System.EventHandler(this.Color_Default);
            this.eight.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.eight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // nine
            // 
            this.nine.AutoSize = true;
            this.nine.BackColor = System.Drawing.Color.AliceBlue;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nine.Location = new System.Drawing.Point(264, 249);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(120, 100);
            this.nine.TabIndex = 10;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Number_Click);
            this.nine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.nine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.nine.Leave += new System.EventHandler(this.Color_Default);
            this.nine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.nine.MouseLeave += new System.EventHandler(this.Color_Default);
            this.nine.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.nine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.AutoSize = true;
            this.plusOrMinus.BackColor = System.Drawing.Color.AliceBlue;
            this.plusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plusOrMinus.Location = new System.Drawing.Point(12, 567);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(120, 100);
            this.plusOrMinus.TabIndex = 11;
            this.plusOrMinus.TabStop = false;
            this.plusOrMinus.Text = "±";
            this.plusOrMinus.UseVisualStyleBackColor = false;
            this.plusOrMinus.Click += new System.EventHandler(this.PlusOrMinus_Click);
            this.plusOrMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.plusOrMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.plusOrMinus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.plusOrMinus.Leave += new System.EventHandler(this.Color_Default);
            this.plusOrMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.plusOrMinus.MouseLeave += new System.EventHandler(this.Color_Default);
            this.plusOrMinus.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.plusOrMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.BackColor = System.Drawing.Color.AliceBlue;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dec.Location = new System.Drawing.Point(264, 567);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(120, 100);
            this.dec.TabIndex = 12;
            this.dec.TabStop = false;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.Number_Click);
            this.dec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.dec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.dec.Leave += new System.EventHandler(this.Color_Default);
            this.dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.dec.MouseLeave += new System.EventHandler(this.Color_Default);
            this.dec.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.BackColor = System.Drawing.Color.AliceBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.divide.Location = new System.Drawing.Point(390, 143);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(120, 100);
            this.divide.TabIndex = 13;
            this.divide.TabStop = false;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Operator_Click);
            this.divide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.divide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.divide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.divide.Leave += new System.EventHandler(this.Color_Default);
            this.divide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.divide.MouseLeave += new System.EventHandler(this.Color_Default);
            this.divide.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.divide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.BackColor = System.Drawing.Color.AliceBlue;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.multiply.Location = new System.Drawing.Point(390, 249);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(120, 100);
            this.multiply.TabIndex = 14;
            this.multiply.TabStop = false;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Operator_Click);
            this.multiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.multiply.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.multiply.Leave += new System.EventHandler(this.Color_Default);
            this.multiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.multiply.MouseLeave += new System.EventHandler(this.Color_Default);
            this.multiply.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.multiply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.BackColor = System.Drawing.Color.AliceBlue;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subtract.Location = new System.Drawing.Point(390, 355);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(120, 100);
            this.subtract.TabIndex = 15;
            this.subtract.TabStop = false;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.Operator_Click);
            this.subtract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.subtract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.subtract.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.subtract.Leave += new System.EventHandler(this.Color_Default);
            this.subtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.subtract.MouseLeave += new System.EventHandler(this.Color_Default);
            this.subtract.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.subtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.AliceBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add.Location = new System.Drawing.Point(390, 461);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 100);
            this.add.TabIndex = 16;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Operator_Click);
            this.add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.add.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.add.Leave += new System.EventHandler(this.Color_Default);
            this.add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.add.MouseLeave += new System.EventHandler(this.Color_Default);
            this.add.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.BackColor = System.Drawing.Color.AliceBlue;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.equals.Location = new System.Drawing.Point(390, 567);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(120, 100);
            this.equals.TabIndex = 17;
            this.equals.TabStop = false;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            this.equals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.equals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.equals.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.equals.Leave += new System.EventHandler(this.Color_Default);
            this.equals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.equals.MouseLeave += new System.EventHandler(this.Color_Default);
            this.equals.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.equals.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.Color.AliceBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear.Location = new System.Drawing.Point(12, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 100);
            this.clear.TabIndex = 18;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            this.clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.clear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.clear.Leave += new System.EventHandler(this.Color_Default);
            this.clear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.clear.MouseLeave += new System.EventHandler(this.Color_Default);
            this.clear.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.clear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // backspace
            // 
            this.backspace.AutoSize = true;
            this.backspace.BackColor = System.Drawing.Color.AliceBlue;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backspace.Location = new System.Drawing.Point(264, 143);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(120, 100);
            this.backspace.TabIndex = 19;
            this.backspace.TabStop = false;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            this.backspace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.backspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.backspace.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.backspace.Leave += new System.EventHandler(this.Color_Default);
            this.backspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.backspace.MouseLeave += new System.EventHandler(this.Color_Default);
            this.backspace.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.backspace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // clear_entry
            // 
            this.clear_entry.AutoSize = true;
            this.clear_entry.BackColor = System.Drawing.Color.AliceBlue;
            this.clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_entry.Location = new System.Drawing.Point(138, 143);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(120, 100);
            this.clear_entry.TabIndex = 20;
            this.clear_entry.TabStop = false;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            this.clear_entry.Click += new System.EventHandler(this.ClearEntry_Click);
            this.clear_entry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.clear_entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Color);
            this.clear_entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Color);
            this.clear_entry.Leave += new System.EventHandler(this.Color_Default);
            this.clear_entry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Color);
            this.clear_entry.MouseLeave += new System.EventHandler(this.Color_Default);
            this.clear_entry.MouseHover += new System.EventHandler(this.Hover_Color_Change);
            this.clear_entry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Color);
            // 
            // equation
            // 
            this.equation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.equation.AutoEllipsis = true;
            this.equation.BackColor = System.Drawing.SystemColors.Control;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.equation.Location = new System.Drawing.Point(22, 85);
            this.equation.Name = "equation";
            this.equation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equation.Size = new System.Drawing.Size(475, 35);
            this.equation.TabIndex = 21;
            this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "dummyLabel";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 679);
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
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
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
        private System.Windows.Forms.Label label1;
    }
}

