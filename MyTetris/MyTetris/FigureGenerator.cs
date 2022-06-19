using System;

namespace MyTetris
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _sym;

        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _sym = c;
        }
        Random rnd = new Random();
        internal Figure GetNewFigure()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return new Square(_x, _y, _sym);
            }
            else
            {
                return new Stick(_x, _y, _sym);
            }
        }
    }
}