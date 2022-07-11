namespace BootcampFunctions
{
    public class CountAllPaarl
    {
        public static int allPaarl(string regNumbers)
        {
            string[] array = regNumbers.Split(",");
            int count = 0;

            foreach(string reg in array)
            {
                if(reg.StartsWith("CJ"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}