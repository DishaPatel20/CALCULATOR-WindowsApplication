using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_WIN_FORMS
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;
                //MessageBox.Show("ADDITION RESULT IS : " + result.ToString());
                label4.Text = "ADDITION RESULT IS : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("PLEASE FILL BOTH FIELDS !!");
            }
           
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;
                label4.Text = "SUBTRACTION RESULT IS : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("PLEASE FILL BOTH FIELDS !!");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;
                label4.Text = "MULTIPLICATION RESULT IS : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("PLEASE FILL BOTH FIELDS !!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;
                label4.Text = "DIVISON RESULT IS : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("PLEASE FILL BOTH FIELDS !!");
            }
        }

  
    }
}
