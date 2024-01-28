using System;
using System.Collections.Generic;

namespace IEnuExec
{
    // IEnumerable implementation
    public class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }

        public Dog(string name, bool isNaughty)
        {
            this.Name = name;
            this.IsNaughty = isNaughty;
        }

        public void giveTreat(int numberOfTreats)
        {
            Console.WriteLine("Giving {0} treats to {1}", numberOfTreats, this.Name);
        }
    }

    public class DogShelter : IEnumerable<Dog>
    // In dog shelter we have a list of dogs. 
    // In order to iterate through this list of dogs, we need to implement IEnumerable interface.
    // IEnumerable interface has only one method, which is GetEnumerator().
    // in the type parameter, we need to specify the type of the object that we want to iterate through.

    {
        public List<Dog> Dogs { get; set; }

        public DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog("Casper", true),
                new Dog("Scooby", false),
                new Dog("Browny", true),
                new Dog("Tommy", false),
                new Dog("Tuffy", true),
                new Dog("Spike", false)
            };
        }

        // this is the generic version of the GetEnumerator() method.
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return Dogs.GetEnumerator();
        }

        // this is the non-generic version of the GetEnumerator() method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // very imp note:
        // both the generic and non-generic versions of the GetEnumerator() method are required to implement IEnumerable interface.
        // if we don't implement both the versions, then we will get a compile time error.
        // potential question - implement one version of the GetEnumerator() method and see what happens.
    }


    // new example of IEnumerable
    class IEnumerableEg1
    {
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> queue = new Queue<int>() { 1, 2, 3, 4, 5 };

            switch (option)
            {
                case 1:
                    return list;
                case 2:
                    return queue;
                default:
                    return new int[] { 1, 2, 3, 4, 5 };
            }
            // here we can see it's return completely different type of collection.
            // each contains different values but it's just an entirely different thing. 
        }

        static void CollectionSum(IEnumerable<int> collection)
        {
            int sum = 0;

            foreach (var i in collection)
                sum += i;

            Console.WriteLine("Sum of collection is {0}", sum);
        }
    }

    internal class IEnuExec
    {
        static void Main(string[] args)
        {
            var shelter = new DogShelter();

            foreach (Dog d in shelter)
                if (d.IsNaughty)
                {
                    var rnd = new Random();
                    int numberOfTreats = rnd.Next(1, 10);
                    d.giveTreat(numberOfTreats);
                }
                else
                {
                    d.giveTreat(1);
                }

            IEnumerable<int> uknCollection = GetCollection(1);

            foreach (int i in uknCollection)
                Console.WriteLine(i);

            uknCollection = GetCollection(2);

            foreach (int i in uknCollection)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
};