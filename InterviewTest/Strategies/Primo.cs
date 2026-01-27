using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Strategies
{
 /*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */
    public class Primo : IStrategy
    {
        private int _number;
        public Primo()
        {
            this._number = 20;
        }
        public void Execute()
        {
            int cont = 0;
            for (int i = 1; i <= this._number; i++) 
            {
                cont = 0;
                for (int j = 1; j <= i; j++) 
                {
                    if (i % j == 0) 
                    {
                        cont++;
                    }
                }

                if (cont  == 2 ) 
                {
                    Console.WriteLine("El número " + i + " es primo");
                    Console.WriteLine("entre 1 " + i  % 1);
                    Console.WriteLine("entre si " + i % i);
                    Console.WriteLine("============================");
                }
            }
        }
    }
}
