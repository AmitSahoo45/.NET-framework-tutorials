using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Access_Modifiers
{
    class PersonEncap
    {
        private string _name;
        private DateTime dob;

        public void setName(string name)
        {
            if (!String.IsNullOrEmpty(name))
                this._name = name;
        }

        public string getName() { return _name; }

        public void setDOB(DateTime dob)
        {
            if (dob != DateTime.MinValue)
                this.dob = dob;
        }

        public DateTime getDob() { return dob; }
    }

    class Person
    {
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

        public DateTime dob { get; set; }

        public bool sex { get; set; }

        public int Age
        {
            get { var timeSpan = DateTime.Today - dob; var years = timeSpan.Days / 365; return years; }

        }
    }



    internal class AccessModifiers
    {
        static void Main(string[] args)
        {
            var psncap = new PersonEncap();
            psncap.setDOB(new DateTime(2002, 12, 02));
            var dobRes = psncap.getDob();
            Console.WriteLine(dobRes.ToString());
        }

    }
}
