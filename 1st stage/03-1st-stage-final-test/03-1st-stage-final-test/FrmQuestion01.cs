using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_1st_stage_final_test
{
    public partial class FrmQuestion01 : Form
    {
        public FrmQuestion01()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string notebookBrand = txtNotebookBrand.Text;
            string screenSize = txtScreenSize.Text;
            string noteboobkColor = txtNoteboobkColor.Text;
            string operationalSystem = txtOperationalSystem.Text;

            MessageBox.Show("Marca: " + notebookBrand);
            MessageBox.Show("Tamanho da tela: " + screenSize);
            MessageBox.Show("Cor: " + noteboobkColor);
            MessageBox.Show("Sistema operacional: " + operationalSystem);
        }
    }
}
