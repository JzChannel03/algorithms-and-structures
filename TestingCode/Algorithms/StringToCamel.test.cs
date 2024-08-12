using CSharpAlgorithmsAndStructures.Algorithms;
using System;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestingCode.Algorithms
{
    public class DigitalRootTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 1)]
        [InlineData(16, 7)]
        [InlineData(195, 6)]
        [InlineData(992, 2)]
        [InlineData(167346, 9)]
        [InlineData(999999999999, 9)]
        public void Tests(long n, int expectedResult)
        {
            Assert.Equal(expectedResult, DigitalRoot.Run(n));
        }
    }
}