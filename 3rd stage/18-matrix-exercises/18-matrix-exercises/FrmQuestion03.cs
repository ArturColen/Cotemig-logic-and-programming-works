using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _18_matrix_exercises
{
    public partial class FrmQuestion03 : Form
    {
        public FrmQuestion03()
        {
            InitializeComponent();
        }

        int[,] numberMatrix = new int[4, 4];

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double media = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    String value = Interaction.InputBox("insira os elementos para obter uma matriz 4x4", "Matrizes");
                    numberMatrix[i, j] = int.Parse(value);
                    sum += numberMatrix[i, j];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    lblResult.Text += numberMatrix[i, j] + " ";
                }
            }

            media = sum / numberMatrix.Length;
            lblResult.Text = "A média é igual a: " + media;
        }
    }
}
