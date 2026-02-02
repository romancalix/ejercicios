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
    public class FizzBuzz : IStrategy<string[]>
    {
        
        private readonly int _cantidad;
        public string[] Response { get; private set; }
        public FizzBuzz(int cantidad)
        {
            _cantidad = cantidad;
            this.Response = new string[cantidad];
        }
        public void Execute()
        {
            int cont = 0;
            for (int i = 1; i <= this._cantidad; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz " + i);
                    this.Response[cont] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz " + i);
                    this.Response[cont] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz " + i);
                    this.Response[cont] = "Buzz";
                }
                else
                {
                    Console.WriteLine(i);
                    this.Response[cont] = i.ToString();
                }
                cont++;
            }
        }
    }
}
