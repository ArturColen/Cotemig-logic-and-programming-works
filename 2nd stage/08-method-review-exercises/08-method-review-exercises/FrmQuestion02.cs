﻿using System;
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
            MessageBox.Show("A área do retângulo é: " + area(basis, height));
            MessageBox.Show("O perímetro do retângulo é: " + perimeter(basis, height));
        }

        private float area(float basis, float height)
        {
            return basis * height;
        }
        private float perimeter(float basis, float height)
        {
            return 2 * (basis + height);
        }

    }
}
