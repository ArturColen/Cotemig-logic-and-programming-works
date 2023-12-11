using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_increment_and_decrement_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbNumber1.Text) || string.IsNullOrWhiteSpace(cmbNumber2.Text))
            {
                MessageBox.Show("Por favor, preencha os dois campos.");
                return;
            }

            int initialValue, finalValue;

            if (!int.TryParse(cmbNumber1.Text, out initialValue) || !int.TryParse(cmbNumber2.Text, out finalValue))
            {
                MessageBox.Show("Entrada inválida. Certifique-se de inserir números inteiros.");
                return;
            }

            if (initialValue > finalValue)
            {
                while (initialValue >= finalValue)
                {
                    txtResult.Text += initialValue.ToString() + " ";
                    initialValue--;
                }
            }
            else if (initialValue < finalValue)
            {
                while (initialValue <= finalValue)
                {
                    txtResult.Text += initialValue.ToString() + " ";
                    initialValue++;
                }
            }
            else
            {
                txtResult.Text = initialValue.ToString();
            }
        }
    }
}
