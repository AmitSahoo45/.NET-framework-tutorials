using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding
{
    enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle
    }

    public class Position
    {
        public int x;
        public int y;
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
                shape.Draw();

            // we iterate through the list of shapes and call the draw method on each shape.   
            // when we call this Draw() from here, the Draw() method in the Shape class is called.
            // that might be a Rectangle, Circle or Triangle.
            // this is called polymorphism.
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ShapeType type { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // this is a reference to the parent class.
            // base.Draw();
            // before this we can write any logic and pass the result to method of our parent class.
            // potential question: Write some logic, pass it to parent class process it and return the result.
            base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            // we can create a list of shapes and add different shapes to it.
            // we can add a circle, rectangle or triangle to it.
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}