using System.Net;

namespace Sampler.Codes
{
    public class Sample01
    {
        /*
         * START OF BAD CODE
         */
        public void Method()
        {
            var request = WebRequest.Create("http://www.google.com");

            // ... more codes
        }
        /*
         * END OF BAD CODE 
         */
    }
}
