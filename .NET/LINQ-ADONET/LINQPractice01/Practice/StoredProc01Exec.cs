using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LINQPractice01.Practice
{
    internal class StoredProc01Exec
    {
        private static void InsertManyStudents(SqlConnection conn)
        {
            Console.Write("enter min cgpa : ");
            float cgpa = float.Parse(Console.ReadLine());

            Console.Write("enter professor id : ");
            string profId = Console.ReadLine();

            SqlCommand cmd = new SqlCommand
                (
                    cmdText: "sp_GetStudentUnderXProfAndYcgpa",
                    conn
                );

            conn.Open();

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader drd = cmd.ExecuteReader();

            if (!drd.HasRows)
            {
                Console.Clear(); Console.Write("Record(s) not found!!!\nPress any key to Continue...");
                Console.ReadKey(); return;
            }

            Console.Clear();

            while (drd.Read())
                Console.WriteLine($"{drd.GetValue(0)} | {drd.GetValue(1)} | {drd.GetValue(2)} | {drd.GetValue(3)}");

            Console.Write("Press any key to Continue...");
            Console.ReadKey();

            drd.Close(); conn.Close();
        }

        private static void getPointsAvgF1Drivers(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand
            (
                cmdText: "sp_CalculateF1DriverAvgSpeeds",
                conn
            );

            conn.Open();

            cmd.CommandType = CommandType.StoredProcedure;

            conn.Close();
        }

        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection();
            SqlConnectionStringBuilder _connstbuilder = new SqlConnectionStringBuilder();

            _connstbuilder.DataSource = "(localdb)\\MSSQLLocalDB";
            _connstbuilder.InitialCatalog = "PracticeDB";
            _connstbuilder.IntegratedSecurity = true;

            conn.ConnectionString = _connstbuilder.ConnectionString;

            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter your choice - ");
                Console.WriteLine("1. Intserting Multiple Students");
                Console.WriteLine("2. Create a new table AvgPoints");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");

                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                    InsertManyStudents(conn);

                else if (choice == 2)
                    getPointsAvgF1Drivers(conn);

                else Console.WriteLine("Invalid Choice!!!");

            } while (choice >= 0);
        }
    }
}
