using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_final_test_3rd_stage
{
    public partial class FrmQuestion02 : Form
    {
        public FrmQuestion02()
        {
            InitializeComponent();
        }

        EmployeeConnection db = new EmployeeConnection();

        private void btnEmployeeRegistration_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string position = cmbPosition.Text;
            string salary = txtSalary.Text;
            string insert = "";

            if (txtName.Text != "" && cmbPosition.Text != "" && txtSalary.Text != "")
            {
                insert = String.Format("insert into employees (name, position, salary) values ('{0}', '{1}', '{2}')", txtName.Text, cmbPosition.Text, txtSalary.Text);

                db.ExecuteCommands(insert);

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                txtName.Clear();
                cmbPosition.Text = "";
                txtSalary.Clear();
                txtName.Focus();

            }
            else
            {
                MessageBox.Show("Informação Inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchEmployees_Click(object sender, EventArgs e)
        {
            string select = "select * from employees order by name";
            DataTable dt = db.ExecuteQuery(select);
            dt.AsDataView();
            dtgEmployees.DataSource = dt;
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            string change;
            int test;

            if (int.TryParse(txtSalary.Text, out test))
            {
                change = String.Format("update employees set salary = '{0}', name = '{1}' where id = '{2}'", txtSalary.Text, txtName.Text, txtId.Text);
                db.ExecuteCommands(change);
                MessageBox.Show("Dados do funcionário atualizados com sucesso!");
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string delete;

            if (txtId.Text != "")
            {
                delete = String.Format("delete from employees where id = '{0}'", txtId.Text);
                db.ExecuteCommands(delete);

                MessageBox.Show("Dados do funcionário excluídos com sucesso!");

                txtId.Clear();
                txtName.Clear();
                cmbPosition.Text = "";
                txtSalary.Clear();
            }
            else
            {
                MessageBox.Show("ID inválido!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dtgEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbPosition.Text = dtgEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSalary.Text = dtgEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
