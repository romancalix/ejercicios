using InterviewTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager.Test
{
    public class PalindromoTest
    {

        [Theory]
        [InlineData("lonol", true)]
        [InlineData("lonol lonol", true)]
        [InlineData("lonol lonol.", true)]
        [InlineData("anilina", true)]
        [InlineData("Ana lleva al oso la avellana", true)]
        [InlineData("Ana lleva al oso la avellana.", true)]
        [InlineData("Analleva al oso la avellan.", false)]
        public void IsPalindromoTest(string text, bool isPalindromo) 
        {
            //arrange
            IStrategy<bool> strategy = new InterviewTest.Strategies.Palindromo(text);
            var context = new Context<bool>(strategy);

            //act
            context.ExecuteStrategy();
            var response = context.GetResponse();

            //assert
            Assert.Equal(isPalindromo, response);

        }
    }
}
