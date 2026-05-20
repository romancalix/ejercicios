namespace InterviewTest.Strategies
{
    
    /*
     * Escribe una función que reciba un número entero y retorne su factorial.
     * - El factorial de un número entero n es el producto de todos los enteros positivos menores o iguales a n.
     * - El factorial de 0 es 1.
     * - El factorial de un número negativo no está definido.
     */

    public class Factorial : IStrategy<int>
    {
        private readonly int _number;
        public int Response { get; private set; }


        public Factorial(int number)
        {
            _number = number;
        }

        
        public void Execute()
        {
            if (this._number < 0)
            {
                Console.WriteLine("El factorial de un número negativo no está definido.");
                this.Response = -1; // Indicador de error
            }
            else if (this._number ==0)
            {
                this.Response = 1; // El factorial de 0 es 1
            }
            else
            {
                int factorial = 1;
                for (int i =1 ; i<= this._number; i++)
                {
                    factorial *= i;
                }
                this.Response = factorial;
            }
        }
    }

}