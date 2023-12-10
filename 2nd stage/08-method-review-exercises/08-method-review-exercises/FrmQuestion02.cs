using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_method_review_exercises
{
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float basis = float.Parse(txtBase.Text);
            float height = float.Parse(txtHeight.Text);
            MessageBox.Show("A área do retângulo é: " + Area(basis, height));
            MessageBox.Show("O perímetro do retângulo é: " + Perimeter(basis, height));
        }

        private float Area(float basis, float height)
        {
            return basis * height;
        }

        private float Perimeter(float basis, float height)
        {
            return 2 * (basis + height);
        }

    }
}
