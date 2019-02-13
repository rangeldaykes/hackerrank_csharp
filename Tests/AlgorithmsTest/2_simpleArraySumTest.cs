using System;
using Xunit;
using Algorithms;
using FluentAssertions;

namespace AlgorithmsTest
{
    public class simpleArraySumTest
    {        
        [Fact]
        public void simpleArraySum_solution1_Test()
        {
            var ar = new int[] { 1, 2, 3, 4, 10, 11 };
            var result = new simpleArraySum().simpleArraySum_solution1(ar);

            const int value = 31;

            //Assert.Equal(31, result);

            result.Should().Be(value, $"The sum of array Should be ({value})");
        }
    }
}
