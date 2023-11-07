using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_displaying_data_on_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            MessageBox.Show("Nome: " + name);
            MessageBox.Show("Idade: " + age);
            MessageBox.Show("E-mail: " +  email);
            MessageBox.Show("Senha: " +  password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
