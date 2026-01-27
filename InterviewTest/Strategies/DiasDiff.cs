using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Strategies
{
    /*
 * Crea una función que calcule y retorne cuántos días hay entre dos cadenas
 * de texto que representen fechas.
 * - Una cadena de texto que representa una fecha tiene el formato "dd/MM/yyyy".
 * - La función recibirá dos String y retornará un Int.
 * - La diferencia en días será absoluta (no importa el orden de las fechas).
 * - Si una de las dos cadenas de texto no representa una fecha correcta se
 *   lanzará una excepción.
 */
    public class DiasDiff : IStrategy<int>
    {
        private string _date1;
        private string _date2;

        public DiasDiff(string date1, string date2)
        {
            this._date1 = date1;
            this._date2 = date2;
        }

        public int Response { get; private set; }

        public void Execute()
        {
            var date1 = DateTime.ParseExact(this._date1, "dd/MM/yyyy", null);
            var date2 = DateTime.ParseExact(this._date2, "dd/MM/yyyy", null);
            var diff = (date2 - date1).Duration().Days;
            Console.WriteLine("La diferencia en días es: " + diff);
            this.Response = diff;
        }
    }
}
