using InterviewTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager.Test
{
    public class FibonacciTest
    {
        [Theory]
        // Casos básicos
        [InlineData(new int[] { 0 }, 1)]                      // Primer número de Fibonacci
        [InlineData(new int[] { 0, 1 }, 2)]                   // Primeros 2 números
        [InlineData(new int[] { 0, 1, 1 }, 3)]                // Primeros 3 números
        [InlineData(new int[] { 0, 1, 1, 2 }, 4)]             // Primeros 4 números
        [InlineData(new int[] { 0, 1, 1, 2, 3 }, 5)]          // Primeros 5 números
        [InlineData(new int[] { 0, 1, 1, 2, 3, 5 }, 6)]       // Primeros 6 números
        [InlineData(new int[] { 0, 1, 1, 2, 3, 5, 8 }, 7)]    // Primeros 7 números
        [InlineData(new int[] { 0, 1, 1, 2, 3, 5, 8, 13 }, 8)] // Primeros 8 números
        public void TestFibonacci(int[] fibo, int cantidad)
        {
            // Aquí irían los métodos de prueba para la clase Fibonacci

            //arrange
            IStrategy<int[]> strategy = new InterviewTest.Strategies.Fibonacci(cantidad);
            var context = new Context<int[]>(strategy);

            //act
            context.ExecuteStrategy();
            int[] response = context.GetResponse();

            //assert
            Assert.Equal(fibo, response);
        }

    }
}
