using System;
using System.Collections.Generic;
using System.Text;

namespace ZXCHomeWork
{
    class NAngle
    {
        private int CountAngle { get; }
        public NAngle(int[] numbers)
        {
            CountAngle = numbers.Length;
        }
        private double GetRadius(int a)
        {
            return a / (2 * Math.Sin(Math.PI / CountAngle));
        }

        public double Square(int a)
        { 
            var radius = GetRadius(a);
            return (CountAngle / 2.0f) * Math.Pow(radius,2) * Math.Sin(2 * Math.PI / CountAngle);
        }

        public double Perimetr(int a)
        {
            return a * CountAngle;
        }
        public double Angle()
        {
            return (CountAngle - 2.0f) * 180 / CountAngle;
        }
    }
}
