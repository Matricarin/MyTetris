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
            Figure s = new Square(25, 20, '#');
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Left);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Right);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Down);
            s.Draw();

            Console.ReadKey();
        }               
    }
}
