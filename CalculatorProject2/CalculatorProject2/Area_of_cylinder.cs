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
    public partial class Area_of_Cylinder : Form
    {
        public Area_of_Cylinder()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            decimal h = Convert.ToDecimal(txtheight.Text);

            decimal r = Convert.ToDecimal(txtradius.Text);

            decimal area;


            area = (((2*22*h)/7)+((2*22*r)/7));

            txtarea.Text = area.ToString();
            string history = "Height:-" + txtheight.Text + "Radius:-" + txtradius.Text + "Area:-" + txtarea.Text + "\n";
            label5.Text = label5.Text + history;
            txtheight.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GeometricCalculator f1 = new GeometricCalculator();
            f1.Show();
            this.Close();
        }
    }
}
