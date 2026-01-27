using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Strategies
{
    /*
     * Escribe un programa que muestre por consola (con un print) los
     * números de 1 a 100 (ambos incluidos y con un salto de línea entre
     * cada impresión), sustituyendo los siguientes:
     * - Múltiplos de 3 por la palabra "fizz".
     * - Múltiplos de 5 por la palabra "buzz".
     * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
     */
    public class FizzBuzz : IStrategy<List<string>>
    {
        public List<string> Response { get; private set; } = new List<string>();
        private readonly int _cantidad;
        public FizzBuzz(int cantidad)
        {
            _cantidad = cantidad;
        }
        public void Execute()
        {
            for (int i = 1; i <= this._cantidad; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz " + i);
                    this.Response.Add("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz " + i);
                    this.Response.Add("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz " + i);
                    this.Response.Add("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                    this.Response.Add(i.ToString());
                }
            }
        }
    }
}
