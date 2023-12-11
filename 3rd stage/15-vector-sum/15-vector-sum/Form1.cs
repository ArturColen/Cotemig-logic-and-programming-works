using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_vector_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numbers = new int[30];

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int totalSum = 0;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < 30; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < 30; i++)
            {
                totalSum += numbers[i];
            }

            for (int i = 0; i < 30; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];
                }
            }

            txtTotalSum.Text += totalSum.ToString();
            txtSumEvenNumbers.Text += evenSum.ToString();
            txtSumOddNumbers.Text += oddSum.ToString();
        }
    }
}
