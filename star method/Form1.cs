using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            Star(22, 17, 1, 14, 9, 22, 34, 30, 43, 27, 1, 16,16, 26, 40, 32, 40, 26, 16, 16, blackPen, 15);
        }
        public void Star(float x1, float x2, float x3, float x4, float x5, float x6, float x7, float x8, float x9, float x10, float y1, float y2, float y3, float y4, float y5, float y6, float y7, float y8, float y9, float y10, Pen pen, float z)
        {
            Graphics g = CreateGraphics();
            float q1 = z * x1, q2 = z * x2, q3 = z * x3, q4 = z * x4, q5 = z * x5, q6 = z * x6, q7 = z * x7, q8 = z * x8, q9 = z * x9, q10 = z * x10;
            float r1 = z * y1, r2 = z * y2, r3 = z * y3, r4 = z * y4, r5 = z * y5, r6 = z * y6, r7 = z * y7, r8 = z * y8, r9 = z * y9, r10 = z * y10;
            g.DrawLine(pen, q1, r1, z * x2, z*y2+0);
            g.DrawLine(pen, q2, r2, q3, r3);
            g.DrawLine(pen, q3, r3, q4, r4);
            g.DrawLine(pen, q4, r4, q5, r5);
            g.DrawLine(pen, q5, r5, q6, r6);
            g.DrawLine(pen, q6, r6, q7, r7);
            g.DrawLine(pen, q7, r7, q8, r8);
            g.DrawLine(pen, q8, r8, q9, r9);
            g.DrawLine(pen, q9, r9, q10, r10);
            g.DrawLine(pen, q10, r10, q1, r1);
        }
    }
}
