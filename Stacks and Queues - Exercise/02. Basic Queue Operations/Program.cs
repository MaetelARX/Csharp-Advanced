namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(integers);

            int deque = input[1];
            int looking = input[2];

            for (int i = 0; i < deque; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(looking))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(queue.Count());
                }
            }
        }
    }
}