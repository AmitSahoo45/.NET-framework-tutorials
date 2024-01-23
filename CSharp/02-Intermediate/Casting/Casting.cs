using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw() { }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }

    public class Circle : Shape
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = circle; // Upcasting

            // No conversion is required
            // it is implicit.

            Circle anotherCircle = (Circle)shape; // Downcasting 
            // we do explicit casting.
            // casting can throw an invalid cast exception.
            // if we try to cast a shape to a text class or any other class that is not related to shape class.
            // then it will throw error
            // to prevent this we can use as keyword.

            Text text = new Text();
            Shape shape1 = text;
            // there will be no error here because text is a shape.
            // we can implicitly cast a text to a shape.
            // text and shape are references to the same object in memory.

            // if we do text. we will see all the members of text class and shape class.
            // but if we do shape1. we will only see the members of shape class.    

            text.Width = 200;
            shape1.Width = 100;

            Console.WriteLine(text.Width); // 100
            // why did it print 100?
            // because both text and shape1 are references to the same object in memory.
            // so when we change the width of shape1 it will also change the width of text.
            // because they are both pointing to the same object in memory.
            // what's the point of converting a object reference to a base class reference?
            // this is what polymorphism is all about.
            // potential question: play with values and make them confuse.

            var list = new ArrayList();
            list.Add(text);
            // object is the parent of all classes in .net framework.
            list.Add(shape1);
            list.Add(1);
            list.Add("Mosh");

            // this is not type safe as we can add any type of object to this list.
            // better use generics list

            var anotherList = new List<Shape>();
            // this is all about Upcasting.


            // ---------------------------------------------------------------------------------------
            // Downcasting

            Shape shape2 = new Text();
            // At compile time, it's object is Shape, but at runtime it's object is Text.
            // problem is when we type shape. we will see limited view. we will only see the members of shape class.
            // to access the members of text class we need to downcast it.
            Text text2 = (Text)shape2;
            // this is not safe because shape2 can be any shape.

            // why downcasting?
            // let's say we have a method that accepts a shape object.
            // we can pass a text object to this method because text is a shape.
            // but inside this method we want to access the members of text class.
            // so we need to downcast it.
            shape2.Width = 200;
            text2.FontName = "Arial";
            // this is not safe because shape2 can be any shape.
            // so we need to check if shape2 is a text or not.
            // we can do this by using the is keyword.
            // is keyword returns true if the object is compatible with the given type.
            if (shape2 is Text)
            {
                Text text3 = (Text)shape2;
                Console.WriteLine(text3.FontName);
            }
            else Console.WriteLine("shape2 is not a text");

            // another way to do this is by using as keyword.
            // as keyword returns null if the object is not compatible with the given type.
            Text text4 = shape2 as Text;

            if (text4 != null)
                Console.WriteLine(text4.FontName);
            else
                Console.WriteLine("shape2 is not a text");

            // important questions: create and jumble up some questions using as and is keyword.
        }
    }
}