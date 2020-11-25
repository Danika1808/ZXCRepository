using System;

namespace ZXCHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                numbers[i] = a;
            }
            var nAngle = new NAngle(numbers);
            Console.WriteLine($"Площадь равна = {nAngle.Square(a)}");
            Console.WriteLine($"Периметр равен = {nAngle.Perimetr(a)}");
            Console.WriteLine($"Угол {n}-угольника равен = {nAngle.Angle()}");
        }
    }
}
