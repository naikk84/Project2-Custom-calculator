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
    public partial class Area_of_triangle : Form
    {
        public Area_of_triangle()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal h = Convert.ToDecimal(txtheight.Text);

            decimal b = Convert.ToDecimal(txtbase.Text);

            decimal area;


           area = (b*h)/2;

            txtresult.Text = area.ToString();
            string history = "Height:-" + txtheight.Text + "Base:-" + txtbase.Text + "Area:-" + txtresult.Text + "\n";
            label6.Text = label6.Text + history;
            txtbase.Focus();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            GeometricCalculator f1 = new GeometricCalculator();
            f1.Show();
            this.Close();
        }
    }
}
