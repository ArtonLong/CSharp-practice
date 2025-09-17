namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Equals = new Button();
            textBox = new TextBox();
            Divide = new Button();
            Multiply = new Button();
            Minus = new Button();
            Plus = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            ClearAll = new Button();
            history = new TextBox();
            clear = new Button();
            pow = new Button();
            sqrt = new Button();
            eqStart = new Button();
            eqEnd = new Button();
            SuspendLayout();
            // 
            // Equals
            // 
            Equals.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Equals.Location = new Point(714, 678);
            Equals.Name = "Equals";
            Equals.Size = new Size(90, 90);
            Equals.TabIndex = 0;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = true;
            Equals.Click += equals_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(12, 169);
            textBox.Name = "textBox";
            textBox.Size = new Size(792, 71);
            textBox.TabIndex = 1;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Divide.Location = new Point(714, 582);
            Divide.Name = "Divide";
            Divide.Size = new Size(90, 90);
            Divide.TabIndex = 2;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += button_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Multiply.Location = new Point(714, 486);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(90, 90);
            Multiply.TabIndex = 3;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += button_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Minus.Location = new Point(714, 390);
            Minus.Name = "Minus";
            Minus.Size = new Size(90, 90);
            Minus.TabIndex = 4;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += button_Click;
            // 
            // Plus
            // 
            Plus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Plus.Location = new Point(714, 294);
            Plus.Name = "Plus";
            Plus.Size = new Size(90, 90);
            Plus.TabIndex = 5;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(426, 390);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(618, 390);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(522, 390);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(426, 486);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(522, 486);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(618, 486);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(426, 582);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(522, 582);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(618, 582);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(522, 678);
            button0.Name = "button0";
            button0.Size = new Size(90, 90);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // ClearAll
            // 
            ClearAll.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearAll.Location = new Point(522, 294);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(186, 90);
            ClearAll.TabIndex = 16;
            ClearAll.Text = "CA";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += ClearAll_Click;
            // 
            // history
            // 
            history.BackColor = SystemColors.Control;
            history.BorderStyle = BorderStyle.None;
            history.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.ForeColor = SystemColors.ControlDark;
            history.Location = new Point(12, 99);
            history.Name = "history";
            history.ReadOnly = true;
            history.Size = new Size(792, 64);
            history.TabIndex = 17;
            history.TextAlign = HorizontalAlignment.Right;
            history.Click += history_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.Location = new Point(426, 294);
            clear.Name = "clear";
            clear.Size = new Size(90, 90);
            clear.TabIndex = 18;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // pow
            // 
            pow.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pow.Location = new Point(300, 294);
            pow.Name = "pow";
            pow.Size = new Size(90, 90);
            pow.TabIndex = 19;
            pow.Text = "^";
            pow.UseVisualStyleBackColor = true;
            pow.Click += button_Click;
            // 
            // sqrt
            // 
            sqrt.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sqrt.Location = new Point(204, 294);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(90, 90);
            sqrt.TabIndex = 20;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += sqrt_Click;
            // 
            // eqStart
            // 
            eqStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eqStart.Location = new Point(12, 294);
            eqStart.Name = "eqStart";
            eqStart.Size = new Size(90, 90);
            eqStart.TabIndex = 21;
            eqStart.Text = "(";
            eqStart.UseVisualStyleBackColor = true;
            eqStart.Click += button_Click;
            // 
            // eqEnd
            // 
            eqEnd.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eqEnd.Location = new Point(108, 294);
            eqEnd.Name = "eqEnd";
            eqEnd.Size = new Size(90, 90);
            eqEnd.TabIndex = 22;
            eqEnd.Text = ")";
            eqEnd.UseVisualStyleBackColor = true;
            eqEnd.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 780);
            Controls.Add(eqEnd);
            Controls.Add(eqStart);
            Controls.Add(sqrt);
            Controls.Add(pow);
            Controls.Add(clear);
            Controls.Add(history);
            Controls.Add(ClearAll);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(Plus);
            Controls.Add(Minus);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(textBox);
            Controls.Add(Equals);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Equals;
        private TextBox textBox;
        private Button Divide;
        private Button Multiply;
        private Button Minus;
        private Button Plus;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button ClearAll;
        private TextBox history;
        private Button clear;
        private Button pow;
        private Button sqrt;
        private Button eqStart;
        private Button eqEnd;
    }
}
