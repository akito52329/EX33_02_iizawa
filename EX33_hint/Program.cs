using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(10, 10);
            RectAngle rectAngle2 = new RectAngle(10, 10);
            var rectAngle3 = rectAngle1 + rectAngle2;
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }

            Console.WriteLine($"{rectAngle3.height}*{rectAngle3.width}={rectAngle3.height * rectAngle3.width}");
        }
    }
}
