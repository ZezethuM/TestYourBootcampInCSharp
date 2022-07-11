namespace BootcampFunctions
{
    public class IsWeekday
    {
        public static bool Weekdays(string day)
        {
            string[] array = {"Monday","Tuesday","Wednesday","Thursday","Friday"};
            
            return array.Contains(day);
        }
    }
}