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
    public partial class Form1 : Form
    {
        MathServiceClient localClient = new MathServiceClient();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int locNum1 = Convert.ToInt32(textBox2.Text.Trim());
            int locNum2 = Convert.ToInt32(textBox3.Text.Trim());
            textBox4.Text = localClient.Add(locNum1, locNum2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           int locNum1 = Convert.ToInt32(textBox2.Text.Trim());
           int locNum2 = Convert.ToInt32(textBox3.Text.Trim());
            textBox4.Text = localClient.Substract(locNum1, locNum2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int locNum1 = Convert.ToInt32(textBox2.Text.Trim());
            int locNum2 = Convert.ToInt32(textBox3.Text.Trim());
            textBox4.Text = localClient.Division(locNum1, locNum2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           int locNum1 = Convert.ToInt32(textBox2.Text.Trim());
            int locNum2 = Convert.ToInt32(textBox3.Text.Trim());
            textBox4.Text = localClient.Multiplication(locNum1, locNum2).ToString();
        }
    }
}
