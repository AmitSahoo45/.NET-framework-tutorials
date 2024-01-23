using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Object_Initializer
{
    // initializer is simply a syntax or quickly initializing an object without the need to call one of its constructors
    // Well we do need that simply to avoid creating multiple constructors.
    // Imagine we have this person class with a bunch of fields.
    public class Person
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    /*
       For this class we need to write these constructors
        public Person(int id) { }
        public Person(int id, string fn) { }
        public Person(int id, string fn, string ln) { }
        public Person(int id, DateTime dt) { }

    there are so many different combs. this is messy.
    with object initializers we don't need these cons
    we can initialise them like this. 
    */

    internal class Initializer
    {
        static void Main(string[] args)
        {
            var psn1 = new Person { Id = 1, firstName = "Amit Kumar", lastName = "Sahoo", BirthDate = DateTime.Now };
            // this is how we use object initializers
            // we are not calling cons. notice the curly braces.
            // using this way we can reserve constructors for the scenarios where we really need to use them. 
            // So an object cannot behave without being passed some initial values.

        }
    }
}
