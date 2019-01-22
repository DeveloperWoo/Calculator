using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        float num, ans;
        int operatorNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "0", Color.Blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "1", Color.Blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "2", Color.Blue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "3", Color.Blue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "4", Color.Blue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "5", Color.Blue);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "6", Color.Blue);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "7", Color.Blue);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "8", Color.Blue);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, "9", Color.Blue);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            addTextColor(textBox1, ".", Color.Blue);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operatorClick(1, "+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operatorClick(2, "-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operatorClick(3, "*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operatorClick(4, "/");
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = ""; //Clear the text on the label
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int length = textBox1.TextLength - 1;
                textBox1.Text = textBox1.Text.Substring(0, length);
            }
        }

        public void operatorClick(int operatorNumber, string operatorSymbol)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operatorNum = operatorNumber;
            label1.Text += num.ToString() + operatorSymbol; // Display text
        }

        public void compute()
        {
            switch (operatorNum)
            {
            case 1: //Add
                ans = num + float.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
                break;
            case 2: //Subtract
                ans = num - float.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
                break;
            case 3: //Multiply
                ans = num * float.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
                break;
            case 4: //Divide
                ans = num / float.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
                break;
            default:
                break;
        }
        }

        public void Disable()
        {
            buttonON.Show();
            buttonOFF.Hide();

            textBox1.Enabled = false;
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonDot.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSubtract.Enabled = false;
            buttonEqual.Enabled = false;
            buttonClear.Enabled = false;
            buttonBack.Enabled = false;
        }

        public void Enable()
        {
            buttonON.Hide();
            buttonOFF.Show();

            textBox1.Enabled = true;
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonDot.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivide.Enabled = true;
            buttonAdd.Enabled = true;
            buttonSubtract.Enabled = true;
            buttonEqual.Enabled = true;
            buttonClear.Enabled = true;
            buttonBack.Enabled = true;
        }

        //Display the passed string in the text box with Blue colour
        static void addTextColor(TextBox textBox, string str, Color colour)
        {
            if (!textBox.Text.Contains(".") || str != ".")
            {
                textBox.Text = textBox.Text + str;
                textBox.ForeColor = colour;
            }
        }
    }
}
