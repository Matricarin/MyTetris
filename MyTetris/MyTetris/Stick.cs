using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    class Stick : Figure
    {
        public Stick(int x, int y, char c)
        {
            points[0] = new Point(x, y, c);
            points[1] = new Point(x, y + 1, c);
            points[2] = new Point(x, y + 2, c);
            points[3] = new Point(x, y + 3, c);
            Draw();
        }
        public override void Rotate()
        {
            if (points[0].X == points[1].X)
            {
                RotateHorizontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Y = points[0].Y + i;
                points[i].X = points[0].X;
            }
        }

        private void RotateHorizontal()
        {
            for (int i = 0; i <points.Length; i++)
            {
                points[i].X = points[0].X + i;
                points[i].Y = points[0].Y;
            }
        }
    }
}
