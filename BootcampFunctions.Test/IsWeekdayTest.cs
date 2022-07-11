namespace BootcampFunctions.Test
{
    public class IsWeekdayTest
    {
        [Fact]
        public void ShouldReturnTrueWhenCalledWithAWeekday()
        {
            Assert.Equal(true, IsWeekday.Weekdays("Monday"));
        }
        [Fact]

        public void ShouldReturnFalseWhenCalledWithWeekendDay()
        {
            Assert.Equal(false, IsWeekday.Weekdays("Sunday"));
        }

    }
}