using System;
using System.Threading;

namespace MyTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work with GitHub!");
            Console.SetWindowSize(50, 40);
            Console.SetBufferSize(50, 40);
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
                    currentFigure.Move(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.Move(Direction.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.Move(Direction.Down);
                    break;
                
                default:
                    break;
            }
        }
    }
}
