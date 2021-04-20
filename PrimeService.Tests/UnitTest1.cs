using System;
using Xunit;

namespace PrimeService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DummyTest()
        {
            PrimeService primeService = new PrimeService();
            int expected = 1;
            int result = primeService.dummy();
            Assert.Equal(expected, result);
        }
    }
}
