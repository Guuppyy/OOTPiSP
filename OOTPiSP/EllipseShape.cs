using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP
{
    public class EllipseShape : Shape
    {
        public Rectangle Rect { get; set; }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, Rect);
        }
    }
}
