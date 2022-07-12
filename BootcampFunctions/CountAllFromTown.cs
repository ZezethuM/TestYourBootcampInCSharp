namespace BootcampFunctions
{
   public class CountAllFromTown
    {
        public static int fromTown(string regNumber, string regStartString)
        {
            string[] strArray = regNumber.Split(",");
            int count = 0;

            foreach(string reg in strArray)
            {
                string newString = reg.Trim();

                if(newString.StartsWith(regStartString))
                {
                    count++;
                }
            }
            return count;
        }
    }
}