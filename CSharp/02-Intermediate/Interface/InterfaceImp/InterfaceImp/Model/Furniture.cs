using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImp.Model
{
    internal class Furniture
    {
        public string furnitureType { get; set; }
        public string furnitureMadeUpOf { get; set; }

        public Furniture(string furnitureType, string furnitureMadeUpOf)
        {
            this.furnitureType = furnitureType;
            this.furnitureMadeUpOf = furnitureMadeUpOf;
        }

        public virtual void Usage() {}
    }
}
