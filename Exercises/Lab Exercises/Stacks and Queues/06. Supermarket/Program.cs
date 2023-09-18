namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            int count = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if(names.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{names.Dequeue()}");
                    }
                    count = 0;
                }
                else
                {
                    names.Enqueue(input);
                    count++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} people remaining.");
        }
    }
}