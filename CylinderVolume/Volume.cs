/*
 * Created by: Alex Mathias
 * Created on: 05-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-05
 * This program Calculates the volume of a cylinder from the radius and height.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CylinderVolume
{
    public partial class frmVolume : Form
    {
        public double Volume(double radius, double height)
        {
            double volume;
            volume = Math.PI * Math.Pow(radius,2) * height;

            return volume;
        }

        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            double radius;
            double height;
            double volume;

            //Input
            radius = Convert.ToDouble(this.txtRadius.Text);
            height = Convert.ToDouble(this.txtHeight.Text);

            //Process
            volume = Volume(radius, height);

            //Output
            this.lblVolume.Text = ("The volume of the cylinder is:" + Convert.ToString(volume));
        }
    }
}
