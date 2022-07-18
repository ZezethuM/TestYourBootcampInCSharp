using System;

namespace BootcampFunctions
{
    public class Greet
    {
        public static string Execute(String name) 
        {
            if(name != ""){
            return $"Hello, {name}";
            }
            else
            {
                return "Please enter a name";
            }
                
        }
    }
}
