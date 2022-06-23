﻿using System;
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
            Figure s = null;
            while (true)
            {
                
                FigureFall(out s, generator);
                s.Draw();
            }
            Console.ReadKey();
        }
        static void FigureFall(out Figure fig, FigureGenerator generator)
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
    }
}
