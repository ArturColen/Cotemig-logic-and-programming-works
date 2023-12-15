using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_final_test_3rd_stage
{
    public partial class FrmQuestion01 : Form
    {
        public FrmQuestion01()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[4, 4];
            Random random = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    matrix[row, column] = random.Next(10, 100);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    lblCompleteMatrix.Text += matrix[row, column] + " ";
                }

                lblCompleteMatrix.Text += "\n";
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    if (row == column)
                        lblMainDiagonal.Text += matrix[row, column] + " ";
                    else
                        lblMainDiagonal.Text += "   ";
                }

                lblMainDiagonal.Text += "\n";
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    if (row + column == 3)
                        lblSecondaryDiagonal.Text += matrix[row, column] + " ";
                    else
                        lblSecondaryDiagonal.Text += "   ";
                }

                lblSecondaryDiagonal.Text += "\n";
            }
        }
    }
}
