/**
Author: Sandy Chau
Date: January 30, 2016
Description: This application will allow user to draw a circle, triangle, and 
             rectangle with the push of a button.
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


namespace Program1
{
    public partial class Form1 : Form
    {

        System.Drawing.Graphics formGraphics;


        public Form1()
        {
            InitializeComponent();
           // canvas.SetBounds(10, 100, 75, 75);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(20, 100, 75, 75);

            Pen pen = new Pen(Color.Red);
           
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen, rect);
            
            pen.Dispose();
            formGraphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle circle = new Rectangle(125, 100, 75, 75);

            Pen pen = new Pen(Color.Green);

            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(pen, circle);
            pen.Dispose();
            formGraphics.Dispose();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point pt1 = new Point(270, 100);
            Point pt2 = new Point(220, 170);
            Point pt3 = new Point(320, 170);
            Point[] vertices = { pt1, pt2, pt3 };

            Pen pen = new Pen(Color.Blue);
           
            formGraphics = this.CreateGraphics();
            formGraphics.DrawPolygon(pen, vertices);
            pen.Dispose();
            formGraphics.Dispose();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
