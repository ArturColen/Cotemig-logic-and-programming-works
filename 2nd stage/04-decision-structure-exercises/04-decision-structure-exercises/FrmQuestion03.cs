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
    public partial class FrmQuestion03 : Form
    {
        public FrmQuestion03()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            int password = int.Parse(txtPassword.Text);

            if (user == "admin" && password == 1234)
            {
                MessageBox.Show("Acesso permitido!");
            }
            else if (user == "admin" && password != 1234)
            {
                MessageBox.Show("Senha inválida!");
            }
            else if (user != "admin" && password == 1234)
            {
                MessageBox.Show("Usuário inválido!");
            }
            else
            {
                MessageBox.Show("Acesso negado!");
            }
        }
    }
}
