using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice01.Practice
{
    interface IDriver
    {
        string DriverName { get; set; }
        double Ratings { get; set; }
        string getDriverDetails();
    }

    public class Team
    {
        public string TeamName { get; set; }

        public Team(string teamName)
        {
            this.TeamName = teamName;
        }
    }

    public class Driver : Team, IDriver
    {
        public string DriverName { get; set; }
        public double Ratings { get; set; }
        public Driver(string teamName, string driverName, double Ratings) : base(teamName)
        {
            this.DriverName = driverName;
            this.Ratings = Ratings;
        }

        public string getDriverDetails()
        {
            return $"{DriverName} drives for {TeamName}. He has a rating of {Ratings}";
        }
    }

    internal class WaysToWriteLinQ
    {
        static void Main(string[] args)
        {
            var ham = new Driver("Mercedes AMG F1", "Sir Lewis Hamilton", 8.9);
            var rus = new Driver("Mercedes AMG F1", "George Russel", 9.2);
            var max = new Driver("Mercedes AMG F1", "George Russel", 9.1);

            List<Driver> f1Drivers = new List<Driver>() { ham, rus, max };

            List<string> names = (from obj in f1Drivers
                                  where obj.Ratings > 9.0
                                  select obj.DriverName).ToList();

            foreach (var str in names)
                Console.WriteLine(str + " ");
        }
    }
}
