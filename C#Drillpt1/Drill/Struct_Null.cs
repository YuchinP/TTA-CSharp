using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Usage of a null type and this
namespace Drill
{
    public class Product
    {

        public Product()
        {
            Console.WriteLine("Default");
        }
        public Product(DateTime availabilityDate,
                       string productName) : this()
        {
            this.AvailabilityDate = availabilityDate;
            this.ProductName = productName;
            Console.WriteLine("This is named" + productName + "available on");
        }


        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
    }
    public struct Identity
    {

    }
        
    


}


