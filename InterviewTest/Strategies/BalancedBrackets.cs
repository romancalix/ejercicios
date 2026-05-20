namespace InterviewTest.Strategies
{

    /**
     1. Balanced Brackets
        Description:
        Given a string containing only '(', ')', '{', '}', '[', ']', determine if the input string is balanced. A string is balanced if:

        Every opening bracket has a corresponding closing bracket of the same type.

        Brackets are closed in the correct order.

        Input Format:
        A single string s (1 ≤ |s| ≤ 10^4).

        Output Format:
        Print "YES" if balanced, otherwise "NO".

        Sample Input:
        {[()]}

        Sample Output:
        YES
     */
    public class BalancedBrackets : IStrategy<bool>
    {
        private readonly string input;

        public bool Response { get; private set; }

        public BalancedBrackets(string input)
        {
            this.input = input;
        }

        public void Execute()
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> charPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };
            foreach (char c in input) 
            {
                if (charPairs.ContainsKey(c))
                { 
                    stack.Push(c);
                } else if (charPairs.ContainsValue(c) ) 
                {
                    if (stack.Count <= 0) 
                    {
                        this.Response = false;
                        return;
                    }

                    char lastChar = stack.Peek();
                    char keyValue = charPairs.FirstOrDefault(x => x.Value == c).Key;

                    if (lastChar == keyValue)
                    {
                        stack.Pop();
                    }
                    else 
                    {
                        this.Response = false;
                        return;
                    }

                }
            }
            this.Response = stack.Count == 0;
        }
    }
}
