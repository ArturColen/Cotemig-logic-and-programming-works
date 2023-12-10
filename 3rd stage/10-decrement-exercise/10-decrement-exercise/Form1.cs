using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_decrement_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int initialValue) && int.TryParse(txtNumber2.Text, out int finalValue))
            {
                if (initialValue >= finalValue)
                {
                    Decrease(initialValue, finalValue);
                }
                else
                {
                    lblResult.Text = "O valor inicial deve ser maior ou igual ao valor final.";
                }
            }
            else
            {
                lblResult.Text = "Por favor, insira valores numéricos válidos.";
            }
        }

        private void Decrease(int initialValue, int finalValue)
        {
            string values = "";

            for (int i = initialValue; i >= finalValue; i--)
            {
                values += i + " ";
            }

            lblResult.Text = values;
        }
    }
}
