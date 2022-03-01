using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(10, 5);
            RectAngle rectAngle2 = new RectAngle(5, 3);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }

            Console.WriteLine($"{rectAngle1 + rectAngle2}");
        }
    }
}
