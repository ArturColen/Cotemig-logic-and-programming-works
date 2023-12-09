using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_final_test_2nd_stage
{
    public partial class FrmQuestion01 : Form
    {
        public FrmQuestion01()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int registrationCode;
            if (!int.TryParse(txtRegistrationCode.Text, out registrationCode))
            {
                MessageBox.Show("O campo matrícula deve ser preenchido corretamente!");
                return;
            }

            string fullName = txtFullName.Text;
            string gender = cmbGender.Text;
            string group = txtClass.Text;
            string observation = txtObservation.Text;

            lblFullNameError.Text = validateEmptyField(fullName, "nome");
            lblGenderError.Text = validateEmptyField(gender, "sexo");
            lblClassError.Text = validateEmptyField(group, "turma");
            lblObservationError.Text = validateEmptyField(observation, "observações");
            lblRegistrationCodeError.Text = validateRegistrationCode(registrationCode);

            if (lblFullNameError.Text == "" && lblGenderError.Text == "" && lblClassError.Text == "" && lblObservationError.Text == "" && lblRegistrationCodeError.Text != "Preencha corretamente o campo matrícula!")
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                clearField();
            }
        }

        private string validateEmptyField(string value, string field)
        {
            if (value == "")
            {
                return "Campo " + field + " deve ser preenchido!";
            }
            else
            {
                return "";
            }
        }

        private string validateRegistrationCode(int registrationCode)
        {
            if (registrationCode < 1000 || registrationCode > 9999)
            {
                return "Preencha corretamente o campo matrícula!";
            }
            else
            {
                if (registrationCode >= 1000 && registrationCode <= 3000)
                {
                    return "Curso de Administração";
                }
                else if (registrationCode >= 3001 && registrationCode <= 5000)
                {
                    return "Curso de Mecatrônica";
                }
                else if (registrationCode >= 5001 && registrationCode <= 7000)
                {
                    return "Curso de Informática";
                }
                else if (registrationCode >= 7001 && registrationCode <= 9999)
                {
                    return "Curso de TI";
                }
                else
                {
                    return "Curso não corresponde a matrícula";
                }
            }
        }

        private void clearField()
        {
            txtRegistrationCode.Text = "";
            txtFullName.Text = "";
            cmbGender.Text = "";
            txtClass.Text = "";
            txtObservation.Text = "";
        }
    }
}
