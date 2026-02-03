using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewTest.Strategies
{
    /* PALINDROMO
     * Escribe una función que reciba un texto y retorne verdadero o
     * falso (Boolean) según sean o no palíndromos.
     * Un Palíndromo es una palabra o expresión que es igual si se lee
      * de izquierda a derecha que de derecha a izquierda.
     * NO se tienen en cuenta los espacios, signos de puntuación y tildes.
     * Ejemplo: Ana lleva al oso la avellana.
     */
    public class Palindromo : IStrategy<bool>
    {
        private readonly string _text;

        public Palindromo(string text)
        {
            _text = text;
        }

        
        public bool Response { get; private set; }

        public void Execute()
        {

            //string textCleaned = this._text.Replace(" ", "").ToLower();
            string textCleaned = Regex.Replace(this._text.ToLower(), @"[^a-zA-ZáéíóúÁÉÍÓÚñÑüÜ]", "");
            int cont = textCleaned.Length - 1;
            var letter1 = "";
            var letter2 = "";

            for (int i = 0; i< textCleaned.Length; i++) 
            {
                letter1 = textCleaned[i].ToString();
                letter2 = textCleaned[cont].ToString();
                if (textCleaned[i] != textCleaned[cont]) 
                {
                    break;
                }
                cont--;
            }

            this.Response = cont <= 0;
        }
    }
}
