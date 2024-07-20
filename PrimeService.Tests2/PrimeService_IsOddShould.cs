using System;
using Prime.Services;
using Xunit;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsOddShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsOddShould()
        {
            _primeService = new PrimeService();
        }

        #region Sample_TestCode
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void IsOdd_ValuesWithOdd_ReturnTrue(int value)
        {
            var result = _primeService.IsOdd(value);

            Assert.True(result, $"{value} should be odd");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        public void IsOdd_EvenValueLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsOdd(value);

            Assert.False(result, $"{value} should be even");
        }
    }
}
