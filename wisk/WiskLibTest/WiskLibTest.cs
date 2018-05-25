using System;
using Xunit;

namespace WiskLibTest
{
    public class WiskLibTest
    {
        [Fact]
        public void SqShouldReturnSquare()
        {
            Assert.Equal(9, WiskLib2.WiskLib2.Sq(3));
        }

        [Fact]
        public void ConstrainShouldConstrainInputValue()
        {
            Assert.Equal(4, WiskLib2.WiskLib2.Constrain(4, 0, 10));
            Assert.Equal(5, WiskLib2.WiskLib2.Constrain(4, 5, 10));
            Assert.Equal(10, WiskLib2.WiskLib2.Constrain(12, 5, 10));
            
           
        }

    }
}
