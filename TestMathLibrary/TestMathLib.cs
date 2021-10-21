using System;
using Xunit;

namespace TestMathLibrary
{
    public class TestMathLib
    {
        [Fact]
        public void TestPI()
        {
            Assert.Equal(3.1415926m, MathLibrary.MathLib.PI);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        public void TestAdd(int ans, int a, int b)
        {

            Assert.Equal(3, MathLibrary.MathLib.Add(1, 2));
        }

        [Theory]
        [InlineData(18, 3, 6)]
        [InlineData(64, 8, 8)]
        [InlineData(100, 50, 2)]
        public void TestMult(int ans, int a, int b)
        {
            Assert.Equal(18, MathLibrary.MathLib.Mult(3, 6));
        }
    }
}
