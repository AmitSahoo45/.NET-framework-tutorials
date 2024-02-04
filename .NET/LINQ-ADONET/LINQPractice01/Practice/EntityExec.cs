using LINQPractice01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice01.Practice
{
    internal class EntityExec
    {
        Action<string> ClearScreenAndContinues = (msg) => { Console.WriteLine(msg); Console.Clear(); };

        private static void ClearScreenAndContinue()
        {
            Console.WriteLine("\n\nPress any key to continue!!!");
            Console.ReadKey();
            Console.Clear();
        }

        private static void getAllF1Drivers(TestingDBEntities _db)
        {

            foreach (var driver in _db.TempF1Drivers)
                Console.Write($"Hi, I am {driver.Name} and I drive for {driver.Team}");

            ClearScreenAndContinue();
        }

        private static void addNewProfessor(TestingDBEntities db)
        {
            try
            {
                Professor pf = new Professor();

                Console.WriteLine("ENter professor details : ");
                Console.Write("Enter professor ID : ");
                pf.ProfessorId = Console.ReadLine() ?? "KIIT1010";

                Console.Write("Enter professor Name : ");
                pf.Profname = Console.ReadLine() ?? "Ramakant Sarangi";

                Console.Write("Enter professor Salary : ");
                pf.ProfSal = Int32.Parse(Console.ReadLine() ?? "30000");

                db.Professors.Add(pf);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                ClearScreenAndContinue();
            }
        }

        private static void storedProcedureGetEmpDetails(TestingDBEntities db)
        {
            try
            {
                var emps = db.sp_GetAllEmps();

                foreach (var emp in emps)
                    Console.WriteLine(emp.EmpName + " " + emp.Salary);

                Console.ReadKey();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally { ClearScreenAndContinue(); }
        }

        static void Main(string[] args)
        {
            TestingDBEntities _db = new TestingDBEntities();

            string choice = "";

            do
            {
                Console.WriteLine
                    (
                    "Testing for Entity Framework - " +
                    "Press 1 - Get all F1 Drivers" +
                    "Press 2 - To get All employee details"
                    );
                Console.Write("Enter Choice:");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        getAllF1Drivers(_db);
                        break;

                    case "2":
                        storedProcedureGetEmpDetails(_db);
                        break;

                    default:
                        Console.WriteLine("Oops! You entered the wrong choice");
                        break;
                }
            } while (choice != "0");
        }
    }
}
