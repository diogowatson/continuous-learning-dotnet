using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_5
{
    struct Rectangle
    {
        public double lenght;
        public double width;

        public Rectangle(double l = 1,
            double w = 1)
        {
            lenght = l;
            width = w;
        }

        public double Area()
        {
            return lenght * width;
        }
    }
}
