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
    public partial class FrmQuestion05 : Form
    {
        public FrmQuestion05()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float snackPrice = float.Parse(txtSnackPrice.Text);
            float amountPaid = float.Parse(txtAmountPaid.Text);
            float change;

            if (snackPrice != amountPaid && snackPrice < amountPaid)
            {
                change = amountPaid - snackPrice;
                MessageBox.Show("O valor do troco é igual a R$" + change);
            }
            else
            {
                MessageBox.Show("Não há troco!");
            }
        }
    }
}
