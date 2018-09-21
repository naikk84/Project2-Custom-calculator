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
    public partial class GeometricCalculator : Form
    {
        public GeometricCalculator()
        {
            InitializeComponent();
        }

        private void GeometricCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtAreaTrapezoid_Click(object sender, EventArgs e)
        {

        }

        private void txtAreaTriangle_Click(object sender, EventArgs e)
        {
            Area_of_triangle f1 = new Area_of_triangle();
            f1.Show();
            Visible = false;

        }

        private void btnAreaCylinder_Click(object sender, EventArgs e)
        {
            Area_of_Cylinder f2 = new Area_of_Cylinder();
            f2.Show();
            Visible = false;

        }
    }
}
