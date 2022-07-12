namespace BootcampFunctions.Test
{
    public class CountAllFromTownTest
    {
        [Fact]
        public void ShouldReturnNumberOfRegNumbersFromStartString()
        {
            Assert.Equal(3, CountAllFromTown.fromTown("CJ 5155, ZN 4965, EC 2156, CJ 455422, CJ 4632", "CJ"));
        }
        [Fact]
        public void ShouldReturnZeroWhenNoRegIsFound()
        {
            Assert.Equal(0, CountAllFromTown.fromTown("4522 CJ, 5316 ZN, 5122 ZN, 1532 MP", "ZN"));
        }
    }
}