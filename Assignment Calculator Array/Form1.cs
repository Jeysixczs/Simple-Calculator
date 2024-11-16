using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Assignment_Calculator_Array
{
    public partial class Calculator : Form
    {

        Double[,] array = new double[4, 4]
   {
        {0, 1, 2, 3},
        {4, 5, 6, 7},
        {8, 9, 0, 0},
        {0, 0, 0, 0},
   };
        char operation;
        double num1, num2, result;


        public Calculator()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            /*
            textBox1.Clear();
            textBox2.Text = "i miss u na!";
            */
            
            switch (operation)
            {
                
                case '+':
                    result = num1 + num2;
                    textBox1.Clear();
                    textBox2.Text = result.ToString();
                    break;

                case '-':
                    result = num1 - num2;
                    textBox1.Clear();
                    textBox2.Text = result.ToString();
                    break;
                case '×':
                    result = num1 * num2;
                    textBox1.Clear();
                    textBox2.Text = result.ToString();
                    break;
                case '÷':
                    result = num1 / num2;
                    textBox1.Clear();
                    textBox2.Text = result.ToString();
                    break;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '+';

        }
        private void button0_Click(object sender, EventArgs e)
        {

            textBox1.Text += array[0, 0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[0, 1].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[0, 2].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[0, 3].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[1, 0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[1, 1].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[1, 2].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[1, 3].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[2, 0].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += array[2, 1].ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            textBox1.Text += "÷";
            operation = '÷';
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '×';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '-';
        }
        

        private void button15_Click_1(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
