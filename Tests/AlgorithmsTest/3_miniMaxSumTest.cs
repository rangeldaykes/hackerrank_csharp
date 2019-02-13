using System;
using Xunit;
using Algorithms;
using FluentAssertions;

namespace AlgorithmsTest
{
    public class miniMaxSumTest
    {        
        [Fact]
        public void miniMaxSum_solution1_Test()
        {
            var ar = new long[] { 1, 2, 3, 4, 5 };
            var result = new miniMaxSum().miniMaxSum_solution1(ar);

            const string value = "10 14";

            //Assert.Equal(31, result);

            result.Should().Be(value, $"The sum of array Should be ({value})");
        }
    }
}
