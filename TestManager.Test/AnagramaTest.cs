using InterviewTest;
using InterviewTest.Strategies;

namespace TestManager.Test
{
    public class AnagramaTest
    {
        [Fact]
        public void TestAnagrama_true()
        {
            // Arrange
            IStrategy<bool> strategy = new Anagrama("amor", "roma" );
            var context = new Context<bool>(strategy);
    
            // Act
            context.ExecuteStrategy();
            var response = context.GetResponse();
            // Assert
            Assert.True(response);

        }

        [Fact]
        public void TestAnagrama_false()
        {
            // Arrange
            IStrategy<bool> strategy = new Anagrama("amor", "roman");
            var context = new Context<bool>(strategy);

            // Act
            context.ExecuteStrategy();
            var response = context.GetResponse();
            // Assert
            Assert.False(response);

        }

        [Theory]
        [InlineData("roma", "amor", true)]
        [InlineData("amor", "roman", false)]
        //[InlineData("roman", "amor ", true)]   // Con espacio al final
        [InlineData("listen", "silent", true)]
        [InlineData("hello", "world", false)]
        [InlineData("abc", "abcd", false)]    // Longitudes diferentes
        public void TestAnagrama_InlineData(string word1, string word2, bool expected) 
        {
            // Arrange
            IStrategy<bool> strategy = new Anagrama(word1, word2);
            var context = new Context<bool>(strategy);

            // Act
            context.ExecuteStrategy();
            var response = context.GetResponse();
            // Assert
            Assert.Equal(response, expected);
        }
    }
}
