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
    public partial class AreaofRectangle : Form
    {
        public AreaofRectangle()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GeometricCalculator f1 = new GeometricCalculator();
            f1.Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Length = Convert.ToDecimal(txtLength.Text);
            decimal Breadth = Convert.ToDecimal(txtBreadth.Text);
            decimal a;
            a = Length * Breadth;
            txtAreaofRectangle.Text = a.ToString();
            string history = "Length:-" + txtLength.Text + "Breadth:-" + txtBreadth.Text +"Area:-" + txtAreaofRectangle.Text + "\n";
            label5.Text = label5.Text + history;
            txtLength.Focus();
        }
    }
}
