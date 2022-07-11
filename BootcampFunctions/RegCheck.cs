namespace BootcampFunctions
{
    public class RegCheck
    {
     public static bool registrations(string regNumber, string regLocation)
        {
            return regNumber.EndsWith(regLocation);
        }

    }
}