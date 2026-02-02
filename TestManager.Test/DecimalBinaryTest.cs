

using InterviewTest;
using InterviewTest.Strategies;

namespace TestManager.Test
{
    public class DecimalBinaryTest
    {
        [Theory]
        [InlineData(10, "1010")]
        [InlineData(0, "0")]
        [InlineData(255, "11111111")]
        [InlineData(1, "1")]
        [InlineData(13, "1101")]
        public void DecimalToBinaryTest(int number, string binaryResult)
        {
            // Arrange
            IStrategy<string> strategy = new DecimalBinario(number);

            // Act
            strategy.Execute();
            var result = strategy.Response;
            
            // Assert
            Assert.Equal(binaryResult, result);

        }
    }
}
