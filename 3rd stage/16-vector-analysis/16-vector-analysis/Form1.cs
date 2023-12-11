using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_vector_analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vector;

        private void btnCreateVector_Click(object sender, EventArgs e)
        {
            if (txtVectorSize.Text == "0")
            {
                MessageBox.Show("Forneça o tamanho do vetor.");
            }
            else
            {
                lstElements.Items.Clear();

                vector = new int[int.Parse(txtVectorSize.Text)];

                btnFillVector.Enabled = true;
                btnHighestValue.Enabled = true;
                btnLowestValue.Enabled = true;
                btnQuantityZeros.Enabled = true;
                btnAverageValue.Enabled = true;

                for (int i = 0; i < vector.Length; i++)
                {
                    lstElements.Items.Add(vector[i]);
                }
            }
        }

        private void btnFillVector_Click(object sender, EventArgs e)
        {
            Random elements = new Random();
            lstElements.Items.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = elements.Next(0, 100);
                lstElements.Items.Add(vector[i]);
            }
        }

        private void btnHighestValue_Click(object sender, EventArgs e)
        {
            int highestValue = vector[0];
            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] > highestValue)
                    highestValue = vector[i];
            }

            lblResults.Text = highestValue.ToString();
        }

        private void btnLowestValue_Click(object sender, EventArgs e)
        {
            int lowestValue = vector[0];
            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] < lowestValue)
                    lowestValue = vector[i];
            }

            lblResults.Text = lowestValue.ToString();
        }

        private void btnQuantityZeros_Click(object sender, EventArgs e)
        {
            int counter = 0;

            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                    counter++;
            }

            lblResults.Text = counter.ToString();
        }

        private void btnAverageValue_Click(object sender, EventArgs e)
        {
            int i, sum = 0;
            double media;

            for (i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }

            media = (double)sum / vector.Length;

            lblResults.Text = media.ToString("#, ##0.00");
        }
    }
}
