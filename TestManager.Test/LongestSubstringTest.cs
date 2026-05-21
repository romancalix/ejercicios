using InterviewTest;
using InterviewTest.Strategies;

namespace TestManager.Test
{
    public class LongestSubstringTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("abcdef", 6)]
        [InlineData("abba", 2)]
        [InlineData("dvdf", 3)]  // Este suele fallar en implementaciones incorrectas
        [InlineData("tmmzuxt", 5)]  // Clásico caso tricky
        public void LongestSubsTest(string cad, int val) 
        {
            //arrange
            IStrategy<int> strategy = new LongestSubstring(cad);
            var context = new Context<int>(strategy);

            //act
            context.ExecuteStrategy();
            int response = context.GetResponse();

            //assert
            Assert.Equal(val, response);

        }

        [Theory]
        [InlineData("dvdf", 3)]
        [InlineData("tmmzuxt", 5)]
        [InlineData("abba", 2)]
        public void VerificacionDirecta(string cad, int val)
        {
            // Sin usar Context, directamente la estrategia
            var strategy = new LongestSubstring(cad);
            strategy.Execute();

            Console.WriteLine($"Input: {cad}");
            Console.WriteLine($"Resultado obtenido: {strategy.Response}");
            Console.WriteLine($"Resultado esperado: {val}");

            Assert.Equal(val, strategy.Response);
        }
    }
}
