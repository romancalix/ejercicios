
namespace InterviewTest.Strategies
{
    /*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
    public class Fibonacci : IStrategy<int[]>
    {
        private int _number;
        public Fibonacci(int number)
        {
            this._number = number;
            this.Response = new int[number];
        }

        public int[] Response { get; private set; }

        public void Execute()
        {
            int anterior1 = 0;
            int fib = 0;
            int[] fibo = new int[this._number];

            for (int i = 0; i < this._number; i++)
            {
                if (i <= 1)
                {
                    fib = anterior1 + i;
                    fibo[i] = fib;
                    anterior1 = fib;
                }
                else 
                {
                    fib = fibo[i-1] + fibo[i-2];
                    fibo[i] = fib;
                }

            }

            for (int i = 0; i < this._number; i++)
            {
                Console.Write(fibo[i]);
            }

            for (int i = 0; i < fibo.Length; i++) 
            {
                Response[i] = fibo[i];
            }
        }
    }
}
