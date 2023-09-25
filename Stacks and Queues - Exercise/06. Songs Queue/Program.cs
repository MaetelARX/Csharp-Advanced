namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(input);

            while (true)
            {
                string[] newcommand = Console.ReadLine().Split();

                if (newcommand[0] == "Play")
                {
                    if (queue.Any())
                    {
                        queue.Dequeue();
                    }
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }

                if (newcommand[0] == "Add")
                {
                    string newSong = string.Join(" ",newcommand.Skip(1));

                    if (queue.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(newSong);
                    }
                }
                if (newcommand[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue ));
                }
            }
        }
    }
}