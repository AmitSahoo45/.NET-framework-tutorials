using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    internal class GenericExample
    {

        public static void Exec()
        {
            Console.WriteLine(returnMini(3, 5) + " is bigger");
            Console.WriteLine(returnMini(3.5, 4.5) + " is bigger");
            Console.WriteLine(returnMini("amit", "amita") + " is bigger");
            // hover over the returnmini() and you will se it type has already been inferred. 
            // this is done by compiler and called as type inference. 
            // so it is not required to type data type

            Console.WriteLine(returnMini<int>(1, 2) + " is bigger"); // *1

            // Console.WriteLine(returnMini("amit", 200));
            // this will throw an arguement exception. runtime error. 
            // compiler does not checks for this. 
            // we will solve this using generic. 
            // telling the compiler check this using compile time only
            // returnMini<string>(200, "500") -> this will throw error.
            // the compiler will tell you to fuck off.
        }

        #region integer specific
        /*
        static int returnMinimum(int a, int b)
        {
            return a < b ? a : b;
        }
        */
        #endregion


        /*
         * I want to have a similar scenario for double. 
         * But I can't do it here?? I have to do it again via overloading 
         * Hence making it code redundant as what if we want to have it for float, double, int, string, etc......
         * If you try doing it using object, then it wont work. 
         * If you would do object reference like this
         */
        //static object returnMinimum(object a, object b)
        //{
        //    return a < b ? a : b;
        //}

        // SO they brought a method called Icomparable. 
        // the compareTo method is developed. 

        /*
        static IComparable returnMini(IComparable a, IComparable b)
        {
            return (a.CompareTo(b) < 0 ? a : b);
            // if a is less than 0 then we will get a else b
        }
        */

        static T returnMini<T>(T a, T b) where T : IComparable<T>
        {
            return (a.CompareTo(b) < 0 ? a : b);
        }
        // here T will be an object, but when we place where T:IComparable<T>, it tells to reduce the scope to I comparable.
        // T is also an object. And an object will never have COmpareTo. So that's why we are adding it telling the compiler that 
        // rather than taking the T as an object, it will take it as a comparible. 
        // in the above if we do 

        // T is a naming convention mentioning the type. 
        // it is just a place holder
        // *1 if we write in this way, then we will we are defining the T which we have here - "static T"
        // we are saying it's return type will be int. 
        // if we had already pre - defined it as int, then no need to pass it as "returnMini<int>(1,2)"
        // because the return type is already assigned as int. 

        /*
        static int returnMiniInt(T a, T b) where T : IComparable<T>
        {
            return (a.CompareTo(b) > 0 ? a : b);
        }
        */
        /*
         * this kind of implementation doesn't make sense. 
         * better to this
         * static int ReturnMinInt(int a, int b)
            {
                return a < b ? a : b;
            }
        */

        // this doing at the time of JIT Compilation. or at the run time. 
        // fillers - search for JIT compilation or ask for referrence. 

        static TReturn GenSynTaxEg<T1, T2, TReturn>(T1 a, T2 b)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2> // or class if you are passing a class
            where TReturn : new()
            // where TReturn: class, new()
            // general can be applied to class or method lvl - delegate and interface is class lvl and it can be applied. 
            // so does index and prop. 
        {
            TReturn obj = new TReturn();
            return default(TReturn);
        }
    }

    class GenericClassEg<T>
    {
        public GenericClassEg()
        {
            T a = default(T);
        }
        /*
            default(T) is used to get the default value of a type T. 
            The default value depends on whether T is a value type or a reference type.
         */
    }
}