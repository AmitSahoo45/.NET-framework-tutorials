using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Constructors
{
    public class Order
    {

    }

    public class Customer
    {
        public int id;
        public string name;
        public int age;

        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        // it means that whenever this constrcutor will be called, it will first call and execute the constructor above it, which is the default constructor
        {
            this.id = id;
        }

        public Customer(int id, string name, int age)
            : this(id)
        // this will first call id cons, then the default cons
        {
            this.name = name;
            this.age = age;
        }

        // this kind of thing is not a good practice.
        // so don't try this in prod.

        // Static Constrcutors
        static int count;

        static Customer()
        {
            count = 0;
        }

        public static Customer getNewCustomer()
        {
            return new Customer();
        }
        // this method is the only means for external code to get a new thing

        // private Customer() { }
    }

    // some important points
    // this constructor can only be called from within the class
    // private constructors are used in class that contains only static members.
    // we use private cons when we only have static data members in a class. 
    // it is the implementation of a singleton class parent.
    // using private constructor prevents the creation of instances of that class. 
    /* If a class contains only private constructor without parameter, then it prevents the automatic generation of default constructor.
     * If a class contains only private constructors and does not contain public constructor, then other classes are not allowed to create instances of that class except nested class.
     */
    class ScuderiaFerrari
    {
        public static string driver;
        static string f1CarName;
        
        private ScuderiaFerrari()
        {
            Console.WriteLine("This is the private constructior");
        }

        public ScuderiaFerrari(string drv, string carName) {
            driver = drv;
            f1CarName = carName;
            // you cannot use this keyword here.
            // potential question - use this keyword and initialize it and ask what will be the output
        }
    }

    internal class ConsEg
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer();
            Console.WriteLine(cus1.name + " " + cus1.age);
            // the default values will be 0 and null for age and name.
            // as soon as you define a parameterized cons the compiler will no longer accept a default constructor. 
            // if we initialise it like new customer() whilist we have a parameterized constructor, this will throw error.
            // we dont want to pass any params them just define a default constructor.
            Customer cus2 = new Customer(123, "Amit", 21);
            Console.WriteLine(cus2.name + " " + cus2.id);

            Customer cus3 = new Customer();
            // what if we call cons2, then the orders list is not going to be initialized. 
            // this is a problem
            // therefore we are going to use the this keyword

        }
    }
}
