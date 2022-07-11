namespace BootcampFunctions.Test
{
    public class RegCheckTest
    {
        [Fact]
        public void ShouldReturnTrueWhenRegistrationMatchLocation()
        {            
            Assert.Equal(true, RegCheck.registrations("12350 GP", "GP"));
        }

        
        [Fact]
        public void ShouldReturnFlseWhenRegistrationDoesNotMatchLocation()
        {
            Assert.Equal(false, RegCheck.registrations("15245 CY", "GP"));

        }
         [Fact]
        public void ShouldReturnFalseWhenCalledWithRegNoStartingWithLocation()
        {
            Assert.Equal(false, RegCheck.registrations("GP 45215", "GP"));

        }
    }
}