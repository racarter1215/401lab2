using System;
using Xunit;
using static Robert_Lab02.Program;

namespace Robert_Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        //below is the beginning of the code for the ViewBalanceTest
        public void ViewBalance()
        {
            //Assert.Equal(expected, Balance);
        }
        //below is the code to test deposits to ensure that they don't contain unauthorized values
        [Theory]
        [InlineData(2000, 7000)]
        [InlineData(1, 5001)]
        [InlineData(10.55, 5010.55)]
        public void DepositTest(decimal amount, decimal expected)
        {
            Balance = 5000;
            Assert.Equal(expected, Deposit(amount));

        }
        //below is the code to test withdraws to ensure that they don't contain unauthorized values
        [Theory]
        [InlineData(2000, 3000)]
        [InlineData(1, 4999)]
        [InlineData(10.55, 4989.45)]
        
        public void WithdrawTest(decimal amount, decimal expected)
        {
            Balance = 5000;
            Assert.Equal(expected, Withdraw(amount));
        }
    }
}
