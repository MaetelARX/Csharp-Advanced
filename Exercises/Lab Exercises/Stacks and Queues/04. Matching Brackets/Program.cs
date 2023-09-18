namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int opening = stack.Pop();

                    Console.WriteLine(expression.Substring(opening, i - opening + 1));
                }
            }
        }
    }
}