using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];
      
        public void Draw()
        {
           foreach (Point p in Points)
           {
                p.Draw();
           }                   
        }

        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate();

        internal Result TryRotate()
        {
            Hide();
            Rotate();

            var result = VerifyPosition();
            if (result == Result.SUCCEESS)
                Rotate();
            Draw();
            return result;
        }
        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }

        public void Move(Direction dir)
        {
            foreach (var p in Points)
            {
                p.Move(dir);
            }
        }

        internal Result TryMove(Direction dir)
        {
            Hide();
            Move(dir);
          
            var  result = VerifyPosition();
            if (result == Result.SUCCEESS)
                Move(Reverse(dir));
            
            Draw();
            return result;
        }

        private Direction Reverse(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    return Direction.Right;
                case Direction.Right:
                    return Direction.Left;
                case Direction.Down:
                    return Direction.Up;
                case Direction.Up:
                    return Direction.Down;
            }
            return dir;
        }

        private Result VerifyPosition()
        {
            foreach (var p in Points)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;
                if(p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCEESS;
        }          
    }
}
