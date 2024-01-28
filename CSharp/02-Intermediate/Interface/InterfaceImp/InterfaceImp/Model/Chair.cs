using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImp.Model
{
    class Chair: Furniture, IDestroyable
    {
        public string ChairCompany { get; set; }
        public string destructionSound { get; set; }

        public List<IDestroyable> destroyableObjects { get; set; }

        public Chair(string furnitureType, string furnitureMadeUpOf, string chairCompany) : base(furnitureType,
            furnitureMadeUpOf)
        {
            this.ChairCompany = chairCompany;
            destroyableObjects = new List<IDestroyable>();
        }

        public override void Usage()
        {
            Console.WriteLine("The chair is being used by the person.");
        }

        public void Destroy()
        {
            Console.WriteLine($"The {furnitureMadeUpOf} {furnitureType} is being destroyed.");

            foreach (var destroyableObject in destroyableObjects)
                destroyableObject.Destroy();
        }
    }
}
