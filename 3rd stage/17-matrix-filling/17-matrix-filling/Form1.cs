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

namespace _17_matrix_filling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] numberMatrix = new int[3, 3];

        private void btnFillMatrix_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string value = Interaction.InputBox("Insira nove elementos e obtenha uma matriz 3x3", "Matrizes");
                    numberMatrix[i, j] = int.Parse(value);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lblResult.Text += numberMatrix[i, j] + " ";
                }

                lblResult.Text += "\n";
            }
        }
    }
}
