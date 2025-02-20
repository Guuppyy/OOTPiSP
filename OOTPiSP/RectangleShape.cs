using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP
{
    public class RectangleShape : Shape
    {
        public Rectangle Rect { get; set; }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Rect);
        }
    }
}
