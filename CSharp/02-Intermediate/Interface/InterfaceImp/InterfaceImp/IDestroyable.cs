using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImp
{
    interface IDestroyable
    {
        string destructionSound { get; set; }
        List<IDestroyable> destroyableObjects { get; set; }
        void Destroy();
    }
}
