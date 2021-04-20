using System;
using Xunit;

namespace PrimeService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 class1 = new Class1();
            int result = class1.dummy();
            Assert.Equal(1, result);
        }
    }
}
