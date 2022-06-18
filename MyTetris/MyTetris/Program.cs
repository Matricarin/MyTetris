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

            Point p2 = new Point(3, 9, '#');
            p2.Draw();
            Point p3 = new Point()
            {
                X = 5,
                Y = 8,
                Sym = '#'
            };
            p3.Draw();

            Console.ReadKey();
        }               
    }
}
