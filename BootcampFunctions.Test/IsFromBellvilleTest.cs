namespace BootcampFunctions.Test
{
    public class IsFromBellvilleTest
    {
        [Fact]
        public void ShouldReturnTrueIfFromBellville()
        {            
            Assert.Equal(true, IsFromBellville.registration("CY 12055"));
        }

        [Fact]
        public void ShouldReturnFlseIfNotFromBellville()
        {
            Assert.Equal(false, IsFromBellville.registration("CJ 1452"));
        }
    }
}