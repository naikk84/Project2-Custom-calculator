using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject2
{
    public partial class AreaofEllipse : Form
    {
        public AreaofEllipse()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GeometricCalculator form = new GeometricCalculator();
            form.Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtxAxis.Text);
            decimal y = Convert.ToDecimal(txtyAxis.Text);
            decimal a;
            a = (22 * x * y)/7;
            txtArea.Text = a.ToString();
            string history = "X-Axis:- " + txtxAxis.Text + " " + "Y-Axis:- " + txtyAxis.Text + " " + "Area:- " + txtArea.Text + "\n";
            label5.Text = label5.Text + history;
            label5.ForeColor = Color.White;
            label5.BackColor = Color.Transparent;
            txtxAxis.Focus();
        }
    }
}
