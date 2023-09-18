namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int command = numbers[0];

                if(command == 1)
                {
                    int number = numbers[1];
                    stack.Push(number);
                }
                else if(command == 2)
                {
                    stack.Pop();
                }
                else if(command == 3) 
                { 
                    if(stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}