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
            Console.WriteLine();

            Console.WriteLine("Start Square: ");
            Square s1 = new Square(14, 3, '#');
            s1.Draw();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Start Stick: ");
            Stick st1 = new Stick(14, 6, '#');
            st1.Draw();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Start Figure: ");
            Figure[] farr = new Figure[2];
            farr[0] = new Square(14, 11, '@');
            farr[1] = new Stick(25, 11, '@');
            foreach (Figure f in farr)
            {
                f.Draw();
            }

            Console.ReadKey();
        }               
    }
}
