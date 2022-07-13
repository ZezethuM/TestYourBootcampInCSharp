namespace BootcampFunctions
{
    public class FromWhere
    {
        public static string Where(string regNumber)
        {
            string town = "";

            switch(regNumber)
            {
                case "CY":
                    town = "Bellville";
                    break; 
                
                case "CJ":
                    town = "Paarl";
                    break; 
                
                case "CA":
                    town = "CapeTown"; 
                    break;

                default:
                    town = "Some other place";
                    break;
            }
            return town;
        }
    }
}