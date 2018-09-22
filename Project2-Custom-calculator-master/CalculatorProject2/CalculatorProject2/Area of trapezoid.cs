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
    public partial class Area_of_trapezoid : Form
    {
        public Area_of_trapezoid()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Base1 = Convert.ToDecimal(txtBase1.Text);
            decimal Base2 = Convert.ToDecimal(txtBase2.Text);
            decimal Height = Convert.ToDecimal(txtHeight.Text);
            decimal a;
            a = ((Base1 + Base2) / 2) * Height;
            TxtAreaofTrapezoid.Text = a.ToString();
            string history = "Base1:-" + txtBase1.Text + "Base2:-" + txtBase2.Text + "Height:-" + txtHeight.Text + "Area:-" + TxtAreaofTrapezoid.Text + "\n";
            label6.Text = label6.Text + history;
                txtBase1.Focus();
            





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GeometricCalculator f1 = new GeometricCalculator();
            f1.Show();
            this.Close();
        }
    }
}
