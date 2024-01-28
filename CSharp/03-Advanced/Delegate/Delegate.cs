using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    internal class DelegateEG
    {
        delegate int DelegateDemo(int a, int b);
        delegate void DlgDisplay(string a);
        /// <summary>
        /// here int int int is the sohnature 
        /// it is pointing to this specific signature. 
        /// </summary>



        public static void Exec()
        {
            DelegateDemo fptr = new DelegateDemo(Add);
            fptr += Multiply;
            //fptr.GetInvocationList()[1].DynamicInvoke(10, 20);
            // If you have appended multiple funcs then use this to call a particular one by passing an index what i have passed here is 1. 

            Console.WriteLine(fptr(100, 200));

            // anonymous function

            // fptr += delegate (int x, int y) { return x + y; };
            /* this is called anonymous function or block. 
             but why do we need it??
             sometimes you are forced to create a method. 
             like 1 single line of code. 
             You have to write it as an anonymous block coz you don't want to reusablility and explainability. 
             * this is kinda somewhat similar to inline()
             * this is only anonymous to dev but complier gives name to it.
             */

            // we can have a lambda func
            // fptr += (int x, int y) => { return x + y; };
            // this a short form of the above. 
            // but why is it called lambda expression. 
            // write expression as a block. 
            // this is more simplified.
            // confusing.
            // the above is explicitly typed argument

            // implicitly typed argument
            // fptr += (x, y) => { return x + y; };

            // can also be reduced to 
            // fptr += (x, y) => x + y;

            DlgDisplay dlgd = a => Console.WriteLine(a);
            // lambda expression with one single arguement.

            Func<int, int, int> func = (x, y) => x + y;
            // function and action
            // the above is a function
            // this is as equivalent to the delegate we have created. 
            // return type is always the last one
            func(100, 200);

            // action
            // this will have no return value
            // this is also delegate but no return type
            Action<string, string> FullName = (firstName, LastName) => Console.WriteLine(firstName + LastName);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}