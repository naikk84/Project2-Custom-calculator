namespace CalculatorProject2
{
    partial class GeometricCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAreaTrapezoid = new System.Windows.Forms.Button();
            this.btnAreaRectangle = new System.Windows.Forms.Button();
            this.btnAreaTriangle = new System.Windows.Forms.Button();
            this.btnAreaCylinder = new System.Windows.Forms.Button();
            this.btnAreaParallelogram = new System.Windows.Forms.Button();
            this.btnAreaEllipse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerimeterRectangle = new System.Windows.Forms.Button();
            this.btnPerimeterTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Of Geometric Shape";
            // 
            // btnAreaTrapezoid
            // 
            this.btnAreaTrapezoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaTrapezoid.Location = new System.Drawing.Point(289, 75);
            this.btnAreaTrapezoid.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaTrapezoid.Name = "btnAreaTrapezoid";
            this.btnAreaTrapezoid.Size = new System.Drawing.Size(238, 30);
            this.btnAreaTrapezoid.TabIndex = 1;
            this.btnAreaTrapezoid.Text = "Area of trapezoid ";
            this.btnAreaTrapezoid.UseVisualStyleBackColor = true;
            this.btnAreaTrapezoid.Click += new System.EventHandler(this.txtAreaTrapezoid_Click);
            // 
            // btnAreaRectangle
            // 
            this.btnAreaRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaRectangle.Location = new System.Drawing.Point(289, 110);
            this.btnAreaRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaRectangle.Name = "btnAreaRectangle";
            this.btnAreaRectangle.Size = new System.Drawing.Size(238, 29);
            this.btnAreaRectangle.TabIndex = 2;
            this.btnAreaRectangle.Text = "Area of rectangle ";
            this.btnAreaRectangle.UseVisualStyleBackColor = true;
            this.btnAreaRectangle.Click += new System.EventHandler(this.btnAreaRectangle_Click);
            // 
            // btnAreaTriangle
            // 
            this.btnAreaTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaTriangle.Location = new System.Drawing.Point(289, 144);
            this.btnAreaTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaTriangle.Name = "btnAreaTriangle";
            this.btnAreaTriangle.Size = new System.Drawing.Size(238, 28);
            this.btnAreaTriangle.TabIndex = 3;
            this.btnAreaTriangle.Text = "Area of triangle ";
            this.btnAreaTriangle.UseVisualStyleBackColor = true;
            // 
            // btnAreaCylinder
            // 
            this.btnAreaCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaCylinder.Location = new System.Drawing.Point(289, 176);
            this.btnAreaCylinder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaCylinder.Name = "btnAreaCylinder";
            this.btnAreaCylinder.Size = new System.Drawing.Size(238, 28);
            this.btnAreaCylinder.TabIndex = 4;
            this.btnAreaCylinder.Text = "Area of cylinder ";
            this.btnAreaCylinder.UseVisualStyleBackColor = true;
            // 
            // btnAreaParallelogram
            // 
            this.btnAreaParallelogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaParallelogram.Location = new System.Drawing.Point(289, 210);
            this.btnAreaParallelogram.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaParallelogram.Name = "btnAreaParallelogram";
            this.btnAreaParallelogram.Size = new System.Drawing.Size(238, 34);
            this.btnAreaParallelogram.TabIndex = 5;
            this.btnAreaParallelogram.Text = "Area of parallelogram ";
            this.btnAreaParallelogram.UseVisualStyleBackColor = true;
            // 
            // btnAreaEllipse
            // 
            this.btnAreaEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaEllipse.Location = new System.Drawing.Point(289, 249);
            this.btnAreaEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.btnAreaEllipse.Name = "btnAreaEllipse";
            this.btnAreaEllipse.Size = new System.Drawing.Size(238, 32);
            this.btnAreaEllipse.TabIndex = 6;
            this.btnAreaEllipse.Text = "Area of ellipse ";
            this.btnAreaEllipse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Perimeter of Geometric Shapes";
            // 
            // btnPerimeterRectangle
            // 
            this.btnPerimeterRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeterRectangle.Location = new System.Drawing.Point(289, 326);
            this.btnPerimeterRectangle.Name = "btnPerimeterRectangle";
            this.btnPerimeterRectangle.Size = new System.Drawing.Size(238, 35);
            this.btnPerimeterRectangle.TabIndex = 8;
            this.btnPerimeterRectangle.Text = "Perimeter of Rectangle";
            this.btnPerimeterRectangle.UseVisualStyleBackColor = true;
            // 
            // btnPerimeterTriangle
            // 
            this.btnPerimeterTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeterTriangle.Location = new System.Drawing.Point(289, 367);
            this.btnPerimeterTriangle.Name = "btnPerimeterTriangle";
            this.btnPerimeterTriangle.Size = new System.Drawing.Size(238, 32);
            this.btnPerimeterTriangle.TabIndex = 9;
            this.btnPerimeterTriangle.Text = "Perimeter of Triangle";
            this.btnPerimeterTriangle.UseVisualStyleBackColor = true;
            // 
            // GeometricCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerimeterTriangle);
            this.Controls.Add(this.btnPerimeterRectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAreaEllipse);
            this.Controls.Add(this.btnAreaParallelogram);
            this.Controls.Add(this.btnAreaCylinder);
            this.Controls.Add(this.btnAreaTriangle);
            this.Controls.Add(this.btnAreaRectangle);
            this.Controls.Add(this.btnAreaTrapezoid);
            this.Controls.Add(this.label1);
            this.Name = "GeometricCalculator";
            this.Text = "Geometric Calculator";
            this.Load += new System.EventHandler(this.GeometricCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAreaTrapezoid;
        private System.Windows.Forms.Button btnAreaRectangle;
        private System.Windows.Forms.Button btnAreaTriangle;
        private System.Windows.Forms.Button btnAreaCylinder;
        private System.Windows.Forms.Button btnAreaParallelogram;
        private System.Windows.Forms.Button btnAreaEllipse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPerimeterRectangle;
        private System.Windows.Forms.Button btnPerimeterTriangle;
    }
}