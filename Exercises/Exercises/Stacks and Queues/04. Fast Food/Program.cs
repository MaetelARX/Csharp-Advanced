namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(order);

            int sum = 0;

            foreach (var item in queue)
            {
                sum += item;
            }

            Console.WriteLine(queue.Max());

            if (quantity >= sum)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                for (int i = 0; i < order.Length; i++)
                {
                    if (quantity >= order[i])
                    {
                        quantity -= order[i];
                        queue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Write("Orders left: ");

                foreach (var item in queue)
                {
                    Console.Write($"{item} ");
                }
            }
        }

    }
}