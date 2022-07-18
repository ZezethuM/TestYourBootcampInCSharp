namespace BootcampFunctions
{
    public class CountRegNumber
    {
     public static int registrationNumbers(string regNumbers)
        {
            if(regNumbers != "")
            {
            return regNumbers.Split(",").Length;
            }
            else
            {
                return 0;
            }
        }

    }
}