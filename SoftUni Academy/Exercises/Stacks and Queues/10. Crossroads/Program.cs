namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int windowSeconds = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passed = 0;

            string command = Console.ReadLine();
            while (command != "END")
            {

                if (command != "green")
                {
                    cars.Enqueue(command);
                    command = Console.ReadLine();
                    continue;
                }
                int current = seconds;

                while (cars.Count > 0)
                {
                    string car = cars.Dequeue();
                    if (current - car.Length > 0)
                    {
                        current -= car.Length;
                        passed++;
                        continue;
                    }
                    else if (current + windowSeconds - car.Length > 0)
                    {
                        passed++;
                        break;
                    }
                    else
                    {
                        char symbol = car[current + windowSeconds];
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{car} was hit at {symbol}.");

                        Environment.Exit(0);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passed} total cars passed the crossroads.");
        }
    }
}