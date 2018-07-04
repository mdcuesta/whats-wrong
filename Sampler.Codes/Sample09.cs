using System;

namespace Sampler.Codes
{
    public class Product
    {
        public Decimal Price { get; set; }

        public int Quantiy { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsFeatured { get; set; }
    }

    public class Sample09
    {
        /*
         * START OF BAD CODE
         */
        public bool IsProductAvailable(Product product)
        {
            if (product.Quantiy < 5)
            {
                return false;
            }
            else if (product.IsDeleted)
            {
                return false;
            }
            else if (!product.IsFeatured)
            {
                return true;
            }
            return true;
        }
        /*
         * END OF BAD CODE
         */
    }
}
