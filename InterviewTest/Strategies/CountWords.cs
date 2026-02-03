
namespace InterviewTest.Strategies
{
    /*  CONTANDO PALABRAS
     * Crea un programa que cuente cuantas veces se repite cada palabra
     * y que muestre el recuento final de todas ellas.
     * - Los signos de puntuación no forman parte de la palabra.
     * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
     * - No se pueden utilizar funciones propias del lenguaje que
     *   lo resuelvan automáticamente.
     */
    public class CountWords : IStrategy<WordCount[]>
    {
        private readonly string _text;
        public WordCount[] totalWords { get; set; }
        public CountWords(string text)
        {
            _text = text;
        }

        public WordCount[] Response => this.totalWords;

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }   

}
