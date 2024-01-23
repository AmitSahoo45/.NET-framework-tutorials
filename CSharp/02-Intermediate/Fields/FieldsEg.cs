using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Fields
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // List<Order> orders = new List<Order>();
        // some devs don't like this approach, but it is all a personal choice. 
        // therefore we can declare it as
        readonly List<Order> orders = new List<Order>();

        // public Person()
        // {
        // orders = new List<Order>();
        // here there is a problem.
        // we are initializing a variable without passing any data from outside, which is kind of a wrong practice.
        // so we can get rid of this cons. 
        // and initialize it outside
        // }

        public Person(int id)
        {
            this.Id = id;
        }

        public Person(int id, string name, string description)
        : this(id)
        {
            this.Name = name;
            this.Description = description;
        }

        public void Promote()
        {
            // what if we accidentally reinitialize the orders here??
            // that will be a huge problem
            // in situations where you know this field should only be initialized once.
            // potential question - forcefully try to re initialise a readonly var to compiler time error
            // ......
        }
    }

    internal class FieldsEg
    {
    }
}
