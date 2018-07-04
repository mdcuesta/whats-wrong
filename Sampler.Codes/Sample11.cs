// O
namespace Sampler.Codes
{
    /*
     * START OF BAD CODE
     */
    public class StoreCustomer
    {
        public int CustomerType { get; set; }

        public string Name { get; set; }

        public double GetDiscount(double sales)
        {
            double customerDiscount = 0;
            
            if (CustomerType == 1)
            {
                customerDiscount = 50;
            }
            else if (CustomerType == 2)
            {
                customerDiscount = 100;
            }

            const double promoDiscount = 10;

            return (sales - promoDiscount) - customerDiscount;
        }
    }
    
    /*
     * Problem: What if we will add another CustomerType
     */

    public class Sample11
    {

        public void Method()
        {
            var bronzeCustomer = new StoreCustomer
            {
                CustomerType = 1,
            };

            double bronzeCustomerDiscount = bronzeCustomer.GetDiscount(200);

            var silverCustomer = new StoreCustomer
            {
                CustomerType = 2,
            };

            double silverCustomerDiscount = silverCustomer.GetDiscount(200);

        }
    }
    /*
     * END OF BAD CODE
     */
}
