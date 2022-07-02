using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day19_01
{
    public partial class Form1 : Form
    {
        Point[] pt;
        int cnt=0;
        public Form1()
        {
            InitializeComponent();

            pt = new Point[30];
        }

        /*
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < cnt; i++)
            {
                e.Graphics.DrawEllipse(Pens.Black, pt[i].X - 15, pt[i].Y - 15, 30, 30);
            }
        }
        */

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pt[cnt].X = e.X;
            pt[cnt].Y = e.Y;
            
            //===================================================== GDI를 활용하여 Form1_Paint와 같은 구문 작성한 부분
            Graphics graphics = CreateGraphics();
            graphics.DrawEllipse(Pens.Black, pt[cnt].X - 15, pt[cnt].Y - 15, 30, 30);
            graphics.Dispose();     //자원 해제하는 부분
            //=======================================================

            cnt++;
            //Invalidate();      
        }
    }
}
