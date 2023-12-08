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
    public partial class FrmQuestion07 : Form
    {
        public FrmQuestion07()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float height = float.Parse(txtHeight.Text);
            float weight = float.Parse(txtWeight.Text);
            string gender = txtGender.Text;
            double idealWeight;

            if (gender == "m")
            {
                idealWeight = (weight * height) - 58;
                MessageBox.Show("O seu peso ideal é: " + idealWeight);
            }
            else if (gender == "f")
            {
                idealWeight = (weight * height) - 44.7;
                MessageBox.Show("O seu peso ideal é: " + idealWeight);
            }
            else
            {
                MessageBox.Show("Digite o sexo corretamente!");
            }
        }
    }
}
