using org.mariuszgromada.math.mxparser;

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
            string solve = exp.calculate().ToString().Replace(',', '.');

            history.Text = textBox.Text + " = " + solve;
            textBox.Text = solve;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text += button.Text;
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

        private void history_Click(object sender, EventArgs e)
        {
            if (history.Text != "")
            {
                string[] text = history.Text.Split(" =");
                textBox.Text = text[0];
                history.Clear();
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            textBox.Text = $"sqrt({textBox.Text})";
        }
    }
}
