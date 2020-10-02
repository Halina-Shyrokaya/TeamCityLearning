using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static DumbTests.Logic;

namespace DumbTests
{
    [Trait("Category", "Negative")]
    public class Negative
    {
        [Fact(DisplayName = "DivisionByZero")]
        public void DivisionByZero()
        {            
            Assert.Throws<DivideByZeroException>(() => Divide(5,0));
        }
    }
}