using System;
using System.Collections.Generic;
using System.Text;

namespace ZXCHomeWork
{
    class NAngle
    {
        /// <summary>
        /// Количество сторон
        /// </summary>
        private int Count { get; }
        /// <summary>
        /// Длина стороны
        /// </summary>
        private double Length { get; }
        /// <summary>
        /// Конструктор класса n-угольника
        /// </summary>
        /// <param name="count">Количество сторон</param>
        /// <param name="length">Длина сторон</param>
        public NAngle(int count, double length = 0.0)
        {
            if (length == 0.0)
            {
                Console.WriteLine("Введите длину стороны, а то забыли :)");
                length = double.Parse(Console.ReadLine());
            }
            Count = count;
            Length = length;
        }
        /// <summary>        
        /// Конструктор класса n-угольника 
        /// </summary>
        /// <param name="length">Количество сторон</param>
        /// <param name="count">Длина сторон</param>
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
        /// <summary>
        /// Получить радиус
        /// </summary>
        /// <returns>Радиус</returns>
        private double GetRadius()
        {
            return Length / (2 * Math.Sin(Math.PI / Count));
        }
        /// <summary>
        /// Нахождение площади
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare()
        {
            var radius = GetRadius();
            return (Count / 2.0f) * Math.Pow(radius,2) * Math.Sin(2 * Math.PI / Count);
        }
        /// <summary>
        /// Нахождение периметр
        /// </summary>
        /// <returns>Периметр</returns>
        public double GetPerimetr()
        {
            return Length * Count;
        }
        /// <summary>
        /// Нахождение угла
        /// </summary>
        /// <returns>Угол</returns>
        public double GetAngle()
        {
            return (Count - 2.0f) * 180 / Count;
        }
    }
}
