namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void ShouldReturnTotatAmountOfCallsAndSmsMade()
        {
           Assert.Equal("R" + 9.55, TotalPhoneBill.Price("call,call,sms,call,sms"));
        }
        [Fact]
        public void ShouldReturnZeroRandWhenCalledWithEmptyString()
        {
           Assert.Equal("R" + 0.00, TotalPhoneBill.Price(""));
        }
        [Fact]
        public void ShouldReturnZeroWhenCalledWithBunlesOrMMS()
        {
           Assert.Equal("R" + 0.00, TotalPhoneBill.Price("bundles, bundles, mms"));
        }
    }
}