namespace BootcampFunctions.Test
{
    public class TransportFeeTest
    {
        [Fact]
        public void ShouldReturnAmountOfShiftEntered()
        {
            Assert.Equal("R20", TransportFee.Shifts("morning"));
        }

        [Fact]
        public void ShouldReturnFreeForNightShift()
        {
            Assert.Equal("free", TransportFee.Shifts("night"));
        }
        [Fact]
        public void ShouldReturnEmptyStringWhenCalledWithEmptyString()
        {
            Assert.Equal("", TransportFee.Shifts(""));
        }
    }

}