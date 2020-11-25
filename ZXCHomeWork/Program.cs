using System;

namespace ZXCHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var nAngle = new NAngle(n, a);
            Console.WriteLine($"Площадь равна = {nAngle.Square()}");
            Console.WriteLine($"Периметр равен = {nAngle.Perimetr()}");
            Console.WriteLine($"Угол n-угольника равен = {nAngle.Angle()}");
        }
    }
}
