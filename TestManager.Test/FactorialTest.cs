using InterviewTest;
using InterviewTest.Strategies;
namespace TestManager.Test
{
    public class FactorialTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void TestFactorial(int number, int expected)
        {
            //Arrange
            IStrategy<int> strategy = new Factorial(number);
            
            //Act
            strategy.Execute();
            var response = strategy.Response;

            //Assert
            Assert.Equal(expected, response);
        }
    }
}