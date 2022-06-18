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

            Console.WriteLine("Start Point: ");
            Point p1 = new Point(14, 1, '#');
            p1.Draw();
            Console.WriteLine();
            Console.WriteLine("Start Square: ");
            Square s1 = new Square(14, 2, '#');
            s1.Draw();
            Console.WriteLine();


            Console.ReadKey();
        }               
    }
}
