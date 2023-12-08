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
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int birthYear = int.Parse(txtBirthYear.Text);
            int result;

            result = 2022 - birthYear;

            if (result >= 16)
            {
                MessageBox.Show("Pode votar!");
            }
            else
            {
                MessageBox.Show("Não pode votar!");
            }
        }
    }
}
