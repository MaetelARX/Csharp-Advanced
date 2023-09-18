namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Queue<string> car = new Queue<string>();

            string command = Console.ReadLine();

            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (car.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{car.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    car.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}