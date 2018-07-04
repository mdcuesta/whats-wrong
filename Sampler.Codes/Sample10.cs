// S
using System;

namespace Sampler.Codes
{
    public class Customer
    {

    }

    public class CustomerService
    {
        /*
         * START OF BAD CODE
         */
        public void Add(Customer customer)
        {
            try
            {
                // database code goes here
            }
            catch(Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
        /*
         * START OF BAD CODE
         */
    }
}
