using System.Collections.Generic;
using System.Linq;

namespace Sampler.Codes
{
    public class Sample06
    {
        IEnumerable<int> ExecuteQuery(string query)
        {
            return Enumerable.Empty<int>();
        }

       
        public void Method()
        {
            /*
            * START OF BAD CODE
            */
            string query = "SELECT Id FROM Customer";
            IEnumerable<int> queryResult = ExecuteQuery(query);
            /*
            * END OF BAD CODE
            */

            // .. more codes
        }
    }
}
