using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_while_repetition_exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercise01_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("O número " + i + " é múltiplo de 3!");
                    Console.ReadLine();
                }
            }
        }

        private void btnExercise02_Click(object sender, EventArgs e)
        {
            int counter = 100;

            while (counter <= 1000)
            {
                MessageBox.Show(counter.ToString() + " ");
                counter = counter + 100;
            }
        }

        private void btnExercise03_Click(object sender, EventArgs e)
        {
            int counter = 1;

            while (counter <= 5)
            {
                MessageBox.Show("Aluno " + counter, counter.ToString() + " " + (counter * 10));
                counter = counter + 1;
            }
        }
    }
}
