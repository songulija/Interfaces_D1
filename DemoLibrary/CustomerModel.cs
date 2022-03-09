using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// you dont inherit from interface. inheritance means that you
    /// that you bring code down with you. you cant inherit multiple things
    /// but interface is contract, so you implement interface.
    /// so you just do what contracts says class can do. like what props and methods should be
    /// </summary>
    public class CustomerModel : ICustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }

    //how to create interface from existing class
}
