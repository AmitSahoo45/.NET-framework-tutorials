using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Methods
{
    public class SIgnatures
    {
        public int Add(int x, int y) { return x + y; }

        public void Collaborate(int x, int y) { }
        public void Collaborate(double x, int y, string s) { }
        public void Collaborate(string x, string y) { }
    }

    public class Calculator
    {
        // public int Add(int n1, int n2) { return n1 + n2; }
        // public int Add(int n1, int n2, int n3) { return n1 + n2 + n3; }
        // public int Add(int n1, int n2, int n3, int n4) { return n1 + n2 + n3 + n4; }

        public int Add(int[] arr) { return 1; }

        public int Total(params int[] arr) { return arr.Length; }
    }

    public class RefModifier
    {
        public void testMethod(int a)
        {
            a += 2;
        }

        public void refMethod(ref int a)
        {
            a += 2;
        }
    }

    public class OutModifier
    {
        public int returnOut(out int a)
        {
            a = 10;
            return a;
        }
    }

    internal class MethodsEg
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var res = calc.Add(new int[] { 1, 2, 3 });
            var newRes = calc.Total(1, 2, 3, 4);

            var refMod = new RefModifier();
            int a = 1;
            refMod.refMethod(ref a);

            Console.WriteLine(a);
        }
    }

    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }
    }

    class CalculatorNew
    {
        public int Add(params int[] nums)
        {
            var sum = 0;

            foreach (int i in nums)
                sum += i;

            return sum;
        }

        static void Main(String[] args)
        {
            CalculatorNew calc = new CalculatorNew();
            calc.Add(new int[] { 1, 2, 3 });
            // or 
            calc.Add(1, 2, 3, 4, 6, 7);
        }
    }
}
