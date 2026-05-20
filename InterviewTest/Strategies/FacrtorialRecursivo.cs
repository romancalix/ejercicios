namespace InterviewTest.Strategies
{
    public class FacrtorialRecursivo : IStrategy<int>
    {
        public int Response {get; private set;}
        private readonly int _number;

        public FacrtorialRecursivo(int number)
        {
            _number = number;
        }


        public void Execute()
        {
            this.Response = Factorial(this._number);
        }

        private int Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("El factorial de un número negativo no está definido.");
                return -1; // Indicador de error
            }
            else if (n == 0)
            {
                return 1; // El factorial de 0 es 1
            }
            else
            {
                return n * Factorial(n - 1);
            }
            
        }

    }
}