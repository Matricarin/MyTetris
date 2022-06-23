using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    public class Point
    {
        public int X { get; set;}
        public int Y { get; set;}
        public char Sym { get; set;}
        
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }
        public Point() { }
        public Point(int x, int y, char c)
        {
            this.X = x;
            this.Y = y;
            this.Sym = c;
        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    X--;
                    break;
                case Direction.Right:
                    X++;
                    break;
                case Direction.Down:
                    Y++;
                    break;
            }
        }
    }
}
