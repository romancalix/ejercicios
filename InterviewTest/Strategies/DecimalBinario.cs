
namespace InterviewTest.Strategies
{
    /*
     * Crea un programa se encargue de transformar un número
     * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
     */

    /**
     Método 1: División sucesiva por 2 (Recomendado)
        Pasos:

        Dividir el número decimal entre 2

        Anotar el cociente y el resto (0 o 1)

        Repetir con el cociente hasta que sea 0

        Leer los restos de abajo hacia arriba

        Ejemplo: Convertir 13₁₀ a binario

        text
        13 ÷ 2 = 6  resto 1  ↑
         6 ÷ 2 = 3  resto 0  |
         3 ÷ 2 = 1  resto 1  | Leer de ABAJO hacia ARRIBA
         1 ÷ 2 = 0  resto 1  ↓
     */
    public class DecimalBinario : IStrategy<string>
    {
        private readonly int _number;
        public string binary { get; private set; }

        public DecimalBinario(int number)
        {
            _number = number;
        }

        public string Response => binary;

        public void Execute()
        {
            int rest = 1;
            int num = 1;
            int number = this._number;

            while (num > 0) 
            {
            
                rest = number % 2;
                num = number / 2;
                binary = rest.ToString() + binary;
                number = num;


            }
        }
    }
}
