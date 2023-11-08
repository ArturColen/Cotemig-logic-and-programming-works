using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_1st_stage_final_test
{
    public partial class FrmQuestion03 : Form
    {
        public FrmQuestion03()
        {
            InitializeComponent();
        }

        private void btnCalculateSalaryIncrease_Click(object sender, EventArgs e)
        {
            float currentSalary = float.Parse(txtCurrentSalary.Text);
            float increasedSalary;

            increasedSalary = currentSalary + (currentSalary * 37 / 100);

            MessageBox.Show("O salário com aumento é: " + increasedSalary);
        }
    }
}
