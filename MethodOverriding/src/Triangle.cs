using System;

namespace MethodOverriding
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Custom implementation
            Console.WriteLine("Draw a triangle");
        }
    }
}