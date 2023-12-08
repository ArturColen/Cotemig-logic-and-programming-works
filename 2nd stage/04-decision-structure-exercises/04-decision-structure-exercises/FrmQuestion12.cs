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
    public partial class FrmQuestion12 : Form
    {
        public FrmQuestion12()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(txtStudentNumber.Text);
            float studentGrades = float.Parse(txtStudentGrades.Text);
            float averageExercise = float.Parse(txtAverageExercise.Text);

            if (averageExercise >= 90)
            {
                MessageBox.Show("Conceito A");
            }
            else if (averageExercise >= 75 && averageExercise < 90)
            {
                MessageBox.Show("Conceito B");
            }
            else if (averageExercise >= 60 && averageExercise < 75)
            {
                MessageBox.Show("Conceito C");
            }
            else if (averageExercise >= 40 && averageExercise < 60)
            {
                MessageBox.Show("Conceito D");
            }
            else
            {
                MessageBox.Show("Conceito E");
            }
        }
    }
}
