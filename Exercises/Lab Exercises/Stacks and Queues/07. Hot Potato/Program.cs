namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> child = new Queue<string>(Console.ReadLine().Split(" "));

            int toss = int.Parse(Console.ReadLine());
            int tossess = 0;
            while (child.Count > 1)
            {
                tossess ++;
                string potatoGuy = child.Dequeue();

                if (tossess == toss)
                {
                    tossess = 0;
                    Console.WriteLine($"Removed {potatoGuy}");
                }
                else
                {
                    child.Enqueue(potatoGuy);
                }
            }
            Console.WriteLine($"Last is {child.Dequeue()}");
        }
    }
}