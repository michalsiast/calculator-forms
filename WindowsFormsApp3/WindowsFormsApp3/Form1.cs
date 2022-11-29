using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            double number = 7;
            label_result.Text += Convert.ToString(number);
        }
        private void button_six_Click(object sender, EventArgs e)
        {
            double number = 6;
            label_result.Text += Convert.ToString(number);
        }
        private void button_five_Click(object sender, EventArgs e)
        {
            double number = 5;
            label_result.Text += Convert.ToString(number);
        }
        private void button_four_Click(object sender, EventArgs e)
        {
            double number = 4;
            label_result.Text += Convert.ToString(number);
        }
        private void button_three_Click(object sender, EventArgs e)
        {
            double number = 3;
            label_result.Text += Convert.ToString(number);
        }
        private void button_two_Click(object sender, EventArgs e)
        {
            double number = 2;
            label_result.Text += Convert.ToString(number);
        }
        private void button_one_Click(object sender, EventArgs e)
        {
            double number = 1;
            label_result.Text += Convert.ToString(number);
        }
        private void button_nine_Click(object sender, EventArgs e)
        {
            double number = 9;
            label_result.Text += Convert.ToString(number);
        }
        private void button_eight_Click(object sender, EventArgs e)
        {
            double number = 8;
            label_result.Text += Convert.ToString(number);
        }
        private void button_zero_Click(object sender, EventArgs e)
        {
            double number = 0;
            label_result.Text += Convert.ToString(number);
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text += "+";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text += "*";
        }

        private void button_deduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text += "-";
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            DataTable calculations = new DataTable();
            label_result.Text = calculations.Compute(label_result.Text, null).ToString();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text += "/";
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;

            DataTable dt = new DataTable();

            label_result.Text = $"√{label_result.Text} = {Math.Sqrt(Convert.ToDouble(dt.Compute(label_result.Text, null)))} ";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1, 1);
        }

        private void button_fullclear_Click(object sender, EventArgs e)
        {
            label_result.Text = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label_result.Text = "";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_result.Text)) return;
            label_result.Text += ".";
        }
    }
}
