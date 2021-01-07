using System;

namespace MethodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Custom implementation
            Console.WriteLine("Draw a rectangle");
        }
    }
}