using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImp.Model
{
    internal class Car : Vehicle, IDestroyable
    {
        public string CarName { get; set; }
        public string destructionSound { get; set; }

        public List<IDestroyable> destroyableObjects { get; set; }

        public Car(string carName, string vehicleType, string vehicleColor) : base(vehicleType, vehicleColor)
        {
            this.CarName = carName;
            destroyableObjects = new List<IDestroyable>();
        }

        public override void Drive()
        {
            Console.WriteLine("The car is being driven by the driver.");
        }

        public void Destroy()
        {
            Console.WriteLine($"The {CarName} {VehicleType} is being destroyed.");

            foreach (var destroyableObject in destroyableObjects)
                destroyableObject.Destroy();
        }
    }
}
