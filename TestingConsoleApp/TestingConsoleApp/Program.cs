using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    class TestingClass
    {
        public int Add(string str, params int[] numbers)
        {
            var sum = 0;
            foreach (var i in numbers)
                sum += i;

            return sum;
        }

        public int AddFnc(ref int a, out int b)
        {
            a = 20, b = 80;

            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var tscls = new TestingClass();
            // Console.WriteLine(tscls.Add("Hello", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            int a = 80, b = 20;
            Console.WriteLine(tscls.AddFnc(ref a, out b));
            Console.WriteLine(a); Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
