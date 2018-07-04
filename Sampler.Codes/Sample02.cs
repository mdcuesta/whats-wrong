namespace Sampler.Codes
{
    public class Sample2
    {
        public bool DoSomething()
        {
            return true;
        }

        public bool DoSomethingElse()
        {
            return false;
        }

        /*
         * START OF BAD CODE
         */
        public bool Method(string param)
        {
            if (param == "something")
            {
                /* more codes */
                return DoSomething();
            }
            else
            {
                /* more codes */
                return DoSomethingElse();
            }
        }
        /*
         * END OF BAD CODE 
         */
    }
}
