using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// you can implement interface after inheriting from class.
    /// you cant inherit from two classes, but can implement from many interfaces
    /// </summary>
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
