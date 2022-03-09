using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instead of class we can use interface. interface allows us to put more
            //than one type into this list. basically we dont know thats goes to this list
            //only know everything will follow after  this contract. all props and methods 
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();
            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                //checking if IProductModel is also implementing IDigitalProductModel
                //put that in "digital" var
                if(prod is IDigitalProductModel digital)
                {
                    //so we can access only IDigitalProductModel prop that only it has TotalDownloadsLeft
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }
        //return list of IProductModel which represents interface
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            //so now we can add to output list PhysicalProductModel and DigitalProductModel
            //becouse they both inherit from same interface.
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core start to finish" });
            return output;
        }
    }
}
