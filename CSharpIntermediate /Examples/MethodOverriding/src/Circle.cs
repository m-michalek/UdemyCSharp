using System;

namespace MethodOverriding
{
    public class Circle: Shape
    {
        public override void Draw()
        {
            // Custom implementation
            Console.WriteLine("Draw a circle");
        }
    }
}