namespace Sampler.Codes
{
    public class SomeService
    {

    }

    public class HomeController
    {
        /*
         * START OF BAD CODE
         */
        private SomeService someService;
        /*
         * END OF BAD CODE
         */

        public HomeController(SomeService someService)
        {
            this.someService = someService;
        }
    }
}
