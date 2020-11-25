using System;

namespace ZXCHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var nAngle = new NAngle(n,a);

            Console.WriteLine($"Площадь равна = {nAngle.GetSquare()}");
            Console.WriteLine($"Периметр равен = {nAngle.GetPerimetr()}");
            Console.WriteLine($"Угол n-угольника равен = {nAngle.GetAngle()}");
        }
    }
}
