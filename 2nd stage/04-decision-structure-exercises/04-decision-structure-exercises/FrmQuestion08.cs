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
    public partial class FrmQuestion08 : Form
    {
        public FrmQuestion08()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string gender = txtGender.Text;

            if (gender == "f")
            {
                MessageBox.Show("Sexo feminino!");
            }
            else if (gender == "m")
            {
                MessageBox.Show("Sexo inválido, pois é um projeto de mulheres!");
            }
            else
            {
                MessageBox.Show("Digite o sexo corretamente!");
            }
        }
    }
}
