using System;
using Xunit;
using static Robert_Lab02.Program;

namespace Robert_Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance()
        {
            //int number = 5000;
            //Assert.Equal(5000);
        }

        [Theory]
        [InlineData(2000, 7000)]
        [InlineData(1, 5001)]
        [InlineData(10.55, 5010.55)]
        public void DepositTest(decimal amount, decimal expected)
        {
            Balance = 5000;
            Assert.Equal(expected, Deposit(amount));

        }
    }
}
