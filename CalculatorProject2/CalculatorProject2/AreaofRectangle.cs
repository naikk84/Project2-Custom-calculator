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
            a = Math.Round(a, 2);
            txtAreaofRectangle.Text = a.ToString();
            string history = "Length:- " + txtLength.Text + " " + "Width:- " + txtBreadth.Text + " " + "Area:- " + txtAreaofRectangle.Text + "\n";
            label7.Text = label7.Text + history;
            label7.ForeColor = Color.White;
            label7.BackColor = Color.Transparent;
            txtLength.Focus();
        }

        private void AreaofRectangle_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
