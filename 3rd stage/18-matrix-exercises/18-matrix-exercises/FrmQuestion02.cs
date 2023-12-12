﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_matrix_exercises
{
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        int[,] numberMatrix = new int[4, 4];

        private void btnExecute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    numberMatrix[i, j] = j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    lblResult.Text += numberMatrix[i, j];
                }

                lblResult.Text += "\n";
            }
        }
    }
}
