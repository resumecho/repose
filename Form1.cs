using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcultr
{
    public partial class Form1 : Form
    {
        
        
        
       
        bool positive = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "-";
           
            
            positive = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "+";
            
            
            positive = true;
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            textBox1.Text+= "*";
            
            
            positive = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            positive = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
                if (positive == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    positive = false;
                }
                else if (positive == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    positive = true;
                }
            }

        private void button12_Click(object sender, EventArgs e)
        {
            
            label1.Text = "";
            char[] signs = { '+', '-', '*', '/' };
            string[] numbers = textBox1.Text.Split(signs);
            double number1 = Double.Parse(numbers[0]);
            double number2 = Double.Parse(numbers[1]);
            char sign = '+';
            foreach (char item in signs)
            {
                if (textBox1.Text.IndexOf(item) >= 0)
                {
                    sign = item;
                    break;
                }
            }
            switch (sign)
            {
                case '+':
                    textBox1.Text = (number1 + number2).ToString();
                    break;
                case '-':
                    textBox1.Text = (number1 - number2).ToString();
                    break;
                case '*':
                    textBox1.Text = (number1 * number2).ToString();
                    break;
                case '/':
                    textBox1.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
