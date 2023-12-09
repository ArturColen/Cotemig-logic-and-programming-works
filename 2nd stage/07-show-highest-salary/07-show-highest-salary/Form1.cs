using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_show_highest_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            float firstSalary = float.Parse(txtFirstSalary.Text);
            float secondSalary = float.Parse(txtSecondSalary.Text);
            float thirdSalary = float.Parse(txtThirdSalary.Text);
            MessageBox.Show(ShowHigherSalary(firstSalary, secondSalary, thirdSalary));
        }

        private string ShowHigherSalary(float firstSalary, float secondSalary, float thirdSalary)
        {
            if (firstSalary > secondSalary && firstSalary > thirdSalary)
            {
                return ("O primeiro salário é maior!");
            }
            else if (secondSalary > firstSalary && secondSalary > thirdSalary)
            {
                return ("O segundo salário é maior!");
            }
            else if (thirdSalary > firstSalary && thirdSalary > secondSalary+++)
            {
                return ("O terceiro salário é maior!");
            }
            else
            {
                return ("Os salários são iguais!");
            }
        }
    }
}
