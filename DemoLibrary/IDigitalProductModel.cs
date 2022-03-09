using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //interface can implement interface too. so we will have props and method
    //from IProductModel. basically this interface implements IProductModel
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
