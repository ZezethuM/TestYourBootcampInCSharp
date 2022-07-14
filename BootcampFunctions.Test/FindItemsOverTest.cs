using Newtonsoft.Json;
namespace BootcampFunctions.Test
{
    public class FindItemsOverTest
    {
        [Fact]
        public void ShouldReturnItemsOver10()
        {
            List<Item1> listOfItems3 = new List<Item1>()
            {
                 {new Item1()  {Name1 = "apples", Qty1 = 10}},
                 {new Item1()  {Name1 = "pears", Qty1 = 37}},
                 {new Item1()  {Name1 = "bananas", Qty1 = 27}},
                 {new Item1()  {Name1 = "apples", Qty1 = 3}}
                
            };

            List<Item1> overItems1 = new List<Item1>()
            {
                {new Item1()  {Name1 = "pears", Qty1 = 37}},
                {new Item1()  {Name1 = "bananas", Qty1 = 27}}
            };

            Assert.Equal(JsonConvert.SerializeObject(overItems1), JsonConvert.SerializeObject(FindItemsOver.FindItems1(listOfItems3, 10)));
        }
    
     [Fact]
        public void ShouldReturnEmptyListWhenNoItemOver()
        {
            List<Item1> listOfItem1 = new List<Item1>()
            {
                 {new Item1()  {Name1 = "apples", Qty1 = 10}},
                 {new Item1()  {Name1 = "pears", Qty1 = 37}},
                 {new Item1()  {Name1 = "bananas", Qty1 = 27}},
                 {new Item1()  {Name1 = "apples", Qty1 = 3}}
            };
            List<Item1> overItems2 = new List<Item1>()
            {};
            Assert.Equal(overItems2, FindItemsOver.FindItems1(listOfItem1,  50));
        }
    }
}