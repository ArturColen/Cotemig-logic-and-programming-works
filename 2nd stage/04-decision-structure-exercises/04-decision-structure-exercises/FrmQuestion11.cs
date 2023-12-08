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
    public partial class FrmQuestion11 : Form
    {
        public FrmQuestion11()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float productPrice = float.Parse(txtProductPrice.Text);
            int paymentMethod = int.Parse(txtPaymentMethod.Text);
            float calculation;
            float result;

            if (paymentMethod == 1)
            {
                calculation = productPrice / 10;
                result = productPrice - calculation;
                MessageBox.Show("O valor a ser pago é: R$" + result);
            }
            else if (paymentMethod == 2)
            {
                calculation = (productPrice * 15) / 100;
                result = productPrice - calculation;
                MessageBox.Show("O valor a ser pago é: R$" + result);
            }
            else if (paymentMethod == 3)
            {
                calculation = productPrice / 2;
                MessageBox.Show("O valor a ser pago é: R$" + calculation + ", cada parcela");
            }
            else if (paymentMethod == 4)
            {
                calculation = productPrice / 10;
                result = productPrice + calculation;
                MessageBox.Show("O valor a ser pago é: R$" + result);
            }
            else
            {
                MessageBox.Show("Forma de pagamento inválida!");
            }
        }
    }
}
