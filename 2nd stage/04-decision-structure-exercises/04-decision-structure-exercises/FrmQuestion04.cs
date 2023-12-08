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
    public partial class FrmQuestion04 : Form
    {
        public FrmQuestion04()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int quantityApples = int.Parse(txtQuantityApples.Text);
            double amountPaid;

            if (quantityApples > 1)
            {
                if (quantityApples < 12)
                {
                    amountPaid = quantityApples * 0.30;
                    MessageBox.Show("O valor pago será igual a: R$" + amountPaid);
                }
                else
                {
                    amountPaid = quantityApples * 0.25;
                    MessageBox.Show("O valor pago será igual a: R$" + amountPaid);
                }
            }
            else
            {
                MessageBox.Show("Quantidade de maçãs inválida!");
            }
        }
    }
}
