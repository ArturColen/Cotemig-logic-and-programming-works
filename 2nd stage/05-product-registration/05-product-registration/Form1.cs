using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_product_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            float costPrice = float.Parse(txtCostPrice.Text);
            int minimumStock = int.Parse(txtMinimumStock.Text);
            float sellingPrice = float.Parse(txtSellingPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string category = cmbCategory.Text;
            int taxRate = int.Parse(txtTaxRate.Text);
            float tax;
            int quantityErrors = 0;

            if (costPrice <= 0)
            {
                quantityErrors = quantityErrors + 1;
                lblCostPriceError.Text = "Preço de custo não pode ter um valor menor ou igual a 0!".ToString();
            }

            if (minimumStock <= 0)
            {
                quantityErrors = quantityErrors + 1;
                lblMinimumStockError.Text = "O estoque mínimo não pode ter um valor menor ou igual a 0!".ToString();
            }

            if (sellingPrice < costPrice)
            {
                quantityErrors = quantityErrors + 1;
                lblSellingPriceError.Text = "Preço de venda não pode ser menor que o preço de custo!".ToString();
            }

            if (quantity < minimumStock)
            {
                quantityErrors = quantityErrors + 1;
                lblQuantityError.Text = "Quantidade não pode ter um valor menor que o estoque mínimo!".ToString();
            }

            if (category == "")
            {
                quantityErrors = quantityErrors + 1;
                lblCategoryError.Text = "Preencha corretamente a categoria!".ToString();
            }
            else if (category != "Alimento" && category != "Bebida")
            {
                quantityErrors = quantityErrors + 1;
                lblCategoryError.Text = "Selecione uma categoria válida!".ToString();
            }

            if (quantityErrors == 0)
            {
                tax = sellingPrice * taxRate;
                MessageBox.Show("Cadastro realizado com sucesso! Valor de imposto: R$" + tax);
            }
        }
    }
}
