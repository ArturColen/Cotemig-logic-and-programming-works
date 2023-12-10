using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_repetition_loops_exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ForSequence();
            WhileSequence();
            DoWhileSequence();
        }

        private void ForSequence()
        {
            for (int counter = 1; counter <= 256; counter *= 2)
            {
                txtFor.Text += counter + " ";
            }
        }

        private void WhileSequence()
        {
            int counter = 1;

            while (counter <= 256)
            {
                txtWhile.Text += counter + " ";
                counter *= 2;
            }
        }

        private void DoWhileSequence()
        {
            int counter = 1;

            do
            {
                txtDoWhile.Text += counter + " ";
                counter *= 2;
            } while (counter <= 256);
        }
    }
}
