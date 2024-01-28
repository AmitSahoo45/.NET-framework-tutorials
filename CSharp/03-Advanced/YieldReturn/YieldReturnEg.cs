using System;
using System.Collections.Generic;

namespace YieldReturn
{
    class YieldReturnEg
    {
        public static IEnumerable<string> _plants = new[] { "Apple", "Pear", "Sunflower", "Carrot" };
        public static IEnumerable<string> GetFruits()
        {
            var result = new List<string>();

            foreach (var p in _plants)
                if (p == "Apple" || p == "Pear")
                    result.Add(p);

            return result;
        }

        public static IEnumerable<string> GetFruitsYield()
        {
            foreach (var p in _plants)
                if (p == "Apple" || p == "Pear")
                    yield return p;
        }
    }

    class Program
    {
        static public void Main(string[] args)
        {

            Console.WriteLine("Using GetFruits");
            foreach (var f in YieldReturnEg.GetFruits())
                Console.WriteLine(f);

            Console.WriteLine("Using GetFruitsYield");
            foreach (var f in YieldReturnEg.GetFruitsYield())
                Console.WriteLine(f);
        }
    }
}
