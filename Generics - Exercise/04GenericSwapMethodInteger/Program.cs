namespace _04GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            string[] swap = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int index1 = int.Parse(swap[0]);
            int index2 = int.Parse(swap[1]);

            box.Swap(index1, index2);

            Console.WriteLine(box);
        }
    }
}
