using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment02PD
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int _length, int _width)
        {
            this.length = _length;
            this.width = _width;

        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int _length)
        {
            this.length = _length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int _width)
        {
            this.width = _width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return (length + width) * 2;
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
