namespace CalculatorProject2
{
    partial class Area_of_trapezoid
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.TxtAreaofTrapezoid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(224, 273);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(361, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Base
            // 
            this.Base.AutoSize = true;
            this.Base.Location = new System.Drawing.Point(220, 70);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(40, 13);
            this.Base.TabIndex = 0;
            this.Base.Text = "&Base1:";
            this.Base.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Base.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Base2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Area of Trapezoid";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calculation History";
            // 
            // txtBase1
            // 
            this.txtBase1.Location = new System.Drawing.Point(336, 70);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(100, 20);
            this.txtBase1.TabIndex = 1;
            this.txtBase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(336, 113);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 20);
            this.txtBase2.TabIndex = 3;
            this.txtBase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(336, 161);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAreaofTrapezoid
            // 
            this.TxtAreaofTrapezoid.Location = new System.Drawing.Point(336, 212);
            this.TxtAreaofTrapezoid.Name = "TxtAreaofTrapezoid";
            this.TxtAreaofTrapezoid.ReadOnly = true;
            this.TxtAreaofTrapezoid.Size = new System.Drawing.Size(100, 20);
            this.TxtAreaofTrapezoid.TabIndex = 10;
            this.TxtAreaofTrapezoid.TabStop = false;
            this.TxtAreaofTrapezoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // Area_of_trapezoid
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAreaofTrapezoid);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Area_of_trapezoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_of_trapezoid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Base;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBase1;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox TxtAreaofTrapezoid;
        private System.Windows.Forms.Label label6;
    }
}