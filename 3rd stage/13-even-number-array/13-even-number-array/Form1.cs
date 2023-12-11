using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_even_number_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] evenNumbers = new int[6];

        private void btnShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                evenNumbers[i] = i * 2;
            }

            for (int i = 0; i < 6; i++)
            {
                lblResult.Text += "Pares[" + i + "] = " + evenNumbers[i] + "\n";
            }
        }
    }
}
