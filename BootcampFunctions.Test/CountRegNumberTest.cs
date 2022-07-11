namespace BootcampFunctions.Test
{
    public class CountRegNumberTest
    {
        [Fact]
        public void ShouldReturnNumberOfRegNumberInAString()
        {
            Assert.Equal(3, CountRegNumber.registrationNumbers("CY 12332,XA 12445,M 54677"));
        }

        [Fact]
        public void ShouldReturnOneWhenCalledWIthEmptyString()
        {
            Assert.Equal(1, CountRegNumber.registrationNumbers(""));
        }

    }
}