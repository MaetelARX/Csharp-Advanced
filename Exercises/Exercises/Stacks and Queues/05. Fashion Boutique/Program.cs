namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(boxes);

            int used = 1;

            int currentCapacity = 0;

            while (stack.Count > 0)
            {
                int current = stack.Pop();

                if (current + currentCapacity <= capacity)
                {
                    currentCapacity += current;
                }
                else
                {
                    currentCapacity = current;
                    used++;

                }
            }
            Console.WriteLine(used);
        }
    }
}