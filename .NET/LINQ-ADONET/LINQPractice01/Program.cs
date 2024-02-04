using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;


            do
            {
                Console.WriteLine("Please enter your choice.");
                Console.WriteLine("1 for running Ways to write LINQ.");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        break;


                }

            } while (choice != -1);
        }
    }
}
