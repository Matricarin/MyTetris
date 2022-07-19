using System;
using System.Threading;

namespace MyTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tetris!");
            Field.Width = 100;
            Field.Height = 100;
            FigureGenerator generator = new FigureGenerator(25, 0, '#');
            Figure currentFigure = generator.GetNewFigure();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
            }
            Console.ReadKey();
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.Down);
                    break;
                case ConsoleKey.Spacebar:
                    currentFigure.TryRotate();                   
                    break;

                default:
                    break;
            }
        }
    }
}
