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
    public class Primo : IStrategy<List<int>>
    {
        private int _number;
        public Primo(int number)
        {
            this._number = number;
            this.Response = new List<int>();
        }
        public void Execute()
        {
            int total_primos = 0;
            int i = 1;
            while (total_primos < this._number)
            {
               
                if (this.IsPrimo(i) ) 
                {
                    Console.WriteLine("El número " + i + " es primo");
                    Response.Add(i);
                    total_primos++;
                }
                i++;
            }
        }

        private bool IsPrimo(int number) 
        {
            if (number == 1) return false;

            int cont = 0;

            for (int j = 1; j <= number; j++)
            {
                if (number % j == 0)
                {
                    cont++;
                }
                if (cont > 2)
                {
                    break;
                } 
                
            }

            return cont == 2;
        }
    
        public List<int> Response { get; private set; }
     }
}
