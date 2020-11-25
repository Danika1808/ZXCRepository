using System;
using System.Collections.Generic;
using System.Text;

namespace ZXCHomeWork
{
    class NAngle
    {
        private int Count { get; }
        private double Length { get; }
        public NAngle(int count, double length = double.NaN)
        {
            if (double.IsNaN(length))
            {
                Console.WriteLine("Введите длину стороны, а то забыли :)");
                length = double.Parse(Console.ReadLine());
            }
            Count = count;
            Length = length;
        }
        public NAngle(double length, int count = 0)
        {
            if (count == 0)
            {
                Console.WriteLine("Введите количество сторон, а то забыли :)");
                count = int.Parse(Console.ReadLine());
            }
            Count = count;
            Length = length;
        }
        private double GetRadius()
        {
            return Length / (2 * Math.Sin(Math.PI / Count));
        }

        public double Square()
        {
            var radius = GetRadius();
            return (Count / 2.0f) * Math.Pow(radius,2) * Math.Sin(2 * Math.PI / Count);
        }

        public double Perimetr()
        {
            return Length * Count;
        }
        public double Angle()
        {
            return (Count - 2.0f) * 180 / Count;
        }
    }
}
