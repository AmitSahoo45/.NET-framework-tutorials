using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // if we don't override the abstract method, we will get an error
    // potential question: what if we don't want to override the abstract method? What will be the result?

    internal class Program
    {
        static void Main(string[] args)
        {
            // var shape = new Shape();
            // this is illegal
            // this wont work
            // don't declare anything like this

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}   