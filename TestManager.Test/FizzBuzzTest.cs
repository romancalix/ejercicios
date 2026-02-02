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
        [InlineData(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, 15)]
        public void FizzTest(string[] expectedArray,int cantidad) 
        {
            //arrange
            //string[] expected = new string[expectedArray];
            IStrategy<string[]> strategy = new InterviewTest.Strategies.FizzBuzz(cantidad);
            var context = new Context<string[]>(strategy);

            //act
            context.ExecuteStrategy();
            string[] response = context.GetResponse();

            //assert
            Assert.Equal(expectedArray, response);
        }
    }
}
