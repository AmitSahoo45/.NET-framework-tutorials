using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceImp.Model;

namespace InterfaceImp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rockingChair = new Chair("Chair", "Wood", "Ikea");
            var officeChair = new Chair("Chair", "Plastic", "Office Depot");
            var gamingChair = new Chair("Chair", "Leather", "DXRacer");

            var car = new Car("Mercedes AMG", "F1 Car", "Silver");
            var SF2002 = new Car("Scuderia F1", "F1 Car", "Red");

            car.destroyableObjects.Add(rockingChair);
            car.destroyableObjects.Add(officeChair);
            car.destroyableObjects.Add(gamingChair);
            car.destroyableObjects.Add(SF2002);

            car.Destroy();

            Console.ReadKey();
        }
    }
}
