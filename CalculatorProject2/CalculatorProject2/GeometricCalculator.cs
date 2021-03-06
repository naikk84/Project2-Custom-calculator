﻿using System;
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
            Area_of_trapezoid f4 = new Area_of_trapezoid();
            f4.Show();
            Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAreaParallelogram_Click(object sender, EventArgs e)
        {
            AreaofParallelogram form = new AreaofParallelogram();
            form.Show();
            Visible = false;
        }

        private void btnAreaEllipse_Click(object sender, EventArgs e)
        {
            AreaofEllipse f1 = new AreaofEllipse();
            f1.Show();
            Visible = false;
        }

        private void btnAreaTriangle_Click(object sender, EventArgs e)
        {
            Area_of_triangle f2 = new Area_of_triangle();
            f2.Show();
            Visible = false;
        }

        private void btnAreaCylinder_Click(object sender, EventArgs e)
        {
            Area_of_Cylinder f3 = new Area_of_Cylinder();
            f3.Show();
            Visible = false;
        }

        private void btnAreaRectangle_Click(object sender, EventArgs e)
        {
            AreaofRectangle f5 = new AreaofRectangle();
            f5.Show();
            Visible = false;
        }

        private void btnPerimeterRectangle_Click(object sender, EventArgs e)
        {
            Perimeter_of_Rectangle f6 = new Perimeter_of_Rectangle();
            f6.Show();
            Visible = false;
        }

        private void btnPerimeterTriangle_Click(object sender, EventArgs e)
        {
            Perimeter_of_triangle f7 = new Perimeter_of_triangle();
            f7.Show();
            Visible = false;
        }
    }
}
