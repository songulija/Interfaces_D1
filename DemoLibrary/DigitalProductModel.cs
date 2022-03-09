using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //interface doesnt care what props and methods you have in class.
    //it cares about that you have everything that contract says you should have
    //props Title, HasOrderBeenCompleted and method ShipItem
    //we can applly two interfaces and more at time. we implement IDigitalProductModel interface
    //which implements IProductModel interface. so we have props and methods from both interfaces values here
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }
        //private set we can only set here. becouse IProductModel doesnt have it
        //public version of it is just GET, only read only from public side.
        //HasOrderBeenCompleted is only private internal. start with value 5
        //and this value we have becouse of IDigitalProductModel interface. just implementing it
        public bool HasOrderBeenCompleted { get; private set; }
        //adding new prop. its private internal. so only setting is possible here
        public int TotalDownloadsLeft { get; private set; } = 5;
        //for example way we ship digital item is different that physical item. so here is different implementation
        public void ShipItem(CustomerModel customer)
        {
            //check if order not completed. check if finished all 5 donwloads
            //email information, and then subract one from total downloads.
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.EmailAddress } in { customer.City }");
                //subract one from total downloads
                TotalDownloadsLeft -= 1;
                if(TotalDownloadsLeft < 1)
                {
                    //then its completed and it cant be downloaded more times
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }

            }
            
        }
    }
}
