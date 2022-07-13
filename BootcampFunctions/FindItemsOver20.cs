namespace BootcampFunctions
{
    public class FindItemsOver20
    {
        public static List<Item> FindItems(List<Item>listOfItem)
        {
            List<Item>list = new List<Item>();
            for(int i=0; i<listOfItem.Count; i++)
            {
                if(listOfItem[i].Qty > 20){
                    list.Add(listOfItem[i]);
                }
            }
            return list;
        } 
    }

    public class Item
    {
        public string Name{get; set;} = string.Empty;
        public int Qty{get; set;}
    }
}