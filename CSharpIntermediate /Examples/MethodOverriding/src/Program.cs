using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // var shapes = new List<Shape>();
            // shapes.Add(new Shape {Width = 100, Height = 100, Type = ShapeType.Circle} );
            // shapes.Add(new Shape {Width = 100, Height = 30, Type = ShapeType.Rectangle} );
            //
            // var canvas = new Canvas();
            // canvas.DrawShape(shapes);

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            
            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}