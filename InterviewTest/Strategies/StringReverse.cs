namespace InterviewTest.Strategies
{
    /*
     * Escribe un programa que invierta una cadena de texto.
     */
    public class StringReverse : IStrategy<string>
    {
        private string _text;
        public StringReverse(string text)
        {
            this._text = text;
        }
        public void Execute()
        {
           for (int i = this._text.Length -1; i >= 0; i--)
            {
                Response += this._text[i];
            }
        }

        public string Response { get; private set; }
     }
}