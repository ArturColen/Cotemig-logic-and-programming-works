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
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        private void btnCalculateInstallmentAmount_Click(object sender, EventArgs e)
        {
            float installmentValue = float.Parse(txtInstallmentValue.Text);
            float interest = float.Parse(txtInterest.Text);
            int daysOverdue = int.Parse(txtDaysOverdue.Text);
            float result;

            result = installmentValue + (installmentValue * interest / 100 * daysOverdue);

            lblResult.Text = result.ToString();
        }
    }
}
