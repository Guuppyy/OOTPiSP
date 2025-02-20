using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Shape[] shapes = new Shape[]
            {
                new Line { Start = new Point(10, 10), End = new Point(100, 10) },
                new RectangleShape { Rect = new Rectangle(10, 20, 100, 50) },
                new EllipseShape { Rect = new Rectangle(10, 80, 100, 50) },
                new PolygonShape { Points = new Point[] { new Point(10, 150), new Point(60, 200), new Point(110, 150) } },
                new PolylineShape { Points = new Point[] { new Point(10, 220), new Point(50, 250), new Point(100, 220) } }
            };

            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}
