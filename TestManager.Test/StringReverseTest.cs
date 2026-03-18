using InterviewTest;

namespace TestManager.Test
{
    
    public class StringReverseTest
    {
        [Fact]
        public void TestStringReverse()
        {
            //arrange
            string text = "Hello World!";
            string expected = "!dlroW olleH";
            IStrategy<string> strategy = new InterviewTest.Strategies.StringReverse(text);
            var context = new Context<string>(strategy);
            //act
            context.ExecuteStrategy();
            string response = context.GetResponse();
            //assert
            Assert.Equal(expected, response);

        }

        [Theory]
        [InlineData("Hello World!", "!dlroW olleH")]
        [InlineData("OpenAI", "IAnepO")]
        [InlineData("Test", "tseT")]
        public void TestStringReverseTheory(string text, string expected)
        {
            //arrange
            IStrategy<string> strategy = new InterviewTest.Strategies.StringReverse(text);
            var context = new Context<string>(strategy);
            
            //act
            context.ExecuteStrategy();
            string response = context.GetResponse();
            //assert
            Assert.Equal(expected, response);
        }
    }
}