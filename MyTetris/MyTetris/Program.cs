using System;

namespace MyTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work with GitHub!");
            Console.SetWindowSize(50, 40);
            Console.SetBufferSize(50, 40);
            
            Point p1 = new Point();
            p1.X = 5;
            p1.Y = 10;
            p1.Sym = '#';
            p1.Draw();

            Console.ReadKey();
        }               
    }
}
