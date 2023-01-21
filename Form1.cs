using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);

                float subtract = num1 - num2;

                label4.Text = subtract.ToString();
                label4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);

                float product = num1 * num2;

                label4.Text = product.ToString();
                label4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);

                float divide = num1 / num2;

                label4.Text = divide.ToString();
                label4.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);

                float modulus = num1 % num2;

                label4.Text = modulus.ToString();
                label4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);

                float add = num1 + num2;

                label4.Text= add.ToString();
                label4.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mandotory.");
            }
            else
            {
                double num1 = Int32.Parse(textBox1.Text);
                double num2 = Int32.Parse(textBox2.Text);

                double exponent = Math.Pow(num1,num2);

                label4.Text = exponent.ToString();
                label4.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
