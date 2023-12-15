using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _19_student_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentConnection db = new StudentConnection();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string insert;
            int test;
            string unit = rdbBarroca.Checked ? "Barroca" : "Floresta";
            int series = rdbFirstSeries.Checked ? 1 : rdbSecondSeries.Checked ? 2 : 3;
            string classes = cmbClass.Text;

            if (txtName.Text != "" && int.TryParse(txtAge.Text, out test))
            {
                insert = String.Format("insert into students (name, age, unit, series, class) values ('{0}', '{1}', '{2}', '{3}', '{4      }')", txtName.Text, txtAge.Text, unit, series, classes);

                db.ExecuteCommands(insert);

                MessageBox.Show("Aluno cadastrado com sucesso!");

                txtName.Clear();
                txtAge.Clear();
                rdbBarroca.Checked = false;
                rdbFloresta.Checked = false;
                rdbFirstSeries.Checked = false;
                rdbSecondSeries.Checked = false;
                rdbThirdSeries.Checked = false;
                cmbClass.Text = "";
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            String change;
            int test;

            if (int.TryParse(txtAge.Text, out test))
            {
                change = String.Format("update students set age = '{0}', name = '{1}' where id = '{2}'", txtAge.Text, txtName.Text, txtId.Text);
                db.ExecuteCommands(change);
                MessageBox.Show("Dados do aluno atualizados com sucesso!");
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            string select = "select * from students order by name";
            DataTable dt = db.ExecuteQuery(select);
            dt.AsDataView();
            dtgStudents.DataSource = dt;
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
                delete = string.Format("delete from students where id = '{0}'", txtId.Text);
                db.ExecuteCommands(delete);

                MessageBox.Show("Dados do aluno excluídos com sucesso!");

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                rdbBarroca.Checked = false;
                rdbFloresta.Checked = false;
                rdbFirstSeries.Checked = false;
                rdbSecondSeries.Checked = false;
                rdbThirdSeries.Checked = false;
                cmbClass.Text = "";
            }
            else
            {
                MessageBox.Show("ID inválido!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dtgStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAge.Text = dtgStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            String unit = dtgStudents.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (unit == "Barroca")
            {
                rdbBarroca.Checked = true;
            }
            else
            {
                rdbFloresta.Checked = true;
            }

            String series = dtgStudents.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (series == "1")
            {
                rdbFirstSeries.Checked = true;
            }
            else if (series == "2")
            {
                rdbSecondSeries.Checked = true;
            }
            else
            {
                rdbThirdSeries.Checked = true;
            }

            cmbClass.Text = dtgStudents.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
