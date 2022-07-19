using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    static class Field
    {
        private static int _width = 10;
        private static int _height = 10;
        public static int Width 
        {
            get
            { return _width; } 
            set
            {
                _width = value;
                Console.SetWindowSize(value, Field.Height);
            }
        }
        public static int Height 
        {
            get
            { return _height; }
            set
            {
                _height = value;
                Console.SetWindowSize(Field.Width, value);
            }
        }      
    }
}
