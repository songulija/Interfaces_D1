using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// basucially this is contract portion, we are defining 
    /// that any class that impletements this interface will have
    /// so other classes will have these atributes and method
    /// there is no code in here. 
    /// </summary>
    public interface IProductModel
    {
        //for properties there is get and set
        string Title { get; set; }
        //bool will have only get
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);
    }
}
