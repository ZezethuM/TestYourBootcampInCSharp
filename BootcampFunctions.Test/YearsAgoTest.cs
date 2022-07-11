namespace BootcampFunctions.Test
{
    public class YearsAgoTest
    {
        [Fact]
        public void ShouldReturnNumberOfYearItHasbeen()
        {
            Assert.Equal(26, YearsAgo.howLong(1996));
        }
        [Fact]

        public void ShouldReturnZeroIfYearHasntBeenReached()
        {
            Assert.Equal(0, YearsAgo.howLong(2026));
        }
    }
}