using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           /* int num, binary_val, decimal_val = 0, base_val = 1, rem;
            num = int.Parse(Console.ReadLine());// maximum five digits 
            binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }
            Console.Write("The Binary Number is : " + binary_val);
            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
            Console.ReadLine();
            */
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_B.Text = "";
            txt_O.Text = "";
            txt_H.Text = "";
            txt_D.Text = "";
            txt_bx.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numconverter = int.Parse(txt_bx.Text);
            txt_B.Text = Convert.ToString(numconverter,2);
            txt_D.Text = numconverter.ToString();
            txt_H.Text = Convert.ToString(numconverter, 16);
            txt_O.Text = Convert.ToString(numconverter, 8);

        }
    }
}
