using InterviewTest;
using InterviewTest.Strategies;

namespace TestManager.Test
{
    public class PrimoTest
    {
        [Fact]
        public void TestPrimo_10() 
        {
            // Arrange
            var primosEsperados = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var primo = new InterviewTest.Strategies.Primo(10);
            primo.Execute();

            // Act
            var list = primo.Response;
            // Assert
            Assert.Equal(primosEsperados, list);
        }

        [Fact]
        public void Test_Strategy_Primo_10() 
        {
            // Arrange
            var primosEsperados = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var strategy = new Primo(10);
            var context = new Context<List<int>>(strategy);

            // Act
            context.ExecuteStrategy();
            var response = context.GetResponse();

            // Assert
            Assert.Equal(primosEsperados, response);

        }
    }
}
