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
    public partial class FrmQuestion01 : Form
    {
        public FrmQuestion01()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            float value1 = float.Parse(txtValue1.Text);
            float value2 = float.Parse(txtValue2.Text);

            if (value1 != value2)
            {
                if (value1 > value2)
                {
                    MessageBox.Show("O 1º valor é maior!");
                }
                else
                {
                    MessageBox.Show("O 2º valor é maior!");
                }
            }
            else
            {
                MessageBox.Show("Os valores são iguais!");
            }
        }
    }
}
