/*
 * Created by: Jadon F
 * Created on: 14-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Volume of a Cylinder
 * This program calculates the volume of a cylinder
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

namespace VolumeOfCylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calculateVolume(double radius, double height)
        {
            //local variables
            double volume;
            double faceArea;

            //constants
            const double PI = 3.14;

            //calculate
            faceArea = PI * Math.Pow(radius, 2);
            volume = faceArea * height;

            //message box
            MessageBox.Show("The volume is " + volume + " units squared.", "Volume of a Cylinder");
        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            double userRadius;
            double userHeight;

            //assign variables
            userRadius = Convert.ToDouble(txtRadius.Text);
            userHeight = Convert.ToDouble(txtHeight.Text);

            //call calculateVolume
            calculateVolume(userRadius, userHeight);

        }
    }
}
