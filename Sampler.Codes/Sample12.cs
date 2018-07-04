// L
namespace Sampler.Codes
{
    public class MallCustomer
    {
        public virtual double GetDiscount(double sales)
        {
            const double promoDiscount = 10;

            return sales - promoDiscount;
        }

        public virtual void Save()
        {
            // save to database codes here
        }
    }

    public class BronzeMallCustomer : MallCustomer
    {
        public override double GetDiscount(double sales)
        {
            const double bronzeCustomerDiscount = 50;
            return base.GetDiscount(sales) - bronzeCustomerDiscount;
        }
    }

    public class SilverMallCustomer : MallCustomer
    {
        public override double GetDiscount(double sales)
        {
            const double silverCustomerDiscount = 50;
            return base.GetDiscount(sales) - silverCustomerDiscount;
        }
    }

    /*
     * Problem: Introduce an EnquiryCustomer which will not be saved in the database
     */

    public class Sample12
    {

        public void Method()
        {

        }
    }
}
