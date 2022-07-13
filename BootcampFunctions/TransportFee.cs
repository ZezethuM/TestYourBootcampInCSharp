namespace BootcampFunctions
{
    public class TransportFee
    {
        public static string Shifts(string shift)
        {
            string price = "";

            switch(shift)
            {
                case "morning":
                    price = "R20";
                    break;
                case "afternoon":
                    price = "R10";
                    break;
                case "night":
                    price = "free";
                    break;
            }
            return price;
        }
    }
}