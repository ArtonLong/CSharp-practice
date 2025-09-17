using org.mariuszgromada.math.mxparser;
using System.Data;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            Expression exp = new Expression(textBox.Text);
            string solve = exp.calculate().ToString();

            history.Text = textBox.Text + " = " + solve;
            textBox.Text = solve;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            history.Clear();
            textBox.Clear();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void history_Click(object sender, EventArgs e)
        {
            if (history.Text != "")
            {
                string[] text = history.Text.Split(" =");
                textBox.Text = text[0];
                history.Clear();
            }
        }
    }
}
