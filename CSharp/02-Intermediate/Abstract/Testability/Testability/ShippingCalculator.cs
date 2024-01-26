using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    // this interface simply defines the capability a class should provide.

    public class ShippingCalculator: IShippingCalculator
    // we implement shippingCalculator class implementing the IShippingCalculator interface.
    // this means that ShippingCalculator implements IShippingCalculator.
    // this is not inheritance. this is implementation.
    // below we are still writing code and implementing the CalculateShipping method.
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f) return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}
