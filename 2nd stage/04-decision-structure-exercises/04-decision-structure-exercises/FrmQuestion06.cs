using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_decision_structure_exercises
{
    public partial class FrmQuestion06 : Form
    {
        public FrmQuestion06()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int numberSides = int.Parse(txtNumberSides.Text);

            if (numberSides == 3)
            {
                MessageBox.Show("Triângulo!");
            }
            else if (numberSides == 4)
            {
                MessageBox.Show("Quadrado!");
            }
            else
            {
                MessageBox.Show("Polígono não identificado!");
            }
        }
    }
}
