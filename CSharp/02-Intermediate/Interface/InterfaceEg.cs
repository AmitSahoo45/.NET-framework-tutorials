using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEg;

public class InterfaceExec
{
    public class Ticket : IEquatable<Ticket>
    // here we are implementing the IEquatable interface
    // this allows us to compare in our own way 
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            if (other == null) return false;
            return (this.DurationInHours.Equals(other.DurationInHours));
        }
    }

    // Creating our own interfaces.

    interface IDestroyable
    {
        // this interface will have a property to store the audio file that will run once we execute the destrcution.
        string DestructionSound { get; set; }
        void Destroy();
    }

    // Furniture Class
    class Furniture
    {
        public string furnitureType { get; set; }
        public string color { get; set; }
        public string material { get; set; }

        public Furniture()
        {
            this.furnitureType = "";
            this.color = "Brown";
            this.material = "Wood";
        }

        public Furniture(string furnitureType, string color, string material)
        {
            this.furnitureType = furnitureType;
            this.color = color;
            this.material = material;
        }
    }

    // Chair Class
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material) : base("Chair", color, material)
        {
            DestructionSound = "ChairBreakSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine("Chair is destroyed");
            Console.WriteLine("Playing destruction sound");
            Console.WriteLine("Spawning chain parts");
        }
    }

    class Vehicle
    {
        public float speed { get; set; }
        public string color { get; set; }

        public Vehicle()
        {
            this.speed = 120f;
            this.color = "White";
        }

        public Vehicle(float speed, string color)
        {
            this.speed = speed;
            this.color = color;
        }
    }

    // Car Class
    class Car : Vehicle, IDestroyable
    {
        /*
        public Car(float speed, string color)
        {
            this.speed = speed;
            this.color = color;
        }
        */
        // always remember this is not a good practice. 
        // in the curremt scenario we are setting the speed and color of the car.
        // but all these varibles are members of the Vehicle class, within which parameterised cons are present to set these values.
        // so we should use the Vehicle class's cons to set these values.
        // therefore it is a better idea to for this.

        public string DestructionSound { get; set; }

        // creating a new property to store the destroyable objects nearby
        // when a car gets destroyed, it should also destroy the objects nearby.
        // this list is of type IDestroyable which means it can store any object that implements this interface and 
        // and that we can access the properties and methods of this interface.
        public List<IDestroyable> DestroyableObjects;

        public Car(float speed, string color) : base(speed, color)
        {
            // this.speed = speed;
            // this.color = color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyableObjects = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Car is destroyed");
            Console.WriteLine("Playing destruction sound");
            Console.WriteLine("Destroying nearby objects");

            foreach (var item in DestroyableObjects)
                item.Destroy();
        }
    }

    // C# is a single inheritance language.
    // It can only inherit from one class at a time.
    // As Car and Vehicle are already inheriting from the same class, we can't inherit anymore.


    // Main Method
    public InterfaceExec()
    {
        static void Main(string[] args)
        {
            // Ticket t1 = new Ticket(10);
            // Ticket t2 = new Ticket(10);
            // Console.WriteLine(t1.Equals(t2)); 

            // Creating our own interfaces. 
            // ---------------------------------
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(100f, "Red");
            damagedCar.DestroyableObjects.Add(officeChair);
            damagedCar.DestroyableObjects.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}

/*
 * Interfaces are some sort of multiple inheritance even though it is not.
 */