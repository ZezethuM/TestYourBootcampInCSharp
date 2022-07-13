namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void ShouldReturnTotatAmountOfCallsAndSmsMade()
        {
           Assert.Equal("R9,55", TotalPhoneBill.Price("call,call,sms,call,sms"));
        }
        [Fact]
        public void ShouldReturnZeroRandWhenCalledWithEmptyString()
        {
           Assert.Equal("R0", TotalPhoneBill.Price(""));
        }
        [Fact]
        public void ShouldReturnZeroWhenCalledWithBunlesOrMMS()
        {
           Assert.Equal("R0", TotalPhoneBill.Price("bundles, bundles, mms"));
        }
    }
}