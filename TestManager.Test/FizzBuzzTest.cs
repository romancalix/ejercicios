using InterviewTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        // Casos básicos
        [InlineData(new string[] { "1", "2" }, 2)]
        [InlineData(new string[] { "1", "2", "Fizz" }, 3)]
        [InlineData(new string[] { "1", "2", "Fizz", "4" }, 4)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz" }, 5)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz" }, 6)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" }, 7)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8" }, 8)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz" }, 9)]
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }, 10)]
        public void FizzTest(string[] expectedArray,int cantidad) 
        {
            //arrange
            List<string> expected = new List<string>(expectedArray);
            IStrategy<List<string>> strategy = new InterviewTest.Strategies.FizzBuzz(cantidad);
            var context = new Context<List<string>>(strategy);

            //act
            context.ExecuteStrategy();
            List<string> response = context.GetResponse();

            //assert
            Assert.Equal(expected, response);
        }
    }
}
