namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int push = input[0];

            Stack<int> stack = new Stack<int>(integers.Take(push));

            int Poped = input[1];
            int Looking = input[2];

            for (int i = 0; i < Poped && stack.Count > 0; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(Looking))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(stack.Count);
                }
            }
        }
    }
}