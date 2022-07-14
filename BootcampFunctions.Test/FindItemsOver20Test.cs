using Newtonsoft.Json;
namespace BootcampFunctions.Test
{
    public class FindItemsOver20Test
    {
        [Fact]
        public void ShouldReturnItemsOver20()
        {
            List<Item> listOfItem = new List<Item>()
            {
                 {new Item()  {Name = "apples", Qty = 10}},
                 {new Item()  {Name = "pears", Qty = 37}},
                 {new Item()  {Name = "bananas", Qty = 27}},
                 {new Item()  {Name = "apples", Qty = 3}}

            };

            List<Item> over20Items = new List<Item>()
            {
                {new Item()  {Name = "pears", Qty = 37}},
                {new Item()  {Name = "bananas", Qty = 27}},
            };

            Assert.Equal(JsonConvert.SerializeObject(over20Items), JsonConvert.SerializeObject(FindItemsOver20.FindItems(listOfItem)));
        }
    
     [Fact]
        public void ShouldReturnEmptyListWhenNoItemOver20()
        {
            List<Item> listOfItem2 = new List<Item>()
            {
                 {new Item()  {Name = "apples", Qty = 10}},
                 {new Item()  {Name = "pears", Qty = 37}},
                 {new Item()  {Name = "bananas", Qty = 27}},
                 {new Item()  {Name = "apples", Qty = 3}}
                
            };

            List<Item> over20Items2 = new List<Item>()
            {
                {new Item()  {Name = "pears", Qty = 37}},
                {new Item()  {Name = "bananas", Qty = 27}},
            };

            Assert.Equal(JsonConvert.SerializeObject(over20Items2), JsonConvert.SerializeObject(FindItemsOver20.FindItems(listOfItem2)));
        }
    }
}