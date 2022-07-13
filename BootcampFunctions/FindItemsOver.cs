namespace BootcampFunctions
{
    public class FindItemsOver
    {
        public static List<Item1> FindItems1(List<Item1>listOfItem1, int threshold)
        {
            List<Item1> list1 = new List<Item1>();

            for(int i=0; i<listOfItem1.Count; i++)
            {
                if(listOfItem1[i].Qty1 > threshold){
                    list1.Add(listOfItem1[i]);
                }
            }
            return list1;
        } 
    }

    public class Item1
    {
        public string Name1{get; set;} = string.Empty;
        public int Qty1{get; set;}
    }
}