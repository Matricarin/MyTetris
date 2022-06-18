using System;
using MyTetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 50);
            Console.SetBufferSize(50, 50);

            Point[] points = new Point[3];
            points[0] = new Point(3, 3, '#');
            points[1] = new Point(3, 5, '#');
            points[2] = new Point(3, 7, '#');

            foreach (Point p in points)
            {
                p.Draw();
            }
            DrawSquare(5, 5, '#');

            Console.ReadKey();
        }
        static void DrawSquare(int x, int y, char c)
        {
            Point[][] square = new Point[2][];
            square[0] = new Point[2];
            square[1] = new Point[2];
            square[0][0] = new Point(x, y, c);
            square[0][1] = new Point(x, y + 1, c);
            square[1][0] = new Point(x + 1, y, c);
            square[1][1] = new Point(x + 1, y + 1, c);
            for (int i = 0; i < square.Length; i++)
            {
                for (int j = 0; j < square[i].Length; j++)
                {
                    square[i][j].Draw();
                }
            }
        }
    }
}
