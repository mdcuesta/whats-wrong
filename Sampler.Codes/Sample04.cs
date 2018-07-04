namespace Sampler.Codes
{
    public class SomeClass
    {
        public bool DoSomething()
        {
            return true;
        }
    }

    public class Sample04
    {
        /*
        * START OF BAD CODE
        */
        public void SaveCustomer(SomeClass someClass)
        {
            someClass.DoSomething();
        }
        /*
        * END OF BAD CODE
        */
    }
}
