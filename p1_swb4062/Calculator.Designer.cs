namespace p1_swb4062
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Backspace = new System.Windows.Forms.Button();
            this.Clr = new System.Windows.Forms.Button();
            this.PosNeg = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.WordWrap = false;
            // 
            // Backspace
            // 
            this.Backspace.FlatAppearance.BorderSize = 5;
            this.Backspace.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backspace.Location = new System.Drawing.Point(12, 95);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(60, 37);
            this.Backspace.TabIndex = 1;
            this.Backspace.Text = "Bksp";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Clr
            // 
            this.Clr.FlatAppearance.BorderSize = 5;
            this.Clr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clr.Location = new System.Drawing.Point(158, 95);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(60, 37);
            this.Clr.TabIndex = 2;
            this.Clr.Text = "Clr";
            this.Clr.UseVisualStyleBackColor = true;
            this.Clr.Click += new System.EventHandler(this.Clr_Click);
            // 
            // PosNeg
            // 
            this.PosNeg.FlatAppearance.BorderSize = 5;
            this.PosNeg.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosNeg.Location = new System.Drawing.Point(231, 95);
            this.PosNeg.Name = "PosNeg";
            this.PosNeg.Size = new System.Drawing.Size(60, 37);
            this.PosNeg.TabIndex = 3;
            this.PosNeg.Text = "±";
            this.PosNeg.UseVisualStyleBackColor = true;
            this.PosNeg.Click += new System.EventHandler(this.PosNeg_Click);
            // 
            // seven
            // 
            this.seven.AutoSize = true;
            this.seven.FlatAppearance.BorderSize = 5;
            this.seven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 142);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 37);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.AutoSize = true;
            this.eight.FlatAppearance.BorderSize = 5;
            this.eight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(85, 142);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 37);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.AutoSize = true;
            this.nine.FlatAppearance.BorderSize = 5;
            this.nine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(158, 142);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 37);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.FlatAppearance.BorderSize = 5;
            this.divide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(231, 142);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 37);
            this.divide.TabIndex = 7;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.FlatAppearance.BorderSize = 5;
            this.times.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(231, 187);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(60, 37);
            this.times.TabIndex = 11;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // six
            // 
            this.six.AutoSize = true;
            this.six.FlatAppearance.BorderSize = 5;
            this.six.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(158, 187);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 37);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.FlatAppearance.BorderSize = 5;
            this.five.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(85, 187);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 37);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.FlatAppearance.BorderSize = 5;
            this.four.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 187);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 37);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.FlatAppearance.BorderSize = 5;
            this.minus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(233, 232);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 37);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.FlatAppearance.BorderSize = 5;
            this.three.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(158, 232);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 37);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.FlatAppearance.BorderSize = 5;
            this.two.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(85, 232);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 37);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.FlatAppearance.BorderSize = 5;
            this.one.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 232);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 37);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.FlatAppearance.BorderSize = 5;
            this.plus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(233, 277);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 37);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.FlatAppearance.BorderSize = 5;
            this.equals.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(158, 277);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(60, 37);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.FlatAppearance.BorderSize = 5;
            this.point.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(85, 277);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(60, 37);
            this.point.TabIndex = 17;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.AutoSize = true;
            this.zero.FlatAppearance.BorderSize = 5;
            this.zero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 277);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 37);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(307, 328);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.times);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.PosNeg);
            this.Controls.Add(this.Clr);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Clr;
        private System.Windows.Forms.Button PosNeg;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

