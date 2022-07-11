namespace BootcampFunctions
{
    public class YearsAgo
    {
        public static int howLong(int year)
        {
            int CurrentYear = DateTime.Now.Year;
            int numberOfYears = CurrentYear - year;

            if(numberOfYears < 0)
            {
                return 0;
            }
            else
            {
                return numberOfYears;
            }
        }
    }
}