using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    // public class Canvas
    // {
    //     public void DrawShape(List<Shape> shapes)
    //     {
    //         foreach (var shape in shapes)
    //         {
    //             switch (shape.Type)
    //             {
    //                 case ShapeType.Circle:
    //                     Console.WriteLine("Draw a circle");
    //                     break;
    //                 
    //                 case ShapeType.Rectangle:
    //                     Console.WriteLine("Draw a rectangle");
    //                     break;
    //                 
    //                 case ShapeType.Triangle:
    //                     Console.WriteLine("Draw a triangle");
    //                     break;
    //             }
    //         }
    //     }
    // }

    public class Canvas
    {
        // Each list item of shapes is of type Shape or derives from Shape
        public void DrawShape(List<Shape> shapes)
        {
            // Each shape gets implicitly upcasted to the Shape class because it derives from it
            // If the class is all ready Shape there is no upcasting 
            foreach (var shape in shapes)
            {
                // At runtime the type of shape can be Shape, Circle, Rectangle or Triangle
                // When the method Draw() is executed, it gets called on the corresponding class 
                
                // For example:
                // instanceOfShape.Draw()
                // instanceOfCircle.Draw()
                // instanceOfRectangle.Draw()
                // instanceOfTriangle.Draw()
                
                // This is called polymorphism (poly=many, morphism=form)
                // Depending on the class at runtime we have different behavior
                shape.Draw();
            }
        }
    }
}