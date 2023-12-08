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
    public partial class FrmQuestion10 : Form
    {
        public FrmQuestion10()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(txtWeight.Text);
            float height = float.Parse(txtHeight.Text);
            float bmi;

            bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                MessageBox.Show("Você está abaixo do peso!");
            }
            else if (bmi < 25)
            {
                MessageBox.Show("Você está com o peso normal!");
            }
            else if (bmi < 30)
            {
                MessageBox.Show("Você está acima do peso!");
            }
            else
            {
                MessageBox.Show("Você está obeso(a)!");
            }
        }
    }
}
