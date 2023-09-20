using System.Xml.Schema;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 0;

            Queue <int[]>pump = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int petrol = input[0];
                int distance = input[1];

                pump.Enqueue(input);
            }

            while (true)
            {
                int petrol = 0;
                foreach (int[] input in pump)
                {
                    petrol += input[0];

                    int currentDistance = input[1];

                    if (petrol - currentDistance < 0)
                    {
                        petrol = 0;
                        break;
                    }
                    else
                    {
                        petrol -= currentDistance;
                    }
                }

                if (petrol > 0)
                {
                    break;
                }
                current++;
                pump.Enqueue(pump.Dequeue());
            }
            Console.WriteLine(current);
        }
    }
}