using System;
using Xunit;
using DumbTests;
using static DumbTests.Logic;

namespace DumbTests
{
    [Trait("Category", "Positive")]
    public class Positive
    {
        [Fact(DisplayName = "TrueIsTrue")]
        public void TrueIsTrue()
        {
            Assert.True(TrueValue());
        }

        [Fact(DisplayName = "2+3=5")]
        public void Calculate()
        {            
            Assert.Equal(5, Add(2,3));
        }
    }
}
