namespace CylinderVolume
{
    partial class frmVolume
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(13, 13);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(168, 13);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter the radius and height below:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(13, 84);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 147);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(112, 76);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(112, 139);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(165, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(16, 187);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(145, 13);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "The volume of the cylinder is:";
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmVolume";
            this.Text = "Cylinder Volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVolume;
    }
}

