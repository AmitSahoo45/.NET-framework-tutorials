using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice01.Practice
{
    public class CompEmployee
    {
        public int empID { get; set; }
        public string empName { get; set; }
        public int salary { get; set; }
    }

    internal class linqPractice
    {
        static void Main(string[] args)
        {
            List<CompEmployee> _emps = new List<CompEmployee>
            {
                new CompEmployee(){ empID = 1000, empName = "Ganesh", salary = 1000 },
                new CompEmployee(){ empID = 1001 ,empName = "Mahesh", salary= 12000 },
                new CompEmployee(){ empID = 1002 ,empName = "Dinesh", salary= 15000 },
                new CompEmployee(){ empID = 1003, empName = "Vignesh",salary = 18000 },
            };

            IEnumerable<CompEmployee> _qry = _emps.Where(emp => emp.salary > 1000);
            var _containsQry = _emps.Where(emp => emp.empName.Contains(emp.empName));

            foreach (var emp in _qry) { Console.WriteLine(emp.empName); }

            foreach (var emp in _containsQry) { Console.WriteLine(emp.empName); }

            Console.ReadKey();
        }
    }
}
