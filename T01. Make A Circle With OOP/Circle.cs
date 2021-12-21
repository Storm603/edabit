using System;
using System.Collections.Generic;
using System.Text;

namespace T01._Make_A_Circle_With_OOP
{
    class Circle
    {
        private double _radius;
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

    }
}
