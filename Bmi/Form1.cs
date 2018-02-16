using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmi
{
    public partial class Form1 : Form
    {
        public double bmiResult(double heigth, double weight)
        {
            double heightSquare = (heigth * heigth);
            double bmiResult = (weight / heightSquare);
            return bmiResult;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) | string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label3.Text = "Må have input";
            }

            else
            {
                double heigth = double.Parse(textBox1.Text);
                double weigth = double.Parse(textBox2.Text);
                double result = bmiResult(heigth, weigth);
                label3.Text = result.ToString();
            }
        }
    }
}
