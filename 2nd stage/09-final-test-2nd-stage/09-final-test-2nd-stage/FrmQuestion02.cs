using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_final_test_2nd_stage
{
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        private void btnShowNumbers_Click(object sender, EventArgs e)
        {
            string sequence = cmbSequence.Text;
            lblShowNumbers.Text = ShowNumbers(sequence);
        }

        private string ShowNumbers(string sequence)
        {
            int sequenceLength;
            if (sequence == "5")
            {
                sequenceLength = 5;
            }
            else if (sequence == "10")
            {
                sequenceLength = 10;
            }
            else if (sequence == "20")
            {
                sequenceLength = 20;
            }
            else
            {
                return "Preencha um campo corretamente!";
            }

            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                result.Append(i).Append(" ");

                if (i % sequenceLength == 0)
                {
                    result.Append("\n");
                }
            }

            return result.ToString();
        }
    }
}
