using InterviewTest;
using InterviewTest.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager.Test
{
    public class BalancedBracketsTest
    {
        [Theory]
        [InlineData("{[()]}", true)]
        [InlineData("({[]})[]()", true)]
        [InlineData("{[(])}", false)]
        [InlineData("()(", false)]
        [InlineData("())", false)]
        [InlineData("[[[{{(", false)]
        [InlineData("{[)(]}", false)]
        [InlineData("[{(})]", false)]
        [InlineData(")(", false)]
        public void TestBalancedBrackets(string input, bool response) 
        {
            //arrange
            IStrategy<bool> strategy = new BalancedBrackets(input);
            var context = new Context<bool>(strategy);

            //act
            context.ExecuteStrategy();

            //assert
            Assert.Equal(response, strategy.Response);
        }
    }
}
