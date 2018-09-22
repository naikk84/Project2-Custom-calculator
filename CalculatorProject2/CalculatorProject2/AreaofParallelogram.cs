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
    public partial class AreaofParallelogram : Form
    {
        public AreaofParallelogram()
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
            decimal b = Convert.ToDecimal(txtBase.Text);
            decimal h = Convert.ToDecimal(txtHeight.Text);
            decimal a;
            a = b * h;
            txtArea.Text = a.ToString();
            string history = "Base:- " + txtBase.Text + " " + "Height:- " + txtHeight.Text + " " + "Area:- " + txtArea.Text + "\n";
            label5.Text = label5.Text + history;
            txtBase.Focus();
        }
    }
}
