using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            Triple num1 = new Triple(inputNumber1.Text);
            Triple num2 = new Triple(inputNumber2.Text);

            string res = Triple.Sum(num1, num2);

            result.Text = res;

        }
    }
}
