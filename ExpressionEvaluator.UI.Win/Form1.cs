using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={Evaluator.Evaluate(txtDisplay.Text)}";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }
    }
}
