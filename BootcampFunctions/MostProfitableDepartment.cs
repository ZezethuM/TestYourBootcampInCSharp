namespace BootcampFunctions
{
    public class MostProfitableDepartment
    {
        public static string MostDepartment(List<Depart>departments)
        {
            Dictionary<string, int> dep = new Dictionary<string, int>();

            foreach (var itemsDeps in departments)
            {
                if(!dep.ContainsKey(itemsDeps.Department))
                {
                    dep.Add(itemsDeps.Department, itemsDeps.Sales);
                }
                else
                {
                    dep[itemsDeps.Department] += itemsDeps.Sales;   
                }
            }

            var currentElement = 0;
            var currentDepartment = "";
            foreach(var item in dep.Keys)
            {
                if(dep[item]> currentElement)
                {
                    currentElement = dep[item];
                    currentDepartment = item;
                }
            }
            return currentDepartment;
        }

    }
    public class Depart
    {
        public string Department { get; set; } = string.Empty;

        public int Sales { get; set; }

        public string Day { get; set; } = string.Empty;


    }
}