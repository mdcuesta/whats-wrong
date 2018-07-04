namespace Sampler.Codes
{
    public class Sample03
    {
        private enum Work
        {
            Engineer,
            SalesMan,
            Doctor
        }

        private enum Level
        {
            Junior,
            Senior,
        }

        private double GetDoctorPayment()
        {
            return 0;
        }

        private double GetEngineerPayment()
        {
            return 0;
        }

        private double GetJuniorPayment()
        {
            return 0;
        }

        /*
        * START OF BAD CODE
        */
        private double GetPayment(Level level, Work work)
        {
            double result;
            if (level == Level.Junior)
            {
                result = GetJuniorPayment();
            }
            else
            {
                if (work == Work.Doctor)
                {
                    result = GetDoctorPayment();
                }
                else
                {
                    result = GetEngineerPayment();
                }
            }
            return result;
        }
        /*
        * END OF BAD CODE 
        */
    }
}
