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
            Figure fig;
            while (true)
            {
                fig = generator.GetNewFigure();
                fig.Draw();
                for (int i = 0; i < 15; i++)
                {
                    Thread.Sleep(200);
                    fig.Hide();
                    fig.Move(Direction.Down);
                    fig.Draw();
                }

            }


            Console.ReadKey();
        }        
    }
}
