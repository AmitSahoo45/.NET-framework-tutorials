using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Properties
{
    class Person
    {
        public Person(DateTime dob)
        {
            this.dob = dob;
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        // use prop + tab tab 
        // or
        // use propfull + tab tab
        private string _description;

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime dob { get; private set; }

        // when we are setting a property private here, the property can no longer be changed
        // we xan use the parametereised cons
        // this has become a readonly prop now
        // potential question - guess the op set it to readonly and error

        public bool sex { get; set; }

        public int Age
        {
            get { var timeSpan = DateTime.Today - dob; var years = timeSpan.Days / 365; return years; }
        }
    }

    internal class PropsExec
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2002, 12, 1));
            Console.WriteLine(person.dob.ToString());
            Console.ReadKey();
        }
    }
}
