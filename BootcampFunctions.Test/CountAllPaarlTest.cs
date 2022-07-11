namespace BootcampFunctions.Test
{
    public class CountAllPaarlTest
    {
        [Fact]
        public void ShouldCountRegFromPaarl()
        {
            Assert.Equal(3, CountAllPaarl.allPaarl("CJ 1515,CJ 6646,CJ 4442,3636 ZN,3446 EC"));
        }
        [Fact]
        public void ShouldReturnZeroIfThereAreNoneFromPaarl()
        {
            Assert.Equal(0, CountAllPaarl.allPaarl("3636 ZN,3446 EC"));
        }
    }
}