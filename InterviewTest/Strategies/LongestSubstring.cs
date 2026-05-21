namespace InterviewTest.Strategies
{
    public class LongestSubstring : IStrategy<int>
    {
        public int Response { get; set; }
        private readonly string _input;

        public LongestSubstring(string input)
        {
            _input = input;
        }

        public void Execute()
        {
            int mayor = 0;
            int count = 0;
            Stack<char> cadena = new Stack<char>();
            foreach (var item in _input) 
            {

                for (int i = count; i < this._input.Count(); i++)
                {
                    if (cadena.Contains(this._input[i]))
                    {
                        mayor = mayor > cadena.Count ? mayor : cadena.Count;
                        cadena.Clear();
                        break;
                    }
                    else
                    {
                        cadena.Push(this._input[i]);
                    }
                }

                count++;
            }

            this.Response = mayor;
        }
    }
}
