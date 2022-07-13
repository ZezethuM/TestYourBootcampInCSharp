namespace BootcampFunctions
{
    public class FromWhereTest
    {
        [Fact]
        public void ShouldTownRegStringBelongsTo()
        {
            Assert.Equal("Bellville" , FromWhere.Where("CY"));
        }
        [Fact]
        public void ShouldReturnSomeOtherTown()
        {
            Assert.Equal("Some other place", FromWhere.Where("ZN"));
        }
    }
}