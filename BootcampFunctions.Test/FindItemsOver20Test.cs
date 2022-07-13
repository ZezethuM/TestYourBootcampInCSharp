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

            Assert.Equal(over20Items.ToString(), FindItemsOver20.FindItems(listOfItem).ToString());
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

            Assert.Equal(over20Items2.ToString(), FindItemsOver20.FindItems(listOfItem2).ToString());
        }
    }
}