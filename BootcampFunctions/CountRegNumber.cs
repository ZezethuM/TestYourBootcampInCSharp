namespace BootcampFunctions
{
    public class CountRegNumber
    {
     public static int registrationNumbers(string regNumbers)
        {
            return regNumbers.Split(",").Length;
        }

    }
}