using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_simple_calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float addition;

            addition = number1 + number2;

            MessageBox.Show(number1 + " + " + number2 + " = " + addition);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float subtraction;

            subtraction = number1 - number2;

            MessageBox.Show(number1 + " - " + number2 + " = " + subtraction);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float multiplication;

            multiplication = number1 * number2;

            MessageBox.Show(number1 + " x " + number2 + " = " + multiplication);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float division;

            division = number1 / number2;

            MessageBox.Show(number1 + " ÷ " + number2 + " = " + division);
        }
    }
}
