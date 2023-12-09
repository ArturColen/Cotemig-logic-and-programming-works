using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_method_review_exercises
{
    public partial class FrmQuestion01 : Form
    {
        public FrmQuestion01()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
            MessageBox.Show(validateDate(day, month, year));
        }

        private string validateDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
            {
                return "Preencha o dia corretamente!";
            }
            if (month < 1 || month > 12)
            {
                return "Preencha o mês corretamente!";
            }
            if (year < 1 || year > 3000)
            {
                return "Preencha o ano corretamente!";
            }

            return "Data correta!";
        }
    }
}
