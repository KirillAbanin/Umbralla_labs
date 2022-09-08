using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(inputX.Text);

            if (x >= 1 || x <= 0)
                return;

            double pre = Convert.ToDouble(precision.Text);

            arcsinResult.Text = Convert.ToString(Math.Asin(x));

            int iter = 0;
            double result = x;

            double part = x;

            double firstiter = 0;
            double seconditer = 0;

            do
            {
                firstiter = seconditer;

                iter++;

                part *= ((2 * iter - 1) * x * x) / (2 * iter);

                result += part * Convert.ToDouble(1f / (2f * iter + 1f));

                seconditer = result;

            } while (pre < seconditer - firstiter);

            sumResult.Text = Convert.ToString(result);

            iterResult.Text = Convert.ToString(iter);
        }

        private void precision_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(precision.Text) || string.IsNullOrEmpty(inputX.Text))
            {
                solve.Enabled = false;
            }
            else
            {
                solve.Enabled = true;
            }
        }

        private void inputX_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(precision.Text) || string.IsNullOrEmpty(inputX.Text)))
            {
                solve.Enabled = false;
            }
            else
            {
                solve.Enabled = true;
            }
        }

        private void precision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1' && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if (((e.KeyChar == '1') || (e.KeyChar == '0')) && ((sender as TextBox).Text.IndexOf('1') > -1))
            {
                e.Handled = true;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text) && (e.KeyChar == ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
