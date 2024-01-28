using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImp.Model
{
    internal class Vehicle
    {
        public string VehicleType { get; set; }
        public string VehicleColor { get; set; }

        public Vehicle(string vehicleType, string vehicleColor)
        {
            this.VehicleType = vehicleType;
            this.VehicleColor = vehicleColor;
        }

        public virtual void Drive() { }
    }
}
