using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTraining.OOPs.Indexers
{
    /*
    public class HttpCookie
    {
        public string this[string key]
        {
            // instead of an identifier, we are using the this keyword
            // string key is the indexer notation.
            get { return ""; } // some logic
            set { } // some logic
        }
    }
    */

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime expiry { get; set; }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }


    internal class IndexersEg
    {
        static void Main(string[] args)
        {
            string[] skills = { "C++", "JavaScript", "TypeScript", "SQL" };

            Console.WriteLine(skills[0]);

            // there are indexers

            var cookie = new HttpCookie();
            cookie["name"] = "Amit";

            Console.WriteLine(cookie["name"]);
        }
    }
}
