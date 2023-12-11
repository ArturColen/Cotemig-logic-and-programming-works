using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_drawings_in_tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            CleanLabel();

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    lblResult.Text += " * ";
                }

                lblResult.Text += "\n";
            }
        }

        private void btnShowDiagonal_Click(object sender, EventArgs e)
        {
            CleanLabel();

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (row == column)
                    {
                        lblResult.Text += " * ";
                    }
                    else
                    {
                        lblResult.Text += "  ";
                    }
                }

                lblResult.Text += "\n";
            }
        }

        private void btnShowHalfPyramid_Click(object sender, EventArgs e)
        {
            CleanLabel();

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (row >= column)
                    {
                        lblResult.Text += " * ";
                    }
                    else
                    {
                        lblResult.Text += "   ";
                    }
                }

                lblResult.Text += "\n";
            }
        }

        private void btnShowLetterX_Click(object sender, EventArgs e)
        {
            CleanLabel();

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (row == column || (row + column) == 4)
                    {
                        lblResult.Text += " * ";
                    }
                    else
                    {
                        lblResult.Text += "   ";
                    }
                }

                lblResult.Text += "\n";
            }
        }

        private void btnShowPlusSign_Click(object sender, EventArgs e)
        {
            CleanLabel();

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (row == 2 || column == 2)
                    {
                        lblResult.Text += " * ";
                    }
                    else
                    {
                        lblResult.Text += "   ";
                    }
                }

                lblResult.Text += "\n";
            }
        }

        private void CleanLabel()
        {
            lblResult.Text = "";
        }
    }
}
