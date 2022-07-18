using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test
{
    public class GreetTest
    {
        [Fact]
        public void ShouldBeAbleToGreetJo()
        {            
            Assert.Equal("Hello, Jo", Greet.Execute("Jo"));
        }

        [Fact]
        public void ShouldBeReturnAPleaseEnterNameMessageIfEmptyStringIsPassed()
        {
            Assert.Equal("Please enter a name", Greet.Execute(""));
        }
    }
}