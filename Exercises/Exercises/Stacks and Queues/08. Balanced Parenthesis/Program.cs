namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach(var item in input)
            {
                if (item == '('
                    || item == '{'
                    || item == '[')
                {
                    stack.Push(item);
                    continue;
                }

                if(stack.Count == 0)
                {
                    stack.Push(item);
                    break;
                }

                if (item ==  ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (item == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (item == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }

            }
            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}