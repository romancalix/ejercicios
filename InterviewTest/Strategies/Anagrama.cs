namespace InterviewTest.Strategies
{
 /*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */
    public class Anagrama : IStrategy<bool>
    {
        private string _word1;
        private string _word2;
        public Anagrama(string word1, string word2)
        {
            this._word1 = word1;
            this._word2 = word2;
        }

        public bool Response { get; private set; }

        public void Execute()
        {
            for (int i = 0; i <= this._word1.Length - 1 ; i++)
            {
                this._word2 = this._word2.Replace(this._word1[i].ToString(), "");
            }

            if (this._word1 != this._word2 && this._word2.Length == 0)
            {
                Console.WriteLine("Las palabras son anagramas");
                this.Response = true;
            }
            else
            {
                Console.WriteLine("Las palabras no son anagramas");
                this.Response = false;
            }
        }
    }
}
