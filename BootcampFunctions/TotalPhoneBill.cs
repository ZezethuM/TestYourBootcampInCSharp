namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
        public static string Price(string callsAndSms)
        {
            double calls = 0.00;
            double sms = 0.00;
            double total = 0.00;

            string[] array = callsAndSms.Split(",");
             foreach(string s in array)
             {
                 string phones = s.Trim().ToLower();
                 if(phones == "call")
                 {
                     calls += 2.75;
                 }
                 else if(phones == "sms")
                 {
                     sms += 0.65;
                 }
             }
             total = calls + sms;
             return "R" + total; 
        }
    }
}