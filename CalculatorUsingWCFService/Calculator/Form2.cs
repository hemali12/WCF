using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.MathService;
namespace Calculator
{
    public partial class Form2 : Form
    {
        public string opt;
        public Int32 num1, num2;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToInt32(textBox1.Text.Trim());
             opt= "add";
            textBox1.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text.Trim());
            opt = "sub";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text.Trim());
            opt = "multi";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text.Trim());
            opt = "div";
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
             num2 = Convert.ToInt32(textBox1.Text.Trim());
            MathServiceClient client = new MathServiceClient();
            
            if(opt == "add")
            {
               textBox1.Text = client.Add(num1, num2).ToString();
                
            }else if (opt == "sub")
            {
                textBox1.Text = client.Add(num1, num2).ToString();

            }else if (opt == "multi")
            {
                textBox1.Text = client.Add(num1, num2).ToString();

            }else if (opt == "div")
            {
                textBox1.Text = client.Add(num1, num2).ToString();

            }else
            {
                textBox1.Text = "";
            }
        }
    }
}
