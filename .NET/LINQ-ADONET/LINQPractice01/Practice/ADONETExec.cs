using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice01.Practice
{
    internal class ADONETExec
    {
        private static void AddEmployee(SqlConnection conn)
        {
            Console.Clear();
            Console.WriteLine("Enter emp details - ");

            Console.WriteLine("enter name - ");
            string empname = Console.ReadLine();

            Console.WriteLine("enter emp unique id : ");
            string empunique = Console.ReadLine();

            Console.WriteLine("enter salary : ");
            int salary = Int32.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand(
                cmdText: "INSERT INTO [TempEmp] ( [EmpName], [Salary], [EmpUnique] ) VALUES ( @empName, @salary, @empUnique )",
                connection: conn
            );

            cmd.Parameters.Add("empName", SqlDbType.VarChar, 50).Value = empname;
            cmd.Parameters.Add("salary", SqlDbType.Int).Value = salary;
            cmd.Parameters.Add("empUnique", SqlDbType.VarChar, 50).Value = empunique;

            conn.Open();

            if (cmd.ExecuteNonQuery() > 0)
                Console.WriteLine("Inserted Successfully!!!\n Press any key to Continue...");
            else
                Console.WriteLine("Something went Worng!!!\n Press any key to Continue...");

            conn.Close();
            Console.ReadKey();
        }

        private static void DisplayEmployees(SqlConnection _cn)
        {
            try
            {
                SqlCommand _cmd = new SqlCommand();

                _cmd.Connection = _cn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select * from TempEmp";

                _cn.Open();
                SqlDataReader _drd = _cmd.ExecuteReader();

                if (!_drd.HasRows)
                {
                    Console.Clear(); Console.Write("Record(s) not found!!!\nPress any key to Continue...");
                    Console.ReadKey(); return;
                }
                Console.Clear();

                Console.WriteLine($"EmpID          |EmpName          |Salary");
                while (_drd.Read())
                    Console.WriteLine($"{_drd.GetValue(0)}|{_drd.GetValue(1)}|{_drd.GetValue(2)}|{_drd.GetValue(3)}");

                Console.Write("Press any key to Continue...");
                Console.ReadKey();

                _drd.Close(); _cn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetAllEmployeesUsingStoredProc(SqlConnection _cn)
        {
            Console.WriteLine("Stored Proc");

            //Console.WriteLine("Enter emp id");

            //string empid = Console.ReadLine();

            SqlCommand _cmd = new SqlCommand
                (
                    cmdText: "sp_GetAllEmps",
                    connection: _cn
                );

            //_cmd.CommandType = CommandType.StoredProcedure;

            //SqlParameter sql_prm = _cmd.Parameters.Add("empName", SqlDbType.VarChar, 50);
            //sql_prm.Direction = ParameterDirection.Output;

            //_cmd.Parameters.Add("@empid", SqlDbType.Int).Value = empid;

            _cn.Open();

            //_cmd.ExecuteNonQuery();
            //Console.WriteLine($"EmpName is {sql_prm.Value} for Emp Id {empid}");
            //Console.WriteLine("Press any key to Continue...");

            _cmd = new SqlCommand
                (
                    cmdText: "sp_GetAllEmps",
                    connection: _cn
                );

            _cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader _drd = _cmd.ExecuteReader();

            if (!_drd.HasRows)
            {
                Console.Clear(); Console.Write("Record(s) not found!!!\nPress any key to Continue...");
                Console.ReadKey(); return;
            }

            Console.Clear();
            Console.WriteLine($"EmpID          |EmpName          |Salary");
            while (_drd.Read())
                Console.WriteLine($"{_drd.GetValue(0)}|{_drd.GetValue(1)}|{_drd.GetValue(2)}");

            Console.Write("Press any key to Continue...");
            Console.ReadKey();

            _cn.Close();
        }

        private static void getEmpSalGreaterThanX(SqlConnection _cn)
        {
            Console.Write("Enter salary threshold: ");
            int desiredSalaryThreshold = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("sp_getEmpsSalaryGtX", _cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@sal", SqlDbType.Int).Value = desiredSalaryThreshold;

            _cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine($"Employees with salary greater than {desiredSalaryThreshold}:");
                Console.WriteLine("ID\tEmpName");

                while (reader.Read())
                    Console.WriteLine($"{reader["Id"]}\t{reader["EmpName"]}");

                Console.ReadKey();
            }
            else Console.WriteLine("No employees found with salary greater than the specified threshold.");

            reader.Close();
            _cn.Close();
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
                Console.WriteLine("1. Intserting Emps.");
                Console.WriteLine("2. Getting Emps.");
                Console.WriteLine("3. Stored Proc - Get All emps");
                Console.WriteLine("4. Stored Proc - Get All Emps with salary gt x");
                Console.WriteLine("5. ---");

                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                    AddEmployee(conn);

                else if (choice == 2)
                    DisplayEmployees(conn);

                else if (choice == 3)
                    GetAllEmployeesUsingStoredProc(conn);

                else if (choice == 4)
                    getEmpSalGreaterThanX(conn);

                else Console.WriteLine("Invalid Choice!!!");

            } while (choice >= 0);
        }
    }
}
