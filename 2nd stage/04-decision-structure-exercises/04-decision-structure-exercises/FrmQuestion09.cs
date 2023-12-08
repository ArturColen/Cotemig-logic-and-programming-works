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
    public partial class FrmQuestion09 : Form
    {
        public FrmQuestion09()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtValue.Text);

            if (value > 0)
            {
                MessageBox.Show("O valor é positivo!");
            }
            else if (value == 0)
            {
                MessageBox.Show("O valor é neutro!");
            }
            else
            {
                MessageBox.Show("O valor é negativo!");
            }
        }
    }
}
